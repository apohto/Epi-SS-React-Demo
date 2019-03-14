using EPiServer.Web.Mvc;
using System.Web.Mvc;
using Epi_SS_React_Demo.Models.Models.Pages;

namespace Epi_SS_React_Demo.Controllers.Pages
{
    public class HomePageController : PageController<HomePage>
    {

        public ActionResult Index(HomePage currentContent)
        {
            return View("~/Views/Pages/HomePage/Index.cshtml", currentContent);
        }
    }
}