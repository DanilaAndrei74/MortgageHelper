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
    public class YearlyInstallment : IInstallment, ICagr
    {
        private List<Installment> _installments { get; }
        public int Id => (_installments.FirstOrDefault()?.Id / 12 + 1) ?? 1 ;
        public new DateOnly DueDate => _installments.FirstOrDefault()?.DueDate ?? DateOnly.MinValue;
        public double Principal { get => Math.Round(_installments.Sum(x => x.Principal), 2); }
        public double Interest { get => Math.Round(_installments.Sum(x => x.Interest), 2); }
        public double Insurance { get => Math.Round(_installments.Sum(x => x.Insurance), 2); }
        public double Total { get => Math.Round(_installments.Sum(x => x.Total), 2); }
        public new double CreditBalance => Math.Round(_installments.FirstOrDefault()?.CreditBalance ?? 0 , 2);

        public static int LastIndex { private get; set; }
        public double CAGR => CalculateCAGR();

        public YearlyInstallment(List<Installment> installments) 
        {
            _installments = installments;
        }

        private double CalculateCAGR()
        {
            if (LastIndex - Id < 2)
                return Constants.MIN_RETURN_PERCENTAGE;

            double InitialValue = this.Principal; 
            double FinalValue = this.Interest + this.Insurance;
            double numberOfPeriods = (LastIndex - this.Id) / 12;
            double growthFactor = FinalValue / InitialValue;

            // Compute the annual (or per period) growth rate
            double annualGrowthRate = Math.Pow(growthFactor, 1.0 / numberOfPeriods) - 1;

            // Convert to percentage (CAGR)
            double CAGR = annualGrowthRate * 100;

            return Math.Round(CAGR,2);
        }

    }
}
