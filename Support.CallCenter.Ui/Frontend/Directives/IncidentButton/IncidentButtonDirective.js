var IncidentButtonDirective = function()
{
    return {
        restrict: "A",
        scope:
            {
                stCallModel: "="
            },
        templateUrl: "Frontend/Directives/IncidentButton/IncidentButtonTemplate.html",
        controller: "IncidentsButtonCtrl"
    };
}