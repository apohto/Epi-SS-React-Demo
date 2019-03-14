using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Epi_SS_React_Demo.Models.Models.Pages
{
    [ContentType(DisplayName = "Search Page",
        GUID = "a50304bc-3a6d-4147-909d-36953a968c82",
        Description = "Site Search Page")]
    [ImageUrl("~/assets/images/search-icon.png")]
    public class SearchPage : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Header",
            Description = "The main header for the page.",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual string Header { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Search Button Text",
            Description = "The text displayed on the search button.",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual string SearchButtonText { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Search Box Placeholder Text",
            Description = "The placeholder text displayed in the search box.",
            GroupName = SystemTabNames.Content,
            Order = 300)]
        public virtual string SearchBoxPlaceholder { get; set; }
    }
}