using System.Web.Mvc;
using Epi_SS_React_Demo.Models.Models.Pages;
using EPiServer.Web.Mvc;

namespace Epi_SS_React_Demo.Controllers.Pages
{
    public class SearchPageController : PageController<SearchPage>
    {
        public ActionResult Index(SearchPage currentContent)
        {

            return View("~/Views/Pages/SearchPage/Index.cshtml", currentContent);
        }
    }
}