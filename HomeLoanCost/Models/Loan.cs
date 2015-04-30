using System.Collections.Generic;

namespace HomeLoanCost.Models
{
    public class Loan
    {
        public Loan()
        {
            Payments = new List<Payment>();
        }

        public decimal Credit { get; set; }

        public decimal InterestRate { get; set; }

        public int Years { get; set; }

        public List<Payment> Payments { get; set; }

        public int PaymentsCount
        {
            get
            {
                return Years*12;
            }
        }
    }
}