using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using StartingFromScratchLabb.Models.Pages;
using StartingFromScratchLabb.Models.ViewModels;

namespace StartingFromScratchLabb.Controllers
{
    public class StandardPageController : PageController<StandardPage>
    {
        public ActionResult Index(StandardPage currentPage)
        {
            var model = new StandardPageViewModel
            {
                CurrentPage = currentPage
            };

            return View(model);
        }
    }
}
