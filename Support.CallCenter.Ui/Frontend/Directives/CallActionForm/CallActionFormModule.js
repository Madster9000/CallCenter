var CallActionFormModule = angular.module("CallActionForm", ["CallCenterServices"]);

CallActionFormModule.directive("stCallactionForm", CallActionFormDirective);
CallActionFormModule.controller("CallActionFormCtrl", ["$scope", "IncomingNotesSvc", "ModalViewModelFctr", "ChannelsSvc", CallActionFormController]);