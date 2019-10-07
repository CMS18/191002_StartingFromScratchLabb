using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StartingFromScratchLabb.Models.Pages;

namespace StartingFromScratchLabb.Models.ViewModels
{
    public class StandardPageViewModel: IWithRootLayout
    {
        public RootLayoutViewModel Layout { get; set; }
        public StandardPage CurrentPage { get; set; }

    }
}
