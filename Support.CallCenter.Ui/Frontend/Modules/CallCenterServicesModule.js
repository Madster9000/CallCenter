var CallCenterServicesModule = angular.module("CallCenterServices", []);

//factories
CallCenterServicesModule.factory("CallModelFctr", ["$interval", "ContactsSvc","ChannelsSvc", CallModelFactory]);
CallCenterServicesModule.factory("ModalViewModelFctr", [ModalViewModelFactory]);
CallCenterServicesModule.factory("ChannelFctr", [ChannelFactory]);

//services
CallCenterServicesModule.factory("ContactsSvc", ["$http", ContactsService]);
CallCenterServicesModule.factory("IncidentsSvc", ["$http", IncidentsService]);
CallCenterServicesModule.factory("IncomingNotesSvc", ["$http", IncomingNotesService]);
CallCenterServicesModule.factory("PbxEventCacheSvc", ["$http", PbxEventCacheService]);

CallCenterServicesModule.factory("ChannelsSvc", ["ChannelFctr", ChannelsService]);
CallCenterServicesModule.factory("AsteriskHubSvc", ["$", "$timeout", "PbxEventCacheSvc","ChannelsSvc", AsteriskHubService]);
CallCenterServicesModule.factory("PbxMessagesSvc", [PbxMessagesService]);

CallCenterServicesModule.factory("PbxCallsSvc", ["$rootScope", "$timeout", "PbxMessagesSvc", "CallModelFctr", "ChannelsSvc", PbxCallsService]);
