var AddContactFormController = function($scope, contactsService, modalViewModelFactory, channelsService)
{
    $scope.AddContactFormModal = modalViewModelFactory.GetInstance();

    $scope.AddContactFormViewModel =
        {
            FirstName: "",
            LastName: "",
            RouteNumber: "",

            SelectedContact: {},
            ItemsOnPage: 6,
            CurrentPage: 0,
            TotalPages: 0,

            IsDataLoaded: true
        };

    $scope.CallModel = {}
    $scope.FoundContacts = [];

    $scope.AddContactFormEvents =
        {
            AddContactMessageReceived: function(sender, message)
            {
                $scope.CallModel = message;
                $scope.AddContactFormModal.Show();
            },
            FindButtonClicked: function()
            {
                contactsService
                    .GetContactsBySearchContract($scope.AddContactFormViewModel)
                    .then
                    (
                        function(response)
                        {
                            $scope.AddContactFormViewModel.CurrentPage = 0;
                            $scope.AddContactFormViewModel.TotalPages = Math.ceil(response.data.length / $scope.AddContactFormViewModel.ItemsOnPage);
                            $scope.FoundContacts = response.data;
                        }
                    );
            },
            SaveButtonClicked: function()
            {
                var channelMessage =
                    {
                        Id: $scope.CallModel.PbxUniqueId,
                        NewInfo: $scope.AddContactFormViewModel.SelectedContact
                    }
                channelsService.ContactChangedChannel.Publish("AddContactFormController", channelMessage);
                $scope.AddContactFormModal.Hide();
            },
            NextPageClicked: function()
            {
                if ($scope.AddContactFormViewModel.CurrentPage !== $scope.AddContactFormViewModel.TotalPages)
                {
                    $scope.AddContactFormViewModel.CurrentPage++;
                }
            },
            PreviousPageClicked: function()
            {
                if ($scope.AddContactFormViewModel.CurrentPage !== 0)
                {
                    $scope.AddContactFormViewModel.CurrentPage--;
                }
            }
        }

    channelsService.AddContactButtonClickedChannel.Subscribe($scope.AddContactFormEvents.AddContactMessageReceived);
}