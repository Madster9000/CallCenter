using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.SignalR;
using Ninject;

namespace Support.CallCenter.Ui.Configuration.Ninject
{
    internal class NinjectSignalRDependencyResolver : DefaultDependencyResolver
    {
        private readonly IKernel mKernel;

        public NinjectSignalRDependencyResolver(IKernel kernel)
        {
            mKernel = kernel;
        }

        public override object GetService(Type serviceType)
        {
            return mKernel.TryGet(serviceType) ?? base.GetService(serviceType);
        }

        public override IEnumerable<object> GetServices(Type serviceType)
        {
            return mKernel.GetAll(serviceType).Concat(base.GetServices(serviceType));
        }
    }
}