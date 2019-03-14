using System.Web.Http;
using System.Web.Routing;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;

namespace Epi_SS_React_Demo.Application.Initialization
{
    [InitializableModule]
    public class RouterInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            RouteTable.Routes.MapHttpRoute(
                "GetResults",
                "api/search/getResults",
                new { controller = "SearchApi", action = "GetResults" });
        }

        public void Uninitialize(InitializationEngine context)
        {
            
        }
    }
}
