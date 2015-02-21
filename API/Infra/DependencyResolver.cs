using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http.Dependencies;
using StructureMap;

namespace API.Infra
{
    public class DependencyResolver : IDependencyResolver
    {
        public IDependencyScope BeginScope()
        {
            return this;
        }

        public object GetService(Type serviceType)
        {
            return ObjectFactory.Container
                .TryGetInstance(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return ObjectFactory.Container
                .GetAllInstances(serviceType)
                .Cast<object>();
        }

        public void Dispose()
        {
        }
    }
}
