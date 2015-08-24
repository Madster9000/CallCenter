var AddContactButtonController = function($scope, channelsService)
{
    $scope.AddContactButtonEvents =
        {
            AddContactButtonClicked: function ()
            {
                channelsService.AddContactButtonClickedChannel.Publish("AddContactButtonController", $scope.stCallModel);
            }
        }
};
var AddContactButtonDirective = function()
{
    return {
        restrict: "A",
        scope:
            {
                stCallModel: "="
            },
        templateUrl: "Frontend/Directives/AddContactButton/AddContactButtonTemplate.html",
        controller: "AddContactButtonCtrl"
    };
};
var AddContactButtonModule = angular.module("AddContactButton", ["CallCenterServices"]);

AddContactButtonModule.directive("stAddcontactButton", AddContactButtonDirective);
AddContactButtonModule.controller("AddContactButtonCtrl", ["$scope", "ChannelsSvc", AddContactButtonController]);;
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
};
var AddContactFormDirective = function () {
    return {
        restrict: "A",
        templateUrl: "Frontend/Directives/AddContactForm/AddContactFormTemplate.html",
        controller: "AddContactFormCtrl"
    };
};
var AddContactFormModule = angular.module("AddContactForm", ["CallCenterServices"]);

AddContactFormModule.directive("stAddcontactForm", AddContactFormDirective);
AddContactFormModule.controller("AddContactFormCtrl", ["$scope", "ContactsSvc", "ModalViewModelFctr", "ChannelsSvc", AddContactFormController]);;
var CallActionButtonController = function ($scope, channelsService)
{
    $scope.CallActionEvents =
        {
            CallActionButtonClicked: function()
            {
                channelsService.CallActionButtonClickedChannel.Publish("CallActionButtonController", $scope.stCallModel);
            }
        }
};
var CallActionButtonDirective = function () {
    return {
        restrict: "A",
        scope:
            {
                stCallModel: "="
            },
        templateUrl: "Frontend/Directives/CallActionButton/CallActionButtonTemplate.html",
        controller: "CallActionButtonCtrl"
    };
};
var CallActionButtonModule = angular.module("CallActionButton", ["CallCenterServices"]);

CallActionButtonModule.directive("stCallactionButton", CallActionButtonDirective);
CallActionButtonModule.controller("CallActionButtonCtrl", ["$scope", "ChannelsSvc", CallActionButtonController]);;
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
};
var CallActionFormDirective = function()
{
    return {
        restrict: "A",
        templateUrl: "Frontend/Directives/CallActionForm/CallActionFormTemplate.html",
        controller: "CallActionFormCtrl"
    };
};
var CallActionFormModule = angular.module("CallActionForm", ["CallCenterServices"]);

CallActionFormModule.directive("stCallactionForm", CallActionFormDirective);
CallActionFormModule.controller("CallActionFormCtrl", ["$scope", "IncomingNotesSvc", "ModalViewModelFctr", "ChannelsSvc", CallActionFormController]);;
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
};
var CalledBackButtonDirective = function () {
    return {
        restrict: "A",
        scope:
            {
                stCallModel: "="
            },
        templateUrl: "Frontend/Directives/CalledBackButton/CalledBackButtonTemplate.html",
        controller: "CalledBackButtonCtrl"
    };
};
var CalledBackButtonModule = angular.module("CalledBackButton", ["CallCenterServices"]);

CalledBackButtonModule.directive("stCalledBackButton", CalledBackButtonDirective);
CalledBackButtonModule.controller("CalledBackButtonCtrl", ["$scope", "PbxEventCacheSvc", "AsteriskHubSvc","IncomingNotesSvc", CalledBackButtonController]);;
var IncidentButtonController = function ($scope, channelsService)
{

    $scope.IncidentButtonEvents =
        {
            IncidentButtonClicked: function()
            {
                channelsService.IncidentButtonClickedChannel.Publish("IncidentButtonController", $scope.stCallModel);
            }
        }
};
var IncidentButtonDirective = function()
{
    return {
        restrict: "A",
        scope:
            {
                stCallModel: "="
            },
        templateUrl: "Frontend/Directives/IncidentButton/IncidentButtonTemplate.html",
        controller: "IncidentsButtonCtrl"
    };
};
var IncidentButtonModule = angular.module("IncidentButton", ["CallCenterServices"]);

IncidentButtonModule.directive("stIncidentButton", IncidentButtonDirective);
IncidentButtonModule.controller("IncidentsButtonCtrl", ["$scope","ChannelsSvc", IncidentButtonController]);;
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
};
var IncidentFormDirective = function () {
    return {
        restrict: "A",
        templateUrl: "Frontend/Directives/IncidentForm/IncidentFormTemplate.html",
        controller: "IncidentFormCtrl"
    };
};
var IncidentFormModule = angular.module("IncidentForm", ["CallCenterServices"]);

IncidentFormModule.directive("stIncidentForm", IncidentFormDirective);
IncidentFormModule.controller("IncidentFormCtrl", ["$scope", "$window", "IncidentsSvc", "ModalViewModelFctr","IncomingNotesSvc","ChannelsSvc", IncidentFormController]);