var AddContactButtonDirective = function()
{
    return {
        restrict: "A",
        scope:
            {
                stCallModel: "="
            },
        templateUrl: "Frontend/Directives/AddContactButton/AddContactButtonTemplate.html",
        controller: "AddContactButtonCtrl"
    };
}