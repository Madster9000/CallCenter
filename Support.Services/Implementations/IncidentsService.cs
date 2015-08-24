using System;
using System.Linq;
using System.Security.Authentication;
using System.Security.Principal;
using Microsoft.Xrm.Client;
using Support.Cqrs.Contracts.Incident;
using Support.Crm.Model.Entities;
using Support.Crm.Repository.Interfaces;
using Support.Services.Interfaces;

namespace Support.Services.Implementations
{
    public class IncidentsService : IIncidentsService
    {
        private readonly IRepository<Incident> mIncidentsRepository;
        private readonly ISystemUsersService mSystemUsersService;

        private static readonly Guid mZSupportId = new Guid("CBAB2D5C-B84F-DF11-A837-00155D1A6310");

        public IncidentsService(IRepository<Incident> incidentsRepository, ISystemUsersService systemUsersService )
        {
            mIncidentsRepository = incidentsRepository;
            mSystemUsersService = systemUsersService;
        }

        public Guid CreateNewIncident(CreateIncidentRequest request, IIdentity currentUser)
        {
            var currentUserId = mZSupportId;
            if (!request.IsSupportIncident)
            {
                //если выбран текущий юзер как ответсвенный, то тащим его айдишник из ЦРМ.
                currentUserId = mSystemUsersService.FindUserIdByIdentity(currentUser);
            }

            if (currentUserId == null)
            {
                throw new AuthenticationException(String.Format("Пользователь с именем {0} не найден в црм", currentUser.Name));
            }

            var incident = new Incident
            {
                Id = Guid.NewGuid(),
                Title = request.Header,
                Description = request.Body,
                New_prichina = request.CloseReason,
                iok_sort_group = request.Specialization,

                CaseOriginCode = 1,
                PriorityCode = 3,
                New_receive = DateTime.Now,
                CaseTypeCode = 1,

                CustomerId = new CrmEntityReference("account", request.OrganizationId),
                ResponsibleContactId = new CrmEntityReference("contact", request.ContactId),
                OwnerId = new CrmEntityReference("systemuser", currentUserId),
                svk_functional = request.FunctionalId == Guid.Empty? null: new CrmEntityReference("svk_functional", request.FunctionalId),
                SubjectId = request.SubjectId == Guid.Empty?null:new CrmEntityReference("subject", request.SubjectId)
            };

            mIncidentsRepository.Create(incident);

            if (request.CloseAfterRegistration)
            {
                mIncidentsRepository.Deactivate(incident, 0, 0);
            }
            return incident.Id;
        }

    }
}