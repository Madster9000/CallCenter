using Ninject.Modules;
using Support.CallCenter.Pbx.PbxEventCache;
using Support.Crm.Repository.Interfaces;

namespace Support.CallCenter.Ui.Configuration.Ninject.Modules
{
    public class PbxEventCacheModule: NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<PbxEventCache>>().To<PbxEventCachesRepository>().InSingletonScope();
        }
    }
}