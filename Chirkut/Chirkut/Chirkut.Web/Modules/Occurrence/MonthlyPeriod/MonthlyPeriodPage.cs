using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Chirkut.Occurrence.Pages
{

    [PageAuthorize(typeof(MonthlyPeriodRow))]
    public class MonthlyPeriodController : Controller
    {
        [Route("Occurrence/MonthlyPeriod")]
        public ActionResult Index()
        {
            return View("~/Modules/Occurrence/MonthlyPeriod/MonthlyPeriodIndex.cshtml");
        }
    }
}