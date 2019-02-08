using Epi_SS_React_Demo.Models.Blocks;
using EPiServer.Web.Mvc;
using System.Web.Mvc;

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