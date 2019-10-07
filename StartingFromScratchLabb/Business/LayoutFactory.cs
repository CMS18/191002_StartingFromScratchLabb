using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer;
using EPiServer.Core;
using StartingFromScratchLabb.Models.Pages;
using StartingFromScratchLabb.Models.ViewModels;

namespace StartingFromScratchLabb.Business
{
    public class LayoutFactory
    {
        private readonly IContentLoader loader;

        public LayoutFactory(IContentLoader loader)
        {
            this.loader = loader;
        }

        public RootLayoutViewModel BuildRootLayout(PageData page)
        {
            var model = new RootLayoutViewModel();

            model.Title = page.Name;
            model.Description = "???"; //TODO: Where do we get the description from?

            // Initialize these from Start Page.
            var start = loader.Get<StartPage>(ContentReference.StartPage);
            model.CompanyName = start.CompanyName;
            model.FooterText = start.FooterText;

            return model;
        }
    }
}
