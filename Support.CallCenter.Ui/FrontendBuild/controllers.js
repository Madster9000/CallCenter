var IncomingCallsController = function($scope, callsService)
{
    $scope.CallsService = callsService;
};
var MasterPageController = function ($scope, $location, pbxCallsService, asteriskHubService)
{
    $scope.Calls = pbxCallsService;

    $scope.MissedCallsCount = pbxCallsService.MissedCalls.length;

    $scope.isCurrent = function(route)
    {
        return route === $location.path();
    }

    asteriskHubService.Initialize();
};
var MissedCallsController = function ($scope, callsService)
{
    $scope.CallsService = callsService;
};
var ReceivedCallsController = function ($scope, callsService)
{
    $scope.CallsService = callsService;
}