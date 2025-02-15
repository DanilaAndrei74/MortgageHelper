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

        public static double CalculateCompoundInterest(double growthFactor, double numberOfYears)
        {

            // Compute the annual growth rate
            double annualGrowthRate = Math.Pow(growthFactor, 1.0 / numberOfYears) - 1;

            // Convert to percentage
            double compoundInterestRate = annualGrowthRate * 100;

            return Math.Round(compoundInterestRate, 2);
        }

        public static double CalculateInterestGrowthFactor(double principal, double interest, double insurance)
        {
            return (principal + interest + insurance) / principal;
        }

        public static double CalculateCagrGrowthFactor(double principal, double interest, double insurance)
        {
            return (interest + insurance) / principal;
        }

        public static double CalculatePeriod()
        {
            return 0;
        }
    }
}
