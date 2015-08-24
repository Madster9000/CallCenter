using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Ninject;
using Support.CallCenter.Ui.Configuration.Listener;
using Support.CallCenter.Ui.Configuration.Ninject.Modules;
using Support.CallCenter.Ui.Hubs;

namespace Support.CallCenter.Ui.Configuration.Ninject
{
    public static class NinjectContaner
    {
        private static IKernel mInstance;

        public static IKernel Instance
        {
            get { return mInstance ?? (mInstance = CreateKernel()); }
        }

        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel
                (
                new PbxListenerModule(),
                new BroadcasterModule(),
                new CrmServicesModule(),
                new PbxEventCacheModule()
                );

            
            return kernel;
        }
    }
}