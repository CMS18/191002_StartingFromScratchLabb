using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using StartingFromScratchLabb.Models.Pages;

namespace StartingFromScratchLabb.Models.ViewModels
{
    public class StartPageViewModel
    {
        public StartPage CurrentPage { get; set; }

        public IList<PageData> ChildPages { get; set; }
    }
}