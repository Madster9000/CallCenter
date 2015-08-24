using System.Data.Entity;
using Ninject.Modules;
using Support.Cqrs.Commands;
using Support.Cqrs.Queries.Contact;
using Support.Crm.Model;
using Support.Crm.Model.Entities;
using Support.Crm.Repository.Implementations;
using Support.Crm.Repository.Interfaces;
using Support.Datasources.MsCrm;
using Support.Services.Implementations;
using Support.Services.Interfaces;

namespace Support.CallCenter.Ui.Configuration.Ninject.Modules
{
    public class CrmServicesModule: NinjectModule
    {
        public override void Load()
        {
            Bind<XrmServiceContext>().ToSelf().InSingletonScope();
            Bind<DbContext>().To<MsCrmDataContext>();

            Bind(typeof (IRepository<>)).To(typeof (StubRepository<>));

            Bind<IContactsService>().To<ContactsService>();
            Bind<IIncidentsService>().To<IncidentsService>();
            Bind<ISystemUsersService>().To<SystemUsersService>();
            Bind<IIncomingNotesService>().To<IncomingNotesService>();

            Bind<IContactsQueries>().To<ContactsQueries>();
            Bind<IIncomingNoteCommands>().To<IncomingNoteCommands>();

        }
    }
}