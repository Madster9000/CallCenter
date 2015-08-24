using System.CodeDom.Compiler;
using System.Linq;
using Microsoft.Xrm.Client;
using Microsoft.Xrm.Sdk;
using Support.Crm.Model.Entities;

[assembly: Microsoft.Xrm.Sdk.Client.ProxyTypesAssemblyAttribute()]
namespace Support.Crm.Model
{
    /// <summary>
    /// Represents a source of entities bound to a CRM service. It tracks and manages changes made to the retrieved entities.
    /// </summary>
    [GeneratedCode("CrmSvcUtil", "5.0.9690.3739")]
    public class XrmServiceContext : CrmOrganizationServiceContext
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public XrmServiceContext()
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public XrmServiceContext(CrmConnection connection)
            : base(connection)
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public XrmServiceContext(string contextName) :
            base(contextName)
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public XrmServiceContext(IOrganizationService service) :
            base(service)
        {
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Account"/> entities.
        /// </summary>
        public IQueryable<Account> AccountSet
        {
            get
            {
                return CreateQuery<Account>();
            }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ActivityParty"/> entities.
        /// </summary>
        public IQueryable<ActivityParty> ActivityPartySet
        {
            get
            {
                return CreateQuery<ActivityParty>();
            }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ActivityPointer"/> entities.
        /// </summary>
        public IQueryable<ActivityPointer> ActivityPointerSet
        {
            get
            {
                return CreateQuery<ActivityPointer>();
            }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Annotation"/> entities.
        /// </summary>
        public IQueryable<Annotation> AnnotationSet
        {
            get
            {
                return CreateQuery<Annotation>();
            }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Contact"/> entities.
        /// </summary>
        public IQueryable<Contact> ContactSet
        {
            get
            {
                return CreateQuery<Contact>();
            }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Email"/> entities.
        /// </summary>
        public IQueryable<Email> EmailSet
        {
            get
            {
                return CreateQuery<Email>();
            }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Incident"/> entities.
        /// </summary>
        public IQueryable<Incident> IncidentSet
        {
            get
            {
                return CreateQuery<Incident>();
            }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="iok_action_send_SMS"/> entities.
        /// </summary>
        public IQueryable<iok_action_send_SMS> iok_action_send_SMSSet
        {
            get
            {
                return CreateQuery<iok_action_send_SMS>();
            }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="iok_getphonecall"/> entities.
        /// </summary>
        public IQueryable<iok_getphonecall> iok_getphonecallSet
        {
            get
            {
                return CreateQuery<iok_getphonecall>();
            }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="New_Probe"/> entities.
        /// </summary>
        public IQueryable<New_Probe> New_ProbeSet
        {
            get
            {
                return CreateQuery<New_Probe>();
            }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="new_shtrafy"/> entities.
        /// </summary>
        public IQueryable<new_shtrafy> new_shtrafySet
        {
            get
            {
                return CreateQuery<new_shtrafy>();
            }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="svk_project"/> entities.
        /// </summary>
        public IQueryable<svk_project> svk_projectSet
        {
            get
            {
                return CreateQuery<svk_project>();
            }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SystemUser"/> entities.
        /// </summary>
        public IQueryable<SystemUser> SystemUserSet
        {
            get
            {
                return CreateQuery<SystemUser>();
            }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Team"/> entities.
        /// </summary>
        public IQueryable<Team> TeamSet
        {
            get
            {
                return CreateQuery<Team>();
            }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="TeamMembership"/> entities.
        /// </summary>
        public IQueryable<TeamMembership> TeamMembershipSet
        {
            get
            {
                return CreateQuery<TeamMembership>();
            }
        }
    }
}