var AsteriskHubService = function($, $timeout, pbxEventCacheService, channelsService)
{
    var hubProxy = {};
    var asteriskChannel = channelsService.AsteriskMessageReceivedChannel;
    var calledBackChannel = channelsService.RemoveCallMessageReceivedChannel;

    //старт подключения к хабу.
    var startConnection = function()
    {
        var connection = $.hubConnection();
        hubProxy = connection.createHubProxy("asteriskHub");

        hubProxy.on("broadcastMessage", function(msg)
        {
            asteriskChannel.Publish("AsteriskHubService", { Messages: msg });
        });
        hubProxy.on("broadcastCalledBackCall", function(msg)
        {
            calledBackChannel.Publish("AsteriskHubService", { CallId: msg });
        });

        //включение логирования в консоли браузера.
        //connection.logging = true;

        connection.start();

        connection.disconnected(function()
        {
            $timeout(function()
            {
                connection.start();
            }, 1000);
        });
    }

    var initialize = function()
    {
        //вытаскиваем закешированные события астериска и стартуем подключение
        pbxEventCacheService
            .GetCache()
            .then
            (
                function(response)
                {
                    //таймаут здесь нужен чтобы старт подключения к астериску осуществлялся после старта всех сервисов.
                    $timeout(function()
                    {
                        asteriskChannel.Publish("AsteriskHubService", { Messages: response.data });
                        startConnection();
                    });
                }
            );
    }

    var callWasCalledBack = function(callId)
    {
        //Вызываем метод из бекенда, чтобы отправить его всем подписчикам на хаб.
        hubProxy.invoke("callWasCalledBack", {PbxEventId: callId});
    }

    var hubService =
        {
            Initialize: initialize,
            CallWasCalledBack: callWasCalledBack
        };

    return hubService;
};
var CallModelFactory = function($interval, contactsService, channelsService)
{
    var callModel = function()
    {
        var callModelScope = this;

        callModelScope.PbxEvents = [];
        callModelScope.PhoneNumber = "";
        callModelScope.PbxUniqueId = "";
        callModelScope.Receiver = "";
        callModelScope.CrmInfo = {};
        callModelScope.ContactLink = "";
        callModelScope.State = "";
        callModelScope.StateDescription = "";

        callModelScope.IsInfoLoaded = false;
        callModelScope.IsContactFound = false;

        //скрываем сообщение об ошибке по умолчанию, чтобы не мелькало
        callModelScope.IsOrganizationExists = true;
        callModelScope.IsClientCardExists = true;

        callModelScope.StartDate = {};
        callModelScope.Duration = {};
        callModelScope.QueueWaitTime = {};

        callModelScope.DurationTimer = {};
        callModelScope.QueueWaitTimer = {};

        callModelScope.UpdateCrmInfo = function ()
        {
            contactsService
                .GetContactByPhoneNumber(callModelScope.PhoneNumber)
                .then
                (
                    function(response)
                    {
                        callModelScope.CrmInfo = response.data;
                        callModelScope.IsInfoLoaded = true;

                        if (response.data.Id === null)
                        {
                            callModelScope.IsContactFound = false;
                            //в случае если контакт не найден скрываем сообщение об ошибке
                            callModelScope.IsOrganizationExists = true;
                            callModelScope.IsClientCardExists = true;
                            callModelScope.ContactLink = "http://google.ru";
                        } else
                        {
                            callModelScope.IsContactFound = true;
                            callModelScope.IsOrganizationExists = response.data.OrganizationId !== null;
                            callModelScope.IsClientCardExists = response.data.ClientCardId !== null;
                            callModelScope.ContactLink = "http://google.ru";
                        }
                    }
                );
        };
        callModelScope.StartTalkTimer = function ()
        {
            callModelScope.DurationTimer = $interval
                (
                    function()
                    {
                        callModelScope.Duration.setSeconds(callModelScope.Duration.getSeconds() + 1);
                    }, 1000
                );
        };
        callModelScope.StopTalkTimer = function ()
        {
            if (callModelScope.DurationTimer != null)
            {
                $interval.cancel(callModelScope.DurationTimer);
                callModelScope.DurationTimer = null;
            }
        };
        callModelScope.StartQueueWaitTimer = function ()
        {
            callModelScope.QueueWaitTimer = $interval
                (
                    function()
                    {
                        callModelScope.QueueWaitTime.setSeconds(callModelScope.QueueWaitTime.getSeconds() + 1);
                    }, 1000
                );
        };
        callModelScope.StopQueueWaitTimer = function ()
        {
            if (callModelScope.QueueWaitTimer != null)
            {
                $interval.cancel(callModelScope.QueueWaitTimer);
                callModelScope.QueueWaitTimer = null;
            }
        };
        callModelScope.OnCrmInfoChanged = function (sender, message)
        {
            console.log(callModelScope);
            if (message.Id === callModelScope.PbxUniqueId)
            {
                callModelScope.CrmInfo = message.NewInfo;
                callModelScope.IsContactFound = true;
                callModelScope.IsOrganizationExists = message.NewInfo.OrganizationId !== null;
                callModelScope.IsClientCardExists = message.NewInfo.ClientCardId !== null;
            }
        };

        channelsService.ContactChangedChannel.Subscribe(callModelScope.OnCrmInfoChanged);
    };

    var getInstance = function(newChannelEvent)
    {
        var call = new callModel();
        call.PhoneNumber = newChannelEvent.CallerIDNum;
        call.State = "new";
        call.StateDescription = "новый звонок";
        call.PbxUniqueId = newChannelEvent.Uniqueid;
        call.PbxEvents.push(newChannelEvent);
        call.StartDate = new Date();
        call.Duration = new Date(0);
        call.QueueWaitTime = new Date(0);

        return call;
    }

    

    var factory =
        {
            GetInstance: getInstance
        };

    return factory;
};
var ChannelFactory = function()
{
    var channel = function()
    {
        this.Sender = {};
        this.Listeners = [];
    };

    channel.prototype.Subscribe = function (listener)
    {
        this.Listeners.push(listener);
    };

    channel.prototype.Publish = function (sender, message)
    {
        for (var i = 0; i < this.Listeners.length; i++)
        {
            this.Listeners[i](sender, message);
        }
    };


    var getInstance = function()
    {
        var newChannel = new channel();

        return newChannel;
    }

    var factory =
        {
            GetInstance: getInstance
        };

    return factory;
};
var ChannelsService = function(channelFactory)
{
    var incidentButtonClickedChannel = channelFactory.GetInstance();
    var callActionButtonClickedChannel = channelFactory.GetInstance();
    var calledBackButtonClickedChannel = channelFactory.GetInstance();

    var asteriskMessageReceivedChannel = channelFactory.GetInstance();
    var removeCallMessageReceivedChannel = channelFactory.GetInstance();
    var addContactButtonClickedChannel = channelFactory.GetInstance();
    var contactChangedChannel = channelFactory.GetInstance();

    var channelsService =
        {
            IncidentButtonClickedChannel: incidentButtonClickedChannel,
            CallActionButtonClickedChannel: callActionButtonClickedChannel,
            CalledBackButtonClickedChannel: calledBackButtonClickedChannel,
            AsteriskMessageReceivedChannel: asteriskMessageReceivedChannel,
            RemoveCallMessageReceivedChannel: removeCallMessageReceivedChannel,
            AddContactButtonClickedChannel: addContactButtonClickedChannel,
            ContactChangedChannel: contactChangedChannel
        }

    return channelsService;
};
var ContactsService = function($http)
{
    var getContactByPhoneNumber = function(phoneNumber)
    {
        var requestUrl = "/contacts/" + phoneNumber;

        var requestPromise = $http.get(requestUrl);

        return requestPromise;
    }

    var getContactsBySearchContract = function(contactSearch)
    {
        var requestUrl = "/contacts?FirstName=" + contactSearch.FirstName + "&LastName=" + contactSearch.LastName + "&RouteNumber=" + contactSearch.RouteNumber;

        requestUrl = encodeURI(requestUrl);
        var requestPromise = $http.get(requestUrl);

        return requestPromise;
    }

    var contactsService =
        {
            GetContactByPhoneNumber: getContactByPhoneNumber,
            GetContactsBySearchContract: getContactsBySearchContract
        };
    return contactsService;
};
var IncidentsService = function($http)
{
    var createIncident = function(incidentModel)
    {
        var requestUrl = "/incidents";

        var requestPromise = $http.post(requestUrl, incidentModel);

        return requestPromise;
    }

    var findIncident = function (incidentId) {
        var requestUrl = "/incidents?Id="+ incidentId;

        var requestPromise = $http.get(requestUrl);

        return requestPromise;
    }

    var incidentThemes = [
        {
            Name: "тест",
            Header: "тет",
            Description: "тест",
            CloseReason: "тест",
            Specialization: 0,
            FunctionalId: "0",
            SubjectId: "0"
        }
    ];
    

    var incidentsService =
        {
            CreateIncident: createIncident,
            FindIncident: findIncident,
            IncidentThemes: incidentThemes
        };
    return incidentsService;
};
var IncomingNotesService = function($http)
{
    var createIncomingNote = function(incomingNoteModel)
    {
        var requestUrl = "/incomingnotes";

        var requestPromise = $http.post(requestUrl, incomingNoteModel);

        return requestPromise;
    }

    var service =
        {
            CreateNote: createIncomingNote
        }

    return service;
};
var ModalViewModelFactory = function ()
{
    var modalViewModel = function ()
    {
        this.IsVisible = false;
    };

    modalViewModel.prototype.Show = function ()
    {
        this.IsVisible = true;
    };

    modalViewModel.prototype.Hide = function ()
    {
        this.IsVisible = false;
    };


    var getInstance = function ()
    {
        var modal = new modalViewModel();
        return modal;
    }

    var factory =
        {
            GetInstance: getInstance
        };

    return factory;
};
var PbxCallsService = function ($rootScope, $timeout, pbxMessagesService, callModelFactory, channelsService)
{
    var supportQueue = "908";
    var normalClearingCause = "16";
    var currentCalls = [];
    var missedCalls = [];
    var receivedCalls =[];

    //создаем новый звонок при событии создания нового канала в астериске
    var createNewCall = function (newChannelEvent)
    {
        
        var callModel = callModelFactory.GetInstance(newChannelEvent);
        if (callModel.PhoneNumber != null && callModel.PhoneNumber != undefined && callModel.PhoneNumber.length > 3)
        {
            //добавляем звонок в начало массива
            currentCalls.unshift(callModel);
            callModel.UpdateCrmInfo();
        }
    }

    //обновляем или удаляем звонок при вхождении звонка в очередь астериска
    var updateJoinedCall = function(joinEvent)
    {
        var currentCall =
            currentCalls
                .filter(function (call) { return call.PbxUniqueId === joinEvent.Uniqueid })[0];
        if (currentCall == null)
        {
            return;
        }
        
        if (joinEvent.Queue === supportQueue)
        {
            currentCall.PbxEvents.push(joinEvent);
            currentCall.State = "joined";
            currentCall.StateDescription = "звонок в очереди";
            currentCall.StartQueueWaitTimer();
        } else
        {
            //удаляем звонок, т.к. он попал не в очередь саппорта
            var callIndex = currentCalls.indexOf(currentCall);
            currentCalls.splice(callIndex, 1);
        }
    }

    //Обновляем принятый звонок
    var updateBridgedCalls = function(bridgeEvent)
    {
        var currentCall =
            currentCalls
                .filter(function (call) { return call.PbxUniqueId === bridgeEvent.Uniqueid1 })[0];

        if (currentCall !== undefined && currentCall != null)
        {
            currentCall.Receiver = bridgeEvent.CallerID2;
            currentCall.State = "bridged";
            currentCall.StateDescription = "звонок принят";
            currentCall.StopQueueWaitTimer();
            currentCall.StartTalkTimer();

            currentCall.PbxEvents.push(bridgeEvent);
        }
        
    }

    //раскидываем по массивам завершённые звонки
    var moveHangupedCalls = function(hangupEvent)
    {
        var currentCall =
            currentCalls
                .filter(function (call) { return call.PbxUniqueId === hangupEvent.Uniqueid })[0];
        
        if (currentCall !== undefined && currentCall != null && hangupEvent.Cause === normalClearingCause)
        {
            switch (currentCall.State)
            {
                case "bridged":
                    currentCall.State = "ended";
                    currentCall.StateDescription = "звонок завершён";
                    currentCall.StopTalkTimer();
                    
                    receivedCalls.unshift(currentCall);
                    break;

                case "joined":
                    currentCall.State = "missed";
                    currentCall.StateDescription = "звонок пропущен";
                    currentCall.StopQueueWaitTimer();

                    missedCalls.unshift(currentCall);
                    break;
            }

            currentCall.PbxEvents.push(hangupEvent);
            var callIndex = currentCalls.indexOf(currentCall);
            currentCalls.splice(callIndex, 1);
        }
    }

    var processNewChannelEvents = function(events)
    {
        events
            .filter
            (
                function (pbxEvent)
                {
                    return pbxMessagesService.PbxEventFilter(pbxEvent, "Newchannel");
                }
            )
            .forEach(createNewCall);
    }

    var processJoinEvents = function(events)
    {
        events
            .filter
            (
                function(pbxEvent)
                {
                    return pbxMessagesService.PbxEventFilter(pbxEvent, "Join");
                }
            )
            .forEach(updateJoinedCall);
    }

    var processBridgeEvents = function (events) {
        events
            .filter
            (
                function (pbxEvent) {
                    return pbxMessagesService.PbxEventFilter(pbxEvent, "Bridge");
                }
            )
            .forEach(updateBridgedCalls);
    }

    var processHangupEvents = function (events) {
        events
            .filter
            (
                function (pbxEvent) {
                    return pbxMessagesService.PbxEventFilter(pbxEvent, "Hangup");
                }
            )
            .forEach(moveHangupedCalls);
    }

    var pbxMessageProcessor = function(messages)
    {
        if (messages.length === 0)
        {
            return;
        }

        //раскидать по массивам
        //processNewChannelEvents(messages);
        //processJoinEvents(messages);
        //processBridgeEvents(messages);
        //processHangupEvents(messages);

        setTimeout
            (
                function()
                {
                    processNewChannelEvents(messages);
                    setTimeout
                        (
                            function()
                            {
                                processJoinEvents(messages);
                                setTimeout
                                    (
                                        function()
                                        {
                                            processBridgeEvents(messages);
                                            setTimeout
                                                (
                                                    function()
                                                    {
                                                        processHangupEvents(messages);
                                                    },
                                                    1000
                                                );
                                        },
                                        1000
                                    );
                            },
                            1000
                        );
                },
                1000
            );
    }

    channelsService.AsteriskMessageReceivedChannel.Subscribe(function(sender, message)
    {
        pbxMessageProcessor(message.Messages);
    });

    channelsService.RemoveCallMessageReceivedChannel.Subscribe(function (sender, message) {
        var currentCall =
            missedCalls
                .filter(function (call) { return call.PbxUniqueId === message.CallId })[0];

        var callIndex = missedCalls.indexOf(currentCall);

        missedCalls.splice(callIndex, 1);
    });
    
    var callsService =
        {
            CurrentCalls: currentCalls,
            MissedCalls: missedCalls,
            ReceivedCalls: receivedCalls
        };

    return callsService;
};
var PbxEventCacheService = function($http)
{
    var getCache = function()
    {
        var requestUrl = "/PbxEventCache";

        var requestPromise = $http.get(requestUrl);

        return requestPromise;
    }

    var removeFromCache = function (callId) {
        var requestUrl = "/PbxEventCache";

        var data =
            {
                PbxEventId: callId
            }
        var requestPromise = $http.post(requestUrl, data);

        return requestPromise;
    }

    var pbxEventCacheService =
        {
            GetCache: getCache,
            RemoveFromCache: removeFromCache
        };
    return pbxEventCacheService;
};
var PbxMessagesService = function()
{
    var valueableEvents = ["Newchannel", "Join", "Bridge", "Hangup", "Dial", "NewCallerid"];

    var pbxEventFilter = function(pbxEvent, pbxEventName)
    {
        return pbxEvent.Event === pbxEventName;
    }

    var pbxMessagesFilter = function(pbxEvent)
    {
        return valueableEvents.indexOf(pbxEvent.Event) >= 0;
    }

    var pbxMessagesService =
        {
            PbxEventFilter: pbxEventFilter,
            PbxMessagesFilter: pbxMessagesFilter
        };

    return pbxMessagesService;
}