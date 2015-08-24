var AddContactButtonController = function($scope, channelsService)
{
    $scope.AddContactButtonEvents =
        {
            AddContactButtonClicked: function ()
            {
                channelsService.AddContactButtonClickedChannel.Publish("AddContactButtonController", $scope.stCallModel);
            }
        }
}