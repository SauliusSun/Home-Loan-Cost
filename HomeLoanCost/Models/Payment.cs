namespace HomeLoanCost.Models
{
    public class Payment
    {
        public int Month { get; set; }

        public double Sum { get; set; }

        public double Interest { get; set; }

        public double Repayment { get; set; }

        public double Credit { get; set; }
    }
}