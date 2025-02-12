using Models;
using Models.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public static class CalculatorService
    {
        public static IInstallment CalculateSummary(List<IInstallment> installments)
        {
            var summary = new SimpleInstallment
            {
                Principal = Math.Round(installments.Sum(p => p.Principal), 2),
                Interest = Math.Round(installments.Sum(p => p.Interest), 2),
                Insurance = Math.Round(installments.Sum(p => p.Insurance), 2)
            };
            summary.Total = Math.Round(summary.Principal + summary.Total + summary.Interest, 2);

            return summary;
        }

        public static double CalculateCAGR(double growthFactor, double numberOfYears)
        {
            if (numberOfYears < 1) return Constants.MIN_RETURN_PERCENTAGE;
            // Compute the annual growth rate
            double annualGrowthRate = Math.Pow(growthFactor, 1.0 / numberOfYears) - 1;

            // Convert to percentage (CAGR)
            double CAGR = annualGrowthRate * 100;

            return Math.Round(CAGR, 2);
        }

        public static double CalculateGrowthFactor(double principal, double interest, double insurance)
        {
            return (interest + insurance) / principal;
        }

        public static double CalculatePeriod()
        {
            return 0;
        }
    }
}
