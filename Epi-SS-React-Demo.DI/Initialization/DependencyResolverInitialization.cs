using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;

namespace Epi_SS_React_Demo.DI.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class DependencyResolverInitialization : IConfigurableModule
    {
        public void ConfigureContainer(ServiceConfigurationContext context)
        {

            System.Web.Mvc.DependencyResolver.SetResolver(new StructureMapDependencyResolver(context.StructureMap()));

            GlobalConfiguration.Configuration.DependencyResolver = new StructureMapDependencyResolver(context.StructureMap());
            GlobalConfiguration.Configure(config =>
            {
                config.MapHttpAttributeRoutes();
            });

            ContainerConfiguration.Config(context);
        }

        public void Initialize(InitializationEngine context) { }

        public void Uninitialize(InitializationEngine context) { }

        public void Preload(string[] parameters) { }
    }
}
