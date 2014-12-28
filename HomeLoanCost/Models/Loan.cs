using System.Collections.Generic;

namespace HomeLoanCost.Models
{
    public class Loan
    {
        public Loan()
        {
            Lines = new List<Line>();
        }

        public decimal Credit { get; set; }

        public decimal InterestRate { get; set; }

        public int Years { get; set; }

        public List<Line> Lines { get; set; }
    }
}