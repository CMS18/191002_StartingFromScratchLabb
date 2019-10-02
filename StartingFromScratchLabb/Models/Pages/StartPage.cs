using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace StartingFromScratchLabb.Models.Pages
{
    [ContentType(DisplayName = "Start Page", 
        GUID = "adc6bf62-d5f5-4877-af3d-57bec78bbbf3", 
        Description = "Use this page only for each sites start page.")]
    public class StartPage : PageData
    {

    }
}