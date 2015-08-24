using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Ninject.Modules;
using Support.CallCenter.Ui.Configuration.Listener;
using Support.CallCenter.Ui.Hubs;

namespace Support.CallCenter.Ui.Configuration.Ninject.Modules
{
    public class BroadcasterModule: NinjectModule
    {
        public override void Load()
        {
            Bind<IHubConnectionContext<dynamic>>()
                .ToMethod(ctx => GlobalHost.ConnectionManager.GetHubContext<AsteriskHub>().Clients);
            Bind<PbxBroadcaster>().ToSelf().InSingletonScope();
        }
    }
}