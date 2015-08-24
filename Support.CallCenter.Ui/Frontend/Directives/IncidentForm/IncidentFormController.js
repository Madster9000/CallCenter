var IncidentFormController = function ($scope, $window, incidentsService, modalViewModelFactory, incomingNotesService, channelsService)
{
    $scope.IncidentModal = modalViewModelFactory.GetInstance();

    $scope.IncidentFormViewModel =
        {
            IsTypical: false,
            IsSupportIncident: true,
            CloseAfterRegistration: false,

            Header: "",
            Body: "",
            Specialization: "",
            ContactId: null,
            OrganizationId: null,
            FunctionalId: null,
            SubjectId: null,
            CloseReason: "",
            CallId: ""
        };

    $scope.IncidentThemes = incidentsService.IncidentThemes;
    $scope.SelectedType = {};

    var clearForm = function()
    {
        $scope.IncidentFormViewModel.Header = "";
        $scope.IncidentFormViewModel.Body = "";
        $scope.IncidentFormViewModel.CloseReason = "";
        $scope.IncidentFormViewModel.FunctionalId = null;
        $scope.IncidentFormViewModel.SubjectId = null;
        $scope.IncidentFormViewModel.Specialization = "";
        $scope.IncidentFormViewModel.CloseAfterRegistration = false;
    }

    $scope.IncidentFormEvents =
        {
            ChannelMessageReceived: function(sender, message)
            {
                $scope.IncidentFormViewModel.ContactId = message.CrmInfo.Id;
                $scope.IncidentFormViewModel.OrganizationId = message.CrmInfo.OrganizationId;
                $scope.IncidentFormViewModel.CallId = message.PbxUniqueId;

                clearForm();

                $scope.IncidentModal.Show();
            },
            CreateButtonClicked: function()
            {
                console.log($scope.IncidentFormViewModel);
                incidentsService
                    .CreateIncident($scope.IncidentFormViewModel)
                    .then
                    (
                        function(response)
                        {
                            
                            var incidentId = response.data;
                            if (incidentId == null)
                            {
                                return;
                            }
                            var callAction =
                                {
                                    Title: "Создано обращение",
                                    Description: "Создано обращение. Смотри связанное обращение.",
                                    ContactId: $scope.IncidentFormViewModel.ContactId,
                                    CallId: $scope.IncidentFormViewModel.CallId,
                                    IncidentId: incidentId
                                };
                            incomingNotesService.CreateNote(callAction);


                            var incidentUrl = "http://google.ru";
                            $window.open(incidentUrl, "_blank");
                        }
                    );
                $scope.IncidentModal.Hide();
            },
            ThemeChanged: function()
            {
                console.log($scope.IncidentFormViewModel);
                $scope.IncidentFormViewModel.Header = $scope.SelectedType.Header;
                $scope.IncidentFormViewModel.Body = $scope.SelectedType.Description;
                $scope.IncidentFormViewModel.CloseReason = $scope.SelectedType.CloseReason;
                $scope.IncidentFormViewModel.Specialization = $scope.SelectedType.Specialization;
                $scope.IncidentFormViewModel.FunctionalId = $scope.SelectedType.FunctionalId;
                $scope.IncidentFormViewModel.SubjectId = $scope.SelectedType.SubjectId;
            },
            IsTypicalChanged: function()
            {
                if ($scope.IncidentFormViewModel.IsTypical)
                {
                    return;
                }

                clearForm();
            }
        }

    channelsService.IncidentButtonClickedChannel.Subscribe($scope.IncidentFormEvents.ChannelMessageReceived);
}