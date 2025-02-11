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
    public class Installment : SimpleInstallment, ICagr
    {
        public int YearNumber { get; set; }
        public DateOnly DueDate { get; set; }
        public double CreditBalance { get; set; }
        public static int LastYear { private get; set;}

        public double CAGR => CalculateCAGR();

        private double CalculateCAGR()
        {
            if (LastYear - YearNumber < 2)
                return Constants.MIN_RETURN_PERCENTAGE;

            double InitialValue = this.Principal;
            double FinalValue = this.Interest + this.Insurance;

            // Calculate the number of periods (years, months, etc.)
            double numberOfPeriods = (LastYear - this.YearNumber)/12;

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
