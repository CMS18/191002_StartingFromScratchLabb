using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace StartingFromScratchLabb.Models
{

    [GroupDefinitions()]
    public static class GroupNames
    {
        [Display(Order = 0)]
        public const string PageHeader = SystemTabNames.PageHeader;

        [Display(Order = 10)]
        public const string Content = SystemTabNames.Content;

        [Display(Order = 20)]
        public const string Settings = SystemTabNames.Settings;
        
        [Display(Order = 100)]
        public const string SiteSettings = "SiteSettings";

        [Display(Order = 200)]
        public const string Specialized = "Specialized";
    }

}
