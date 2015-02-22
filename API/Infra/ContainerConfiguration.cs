using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Infra
{
    public class ContainerConfiguration
    {
        public static void Configure(StructureMap.ConfigurationExpression _)
        {
            _.Scan((x) => {
                x.Assembly("API");
                x.WithDefaultConventions();
            });
        }
    }
}