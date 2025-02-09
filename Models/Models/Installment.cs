using Models;
using Models.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageHelper.Models
{
    public class Installment : IInstallment, ICagr
    {
        public int Id { get; set; }
        public DateOnly DueDate { get; set; }
        public double Principal { get; set; }
        public double Interest { get; set; }
        public double Insurance { get; set; }
        public double Total { get; set; }
        public double CreditBalance { get; set; }
        public static int LastIndex { private get; set;}

        public double CAGR => CalculateCAGR();

        private double CalculateCAGR()
        {
            if (LastIndex - Id < 2)
                return Constants.MIN_RETURN_PERCENTAGE;

            double InitialValue = this.Principal;
            double FinalValue = this.Interest + this.Insurance;

            // Calculate the number of periods (years, months, etc.)
            double numberOfPeriods = (LastIndex - this.Id)/12;

            // Calculate the overall growth factor
            double growthFactor = FinalValue / InitialValue;

            // Compute the annual (or per period) growth rate
            double annualGrowthRate = Math.Pow(growthFactor, 1.0 / numberOfPeriods) - 1;

            // Convert to percentage (CAGR)
            double CAGR = annualGrowthRate * 100;


            return Math.Round(CAGR, 2);
        }
    }
}
