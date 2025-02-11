using Models;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MortgageHelper.Models
{
    public class YearlyInstallment : Installment, ICagr
    {
        private List<Installment> _installments { get; }

        public new static int LastYear { private get; set; }
        public double CAGR => CalculateCAGR();

        public YearlyInstallment(List<Installment> installments) 
        {
            _installments = installments;

            YearNumber = (_installments.FirstOrDefault()?.YearNumber / 12 + 1) ?? 1;
            DueDate = _installments.FirstOrDefault()?.DueDate ?? DateOnly.MinValue;
            Principal = Math.Round(_installments.Sum(x => x.Principal), 2);
            Interest = Math.Round(_installments.Sum(x => x.Interest), 2);
            Insurance = Math.Round(_installments.Sum(x => x.Insurance), 2);
            Total = Math.Round(_installments.Sum(x => x.Total), 2);
            CreditBalance = Math.Round(_installments.FirstOrDefault()?.CreditBalance ?? 0, 2);
        }

        private double CalculateCAGR()
        {
            if (LastYear - YearNumber < 2)
                return Constants.MIN_RETURN_PERCENTAGE;

            double InitialValue = this.Principal; 
            double FinalValue = this.Interest + this.Insurance;
            double numberOfPeriods = (LastYear - this.YearNumber) / 12;
            double growthFactor = FinalValue / InitialValue;

            // Compute the annual (or per period) growth rate
            double annualGrowthRate = Math.Pow(growthFactor, 1.0 / numberOfPeriods) - 1;

            // Convert to percentage (CAGR)
            double CAGR = annualGrowthRate * 100;

            return Math.Round(CAGR,2);
        }

    }
}
