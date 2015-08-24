var AddContactButtonModule = angular.module("AddContactButton", ["CallCenterServices"]);

AddContactButtonModule.directive("stAddcontactButton", AddContactButtonDirective);
AddContactButtonModule.controller("AddContactButtonCtrl", ["$scope", "ChannelsSvc", AddContactButtonController]);