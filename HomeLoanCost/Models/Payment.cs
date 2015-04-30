namespace HomeLoanCost.Models
{
    public class Payment
    {
        public int Month { get; set; }

        public decimal Interest { get; set; }

        public decimal Repayment { get; set; }

        public decimal Credit { get; set; }
    }
}