var IncidentButtonModule = angular.module("IncidentButton", ["CallCenterServices"]);

IncidentButtonModule.directive("stIncidentButton", IncidentButtonDirective);
IncidentButtonModule.controller("IncidentsButtonCtrl", ["$scope","ChannelsSvc", IncidentButtonController]);