var IncidentFormModule = angular.module("IncidentForm", ["CallCenterServices"]);

IncidentFormModule.directive("stIncidentForm", IncidentFormDirective);
IncidentFormModule.controller("IncidentFormCtrl", ["$scope", "$window", "IncidentsSvc", "ModalViewModelFctr","IncomingNotesSvc","ChannelsSvc", IncidentFormController]);