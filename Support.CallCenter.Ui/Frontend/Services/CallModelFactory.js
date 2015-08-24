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
}