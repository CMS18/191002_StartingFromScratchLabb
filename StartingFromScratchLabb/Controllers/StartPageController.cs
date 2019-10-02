using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using StartingFromScratchLabb.Models.Pages;
using StartingFromScratchLabb.Models.ViewModels;

namespace StartingFromScratchLabb.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        private readonly IContentLoader loader;

        public StartPageController(IContentLoader loader)
        {
            this.loader = loader;
        }

        public ActionResult Index(StartPage currentPage)
        {
            var model = new StartPageViewModel
            {
                CurrentPage = currentPage
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