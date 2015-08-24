var CalledBackButtonModule = angular.module("CalledBackButton", ["CallCenterServices"]);

CalledBackButtonModule.directive("stCalledBackButton", CalledBackButtonDirective);
CalledBackButtonModule.controller("CalledBackButtonCtrl", ["$scope", "PbxEventCacheSvc", "AsteriskHubSvc","IncomingNotesSvc", CalledBackButtonController]);