var callCenterApplication =
    angular.module
        (
            "callCenterApplication",
            [
                "ngRoute",
                "CallCenterServices",
                "CallCenterFilters",
                "CallCenterControllers",
                "CallActionButton",
                "CalledBackButton",
                "IncidentButton",
                "AddContactButton",
                "CallActionForm",
                "IncidentForm",
                "AddContactForm"
            ]
        );

//необходимо для корректно работы SignalR
callCenterApplication.value("$", $);

callCenterApplication
    .config
    ([
        "$routeProvider",
        function($routeProvider)
        {
            $routeProvider
                .when("/incoming",
                    {
                        templateUrl: "Frontend/Views/IncomingCallsView.html",
                        controller: "IncomingCallsCtrl"
                    })
                .when("/missed",
                    {
                        templateUrl: "Frontend/Views/MissedCallsView.html",
                        controller: "MissedCallsCtrl"
                    })
                .when("/received",
                    {
                        templateUrl: "Frontend/Views/ReceivedCallsView.html",
                        controller: "ReceivedCallsCtrl"
                    })
                .otherwise(
                    {
                        redirectTo: "/incoming"
                    });
        }
    ]);