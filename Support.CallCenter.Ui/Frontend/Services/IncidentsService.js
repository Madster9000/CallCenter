var IncidentsService = function($http)
{
    var createIncident = function(incidentModel)
    {
        var requestUrl = "/incidents";

        var requestPromise = $http.post(requestUrl, incidentModel);

        return requestPromise;
    }

    var findIncident = function (incidentId) {
        var requestUrl = "/incidents?Id="+ incidentId;

        var requestPromise = $http.get(requestUrl);

        return requestPromise;
    }

    var incidentThemes = [
        {
            Name: "тест",
            Header: "тет",
            Description: "тест",
            CloseReason: "тест",
            Specialization: 0,
            FunctionalId: "0",
            SubjectId: "0"
        }
    ];
    

    var incidentsService =
        {
            CreateIncident: createIncident,
            FindIncident: findIncident,
            IncidentThemes: incidentThemes
        };
    return incidentsService;
}