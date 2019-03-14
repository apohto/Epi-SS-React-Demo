using Epi_SS_React_Demo.Application.Interfaces;
using Epi_SS_React_Demo.Application.Services;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;

namespace Epi_SS_React_Demo.Application.Initialization
{
    [InitializableModule]
    public class ContainerConfiguration : IConfigurableModule
    {
        public void Initialize(InitializationEngine context)
        {
            
        }

        public void Uninitialize(InitializationEngine context)
        {
            
        }

        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            context.Services.AddHttpContextOrThreadScoped<ISearchService>(x => x.GetInstance<SearchService>());
        }
    }
}
