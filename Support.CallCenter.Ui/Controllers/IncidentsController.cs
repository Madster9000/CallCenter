using System;
using System.Web.Http;
using NLog.Fluent;
using Support.CallCenter.Ui.Configuration.NLog;
using Support.Cqrs.Contracts.Incident;
using Support.Services.Interfaces;

namespace Support.CallCenter.Ui.Controllers
{
    public class IncidentsController : ApiController
    {
        private readonly IIncidentsService mIncidentsService;

        public IncidentsController(IIncidentsService incidentsService)
        {
            mIncidentsService = incidentsService;
        }

        public Guid? PostNewIncident(CreateIncidentRequest request)
        {
            NLogContaner.Instance.Error("********************************************");
            NLogContaner.Instance.Error("Айди контакта {0}", request.ContactId);
            NLogContaner.Instance.Error("CloseAfter: {0}", request.CloseAfterRegistration);
            NLogContaner.Instance.Error("IsSupport: {0}", request.IsSupportIncident);
            NLogContaner.Instance.Error("Header: {0}", request.Header);
            NLogContaner.Instance.Error("Body: {0}", request.Body);
            NLogContaner.Instance.Error("Specialization: {0}", request.Specialization);
            NLogContaner.Instance.Error("OrgId: {0}", request.OrganizationId);
            NLogContaner.Instance.Error("FuncId: {0}", request.FunctionalId);
            NLogContaner.Instance.Error("SubjId: {0}", request.SubjectId);
            NLogContaner.Instance.Error("CloseReason: {0}", request.CloseReason);
            try
            {
                var currentUser = User;
                return mIncidentsService.CreateNewIncident(request, currentUser.Identity);
            }
            catch (Exception e)
            {
                NLogContaner.Instance.Error(e.ToString());
                return null;
            }
            
            
        }

    }
}
