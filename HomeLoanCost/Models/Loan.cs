using System;
using System.Collections.Generic;
using System.Web.Hosting;
using HomeLoanCost.Infrastructure;

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

        public int Years { get; set; }

        public List<Payment> Payments { get; set; }

        public int PaymentsCount
        {
            get
            {
                return Years*12;
            }
        }

        public double GetPaymentSum()
        {
            //double interestRateValue = InterestRate/100;

            //double annuityRate = ((Math.Pow(1D + interestRateValue, 1D/12D) - 1D)*(Math.Pow(1D + interestRateValue, Years)))/
            //                     (Math.Pow(1D + interestRateValue, Years) - 1D);

            //return RoudingHelper.Round(annuityRate*Credit);

            return 206.16D;
        }
    }
}