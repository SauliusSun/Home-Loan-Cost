using System;

namespace HomeLoanCost.Infrastructure
{
    public static class RoudingHelper
    {
        public static decimal Round(decimal value)
        {
            return Math.Round(value, 2, MidpointRounding.AwayFromZero);
        }

        public static double Round(double value)
        {
            return Round(value, 2);
        }

        public static double Round(double value, int precision)
        {
            return Math.Round(value, precision, MidpointRounding.AwayFromZero);
        }
    }
}