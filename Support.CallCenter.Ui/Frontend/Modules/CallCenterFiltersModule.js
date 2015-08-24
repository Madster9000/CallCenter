var CallCenterFiltersModule = angular.module("CallCenterFilters", []);

CallCenterFiltersModule.filter("CallStyleFlt", CallStyleFilter);

CallCenterFiltersModule.filter("ArrayOffsetFlt", function()
{
    return function(input, start)
    {
        start = parseInt(start, 10);
        return input.slice(start);
    };
});