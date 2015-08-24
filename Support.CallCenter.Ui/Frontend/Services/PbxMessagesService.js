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