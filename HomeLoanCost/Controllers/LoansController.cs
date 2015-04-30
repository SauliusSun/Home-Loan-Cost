using HomeLoanCost.Infrastructure;
using HomeLoanCost.Models;
using System.Web.Mvc;

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
            decimal credit = loan.Credit;

            for (int month = 1; month <= loan.PaymentsCount; month++)
            {
                var line = new Payment();
                line.Month = month;
                line.Interest = RoudingHelper.Round(((loan.InterestRate / 12) / 100) * credit);
                line.Repayment = 100;
                line.Credit = credit = RoudingHelper.Round(credit - line.Repayment);
                loan.Payments.Add(line);
            }

            return View("Landing", loan);
        }
    }
}
