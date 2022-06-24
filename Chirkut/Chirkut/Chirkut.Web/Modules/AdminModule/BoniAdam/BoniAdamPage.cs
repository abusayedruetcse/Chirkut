using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Chirkut.AdminModule.Pages
{

    [PageAuthorize(typeof(BoniAdamRow))]
    public class BoniAdamController : Controller
    {
        [Route("AdminModule/BoniAdam")]
        public ActionResult Index()
        {
            return View("~/Modules/AdminModule/BoniAdam/BoniAdamIndex.cshtml");
        }
    }
}