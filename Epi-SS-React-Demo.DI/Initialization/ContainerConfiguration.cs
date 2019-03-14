using Epi_SS_React_Demo.Application.Interfaces;
using Epi_SS_React_Demo.Application.Services;
using EPiServer.ServiceLocation;

namespace Epi_SS_React_Demo.DI.Initialization
{
    public class ContainerConfiguration
    {
        public static void Config(ServiceConfigurationContext context)
        {
            RegisterAspNetTypes(context);
            RegisterDomainServices(context);
        }

        private static void RegisterAspNetTypes(ServiceConfigurationContext context)
        {
            System.Web.Mvc.DependencyResolver.SetResolver(new StructureMapDependencyResolver(context.StructureMap()));
        }

        private static void RegisterDomainServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpContextOrThreadScoped<ISearchService>(x => x.GetInstance<SearchService>());
        }
    }
}
