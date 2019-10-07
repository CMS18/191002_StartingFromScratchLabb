using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace StartingFromScratchLabb.Models.Pages
{
    // NB! Name and description are in lang/ContentType.xml file

    [ContentType(GUID = "adc6bf62-d5f5-4877-af3d-57bec78bbbf3")]
    public class StartPage : PageData
    {

        /* Site Wide Settings */
        [Display(Order = 100100, GroupName = GroupNames.SiteSettings)]
        public virtual string CompanyName { get; set; }

        [Display(Order = 100110, GroupName = GroupNames.SiteSettings)]
        public virtual string FooterText { get; set; }

    }
}
