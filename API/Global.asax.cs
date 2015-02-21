using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using API.Infra;
using AutoMapper;
using StructureMap;

namespace API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ObjectFactory.Initialize();
            ObjectFactory.Configure(ContainerConfiguration.Configure);
            Mapper.Initialize(MapperConfiguration.Configure);

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
