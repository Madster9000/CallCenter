using System;
using System.Security.Principal;
using Support.Cqrs.Contracts.Incident;

namespace Support.Services.Interfaces
{
    public interface IIncidentsService
    {
        Guid CreateNewIncident(CreateIncidentRequest request, IIdentity currentUser);
    }
}