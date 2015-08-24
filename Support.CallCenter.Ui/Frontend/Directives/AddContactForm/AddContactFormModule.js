var AddContactFormModule = angular.module("AddContactForm", ["CallCenterServices"]);

AddContactFormModule.directive("stAddcontactForm", AddContactFormDirective);
AddContactFormModule.controller("AddContactFormCtrl", ["$scope", "ContactsSvc", "ModalViewModelFctr", "ChannelsSvc", AddContactFormController]);