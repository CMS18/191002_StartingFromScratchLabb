using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace StartingFromScratchLabb.Models.Pages
{

    // NB! Name and description are in lang/ContentType.xml file

    [ContentType(GUID = "f75ec1ea-37f9-4d5d-9f0d-e70df3ce32b4")]
    public class StandardPage : PageData
    {


        [Display(Order = 10100, GroupName = GroupNames.Content)]
        [CultureSpecific]
        public virtual XhtmlString MainBody { get; set; }

    }
}
