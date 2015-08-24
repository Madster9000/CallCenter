using System.Web.Http;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Ninject;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using Owin;
using Support.CallCenter.Ui;
using Support.CallCenter.Ui.Configuration.Listener;
using Support.CallCenter.Ui.Configuration.Ninject;

[assembly: OwinStartup(typeof(Startup))]

namespace Support.CallCenter.Ui
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureSignalR(app);
            ConfigureWebApi(app);

            var pbxBroadcaster = NinjectContaner.Instance.Get<PbxBroadcaster>();
            pbxBroadcaster.StartListen();
        }

        private void ConfigureSignalR(IAppBuilder app)
        {
            app.MapSignalR();
        }

        private void ConfigureWebApi(IAppBuilder app)
        {
            var apiConfiguration = new HttpConfiguration();
            apiConfiguration.Routes.MapHttpRoute
                (
                    name: "DefaultApi",
                    routeTemplate: "{controller}"
                );
            apiConfiguration.MapHttpAttributeRoutes();
            apiConfiguration.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;

            app.UseNinjectMiddleware(() => NinjectContaner.Instance).UseNinjectWebApi(apiConfiguration);
        }
    }
}
