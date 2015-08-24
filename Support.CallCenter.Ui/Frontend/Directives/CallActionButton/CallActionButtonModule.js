var CallActionButtonModule = angular.module("CallActionButton", ["CallCenterServices"]);

CallActionButtonModule.directive("stCallactionButton", CallActionButtonDirective);
CallActionButtonModule.controller("CallActionButtonCtrl", ["$scope", "ChannelsSvc", CallActionButtonController]);