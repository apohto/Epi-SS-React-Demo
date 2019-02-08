using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace Epi_SS_React_Demo.Models.Blocks
{
    [ContentType(DisplayName = "Primary Callout Block",
        GUID = "7e5b5b83-9a2d-482c-996f-26486423ba55",
        Description = "Primary callout with header text and link")]
    public class PrimaryCalloutBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Header",
            Description = "The main callout header",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual string Header { get; set; }

        [CultureSpecific]
        [Display(Name = "Callout Button Text",
            Description = "The text on the callout button",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual string ButtonText { get; set; }

        [CultureSpecific]
        [Display(Name = "Callout Link",
            Description = "The page linked to by the callout button",
            GroupName = SystemTabNames.Content,
            Order = 300)]
        public virtual Url ButtonLink { get; set; }
    }
}