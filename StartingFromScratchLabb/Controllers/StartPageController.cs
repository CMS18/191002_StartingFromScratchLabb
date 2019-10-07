using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using StartingFromScratchLabb.Business;
using StartingFromScratchLabb.Models.Pages;
using StartingFromScratchLabb.Models.ViewModels;

namespace StartingFromScratchLabb.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        private readonly IContentLoader loader;
        private readonly LayoutFactory layoutFactory;

        public StartPageController(IContentLoader loader, LayoutFactory layoutFactory)
        {
            this.loader = loader;
            this.layoutFactory = layoutFactory;
        }

        public ActionResult Index(StartPage currentPage)
        {

            var model = new StartPageViewModel
            {
                CurrentPage = currentPage,
                Layout = layoutFactory.BuildRootLayout(currentPage)
            };

            model.ChildPages = loader.GetChildren<PageData>(currentPage.ContentLink)
                .Filter(new FilterAccess())
                .Filter(new FilterPublished())
                .Filter(new FilterTemplate())
                .ToList();
                            

            return View(model);
        }
    }
}
