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
}