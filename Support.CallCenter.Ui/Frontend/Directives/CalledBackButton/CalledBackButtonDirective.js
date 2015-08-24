var CalledBackButtonDirective = function () {
    return {
        restrict: "A",
        scope:
            {
                stCallModel: "="
            },
        templateUrl: "Frontend/Directives/CalledBackButton/CalledBackButtonTemplate.html",
        controller: "CalledBackButtonCtrl"
    };
}