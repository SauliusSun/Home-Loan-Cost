using System.Web.Mvc;
using HomeLoanCost.Models;

namespace HomeLoanCost.Controllers
{
    public class LoansController : Controller
    {
        public ActionResult Landing()
        {
            return View();
        }

        public ActionResult Calculate(Loan loan)
        {
            return RedirectToAction("Landing");
        }
    }
}
