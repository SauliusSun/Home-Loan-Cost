using System.Linq;
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
            double credit = loan.Credit;

            double sum = loan.GetAnnuityPaymentSum();
            
            for (int month = 1; month <= loan.PaymentsCount; month++)
            {
                var line = new Payment();
                
                line.Month = month;
                line.Sum = sum;
                line.Interest = RoudingHelper.Round(((loan.InterestRate / 12) / 100) * credit);
                line.Repayment = RoudingHelper.Round(line.Sum - line.Interest);
                double repayment = loan.Payments.Count == 0 ? line.Repayment : loan.Payments.Last().Repayment;
                credit = RoudingHelper.Round(credit - repayment);
                line.Credit = month == 1 ? loan.Credit : RoudingHelper.Round(loan.Payments.Last().Credit - loan.Payments.Last().Repayment);
                loan.Payments.Add(line);
            }

            return View("Landing", loan);
        }
    }
}
