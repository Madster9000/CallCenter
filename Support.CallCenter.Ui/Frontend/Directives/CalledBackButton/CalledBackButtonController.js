var CalledBackButtonController = function ($scope, pbxEventCacheService, asteriskHubService, incomingNotesService)
{
    $scope.ButtonEvents =
        {
            RemoveCall: function()
            {
                var callAction =
                    {
                        Title: "Перезвонил на номер " + $scope.stCallModel.PhoneNumber,
                        Description: "Пользователь перезвонил по номеру " + $scope.stCallModel.PhoneNumber + ". Айди звонка - " + $scope.stCallModel.PbxUniqueId,
                        ContactId: $scope.stCallModel.CrmInfo.Id,
                        CallId: $scope.stCallModel.PbxUniqueId
                    }

                incomingNotesService.CreateNote(callAction);
                asteriskHubService.CallWasCalledBack($scope.stCallModel.PbxUniqueId);
                pbxEventCacheService.RemoveFromCache($scope.stCallModel.PbxUniqueId);
                
            }
        }
}