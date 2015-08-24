var CallActionButtonDirective = function () {
    return {
        restrict: "A",
        scope:
            {
                stCallModel: "="
            },
        templateUrl: "Frontend/Directives/CallActionButton/CallActionButtonTemplate.html",
        controller: "CallActionButtonCtrl"
    };
}