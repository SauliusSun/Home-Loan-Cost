using System;

namespace HomeLoanCost.Infrastructure
{
    public static class RoudingHelper
    {
        public static decimal Round(decimal value)
        {
            return Math.Round(value, 2, MidpointRounding.AwayFromZero);
        }
    }
}