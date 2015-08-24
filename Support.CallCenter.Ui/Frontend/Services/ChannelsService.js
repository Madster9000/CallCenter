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
}