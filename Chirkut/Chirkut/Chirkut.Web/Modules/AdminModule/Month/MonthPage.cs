using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Chirkut.AdminModule.Pages
{

    [PageAuthorize(typeof(MonthRow))]
    public class MonthController : Controller
    {
        [Route("AdminModule/Month")]
        public ActionResult Index()
        {
            return View("~/Modules/AdminModule/Month/MonthIndex.cshtml");
        }
    }
}