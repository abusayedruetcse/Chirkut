using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Chirkut.Fuel.Pages
{

    [PageAuthorize(typeof(KarzeHasanaRow))]
    public class KarzeHasanaController : Controller
    {
        [Route("Fuel/KarzeHasana")]
        public ActionResult Index()
        {
            return View("~/Modules/Fuel/KarzeHasana/KarzeHasanaIndex.cshtml");
        }
    }
}