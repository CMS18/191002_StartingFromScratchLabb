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
    public class StartPageController : PageController<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            var model = new StartPageViewModel
            {
                CurrentPage = currentPage
            };

            return View(model);
        }
    }
}