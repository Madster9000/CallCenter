var CallActionButtonController = function ($scope, channelsService)
{
    $scope.CallActionEvents =
        {
            CallActionButtonClicked: function()
            {
                channelsService.CallActionButtonClickedChannel.Publish("CallActionButtonController", $scope.stCallModel);
            }
        }
}