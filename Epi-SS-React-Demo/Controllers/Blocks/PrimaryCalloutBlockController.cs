using EPiServer.Web.Mvc;
using System.Web.Mvc;
using Epi_SS_React_Demo.Models.Models.Blocks;

namespace Epi_SS_React_Demo.Controllers.Blocks
{
    public class PrimaryCalloutBlockController : BlockController<PrimaryCalloutBlock>
    {
        public override ActionResult Index(PrimaryCalloutBlock currentContent)
        {
            return PartialView("~/Views/Blocks/PrimaryCalloutBlock.cshtml", currentContent);
        }
    }
}