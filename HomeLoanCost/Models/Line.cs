using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeLoanCost.Models
{
    public class Line
    {
        public int Month { get; set; }

        public decimal Interest { get; set; }

        public decimal Credit { get; set; }
    }
}