var IncidentButtonController = function ($scope, channelsService)
{

    $scope.IncidentButtonEvents =
        {
            IncidentButtonClicked: function()
            {
                channelsService.IncidentButtonClickedChannel.Publish("IncidentButtonController", $scope.stCallModel);
            }
        }
}