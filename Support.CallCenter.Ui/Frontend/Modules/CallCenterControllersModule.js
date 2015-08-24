var CallCenterControllersModule = angular.module("CallCenterControllers", ["CallCenterServices"]);

CallCenterControllersModule.controller("MasterPageCtrl", ["$scope", "$location", "PbxCallsSvc","AsteriskHubSvc", MasterPageController]);
CallCenterControllersModule.controller("IncomingCallsCtrl", ["$scope", "PbxCallsSvc", IncomingCallsController]);
CallCenterControllersModule.controller("MissedCallsCtrl", ["$scope", "PbxCallsSvc", MissedCallsController]);
CallCenterControllersModule.controller("ReceivedCallsCtrl", ["$scope", "PbxCallsSvc", ReceivedCallsController]);
