using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Epi_SS_React_Demo.Models.Models.Pages
{
    [ContentType(DisplayName = "Home Page",
        GUID = "07e360f9-fd8b-4fd8-a364-605ba78e0cbe",
        Description = "Site Home Page")]
    [ImageUrl("~/assets/images/home-icon.png")]
    public class HomePage : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Content",
            Description = "The content will be shown in the main content area of the page.",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual ContentArea MainContent { get; set; }
    }
}