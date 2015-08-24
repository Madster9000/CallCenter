var MasterPageController = function ($scope, $location, pbxCallsService, asteriskHubService)
{
    $scope.Calls = pbxCallsService;

    $scope.MissedCallsCount = pbxCallsService.MissedCalls.length;

    $scope.isCurrent = function(route)
    {
        return route === $location.path();
    }

    asteriskHubService.Initialize();
}