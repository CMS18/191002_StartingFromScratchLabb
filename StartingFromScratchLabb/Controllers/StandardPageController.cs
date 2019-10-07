using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using StartingFromScratchLabb.Business;
using StartingFromScratchLabb.Models.Pages;
using StartingFromScratchLabb.Models.ViewModels;

namespace StartingFromScratchLabb.Controllers
{
    public class StandardPageController : PageController<StandardPage>
    {
        private readonly LayoutFactory layoutFactory;

        public StandardPageController(LayoutFactory layoutFactory)
        {
            this.layoutFactory = layoutFactory;
        }

        public ActionResult Index(StandardPage currentPage)
        {
            var model = new StandardPageViewModel
            {
                CurrentPage = currentPage,
                Layout = layoutFactory.BuildRootLayout(currentPage)
            };

            return View(model);
        }
    }
}
