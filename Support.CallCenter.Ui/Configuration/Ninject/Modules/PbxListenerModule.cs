using Ninject.Modules;
using Support.CallCenter.Pbx.Adapters.Implementations;
using Support.CallCenter.Pbx.Adapters.Interfaces;
using Support.CallCenter.Pbx.Factories;
using Support.CallCenter.Pbx.Listeners.Implementations;
using Support.CallCenter.Pbx.Listeners.Interfaces;
using Support.CallCenter.Pbx.Services.Implementations;
using Support.CallCenter.Pbx.Services.Interfaces;

namespace Support.CallCenter.Ui.Configuration.Ninject.Modules
{
    public class PbxListenerModule: NinjectModule
    {
        public override void Load()
        {
            Bind<IPbxListener>().To<AsteriskListener>();
            Bind<ISocketAdapterFactory>().To<StubSocketAdapterFactory>();
            Bind<IPbxConfigurationService>().To<AsteriskConfigurationService>();
            Bind<IPbxMessagesParser>().To<AsteriskMessagesParser>();
        }
    }
}