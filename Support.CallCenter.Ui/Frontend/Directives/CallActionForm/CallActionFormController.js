var CallActionFormController = function($scope, incomingNotesService, modalViewModelFactory, channelsService)
{
    $scope.CallActionModal = modalViewModelFactory.GetInstance();

    $scope.CallActionFormViewModel =
        {
            Title: "",
            Description: "",
            ContactId: "",
            CallId: "",
            IncidentId: null
        };

    $scope.CallActionFormEvents =
        {
            CreateButtonClicked: function()
            {
                incomingNotesService.CreateNote($scope.CallActionFormViewModel);
                $scope.CallActionModal.Hide();
            },

            ChannelMessageReceived: function(sender, message)
            {
                $scope.CallActionFormViewModel.CallId = message.PbxUniqueId;
                $scope.CallActionFormViewModel.ContactId = message.CrmInfo.Id;
                $scope.CallActionFormViewModel.Title = "Действие по звонку " + message.PbxUniqueId;

                $scope.CallActionModal.Show();
            }
        }

    channelsService.CallActionButtonClickedChannel.Subscribe($scope.CallActionFormEvents.ChannelMessageReceived);
}