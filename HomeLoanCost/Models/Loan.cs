using HomeLoanCost.Infrastructure;
using System;
using System.Collections.Generic;

namespace HomeLoanCost.Models
{
    public class Loan
    {
        public Loan()
        {
            Payments = new List<Payment>();
        }

        public double Credit { get; set; }

        public double InterestRate { get; set; }

        public double Years { get; set; }

        public const double PaymentsCountPerYear = 12;

        public double PaymentsCount => Years * PaymentsCountPerYear;

        public List<Payment> Payments { get; set; }



        /// <summary>
        /// Calculation algorithm described in http://lt.wikipedia.org/wiki/Anuitetas.
        /// </summary>
        public double GetAnnuityPaymentSum()
        {
            double monthlyInterestRateValue = GetPercentValue(InterestRate / PaymentsCountPerYear);

            double multiplier = Math.Pow(1D + monthlyInterestRateValue, 1D / PaymentsCountPerYear) - 1D;

            double divisor = Math.Pow(1D + monthlyInterestRateValue, Years);

            double annuityRate = (multiplier * divisor) / (divisor - 1D);

            double annuitySum = RoudingHelper.Round(annuityRate * Credit);

            return annuitySum;
        }

        public double GetLinearPaymentSum()
        {
            return 0;
        }

        public double GetPercentValue(double percent)
        {
            return RoudingHelper.Round(percent / 100D, 5);
        }
    }
}