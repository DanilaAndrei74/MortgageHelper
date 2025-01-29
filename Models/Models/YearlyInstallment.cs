using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MortgageHelper.Models
{
    public class YearlyInstallment : Installment
    {
        private List<Installment> _installments { get; }
        public int Id => (_installments.FirstOrDefault()?.Id / 12 + 1) ?? 1 ;
        public DateOnly DueDate => _installments.FirstOrDefault()?.DueDate ?? DateOnly.MinValue;
        public double Principal => Math.Round(_installments.Sum(x => x.Principal),2);
        public double Interest => Math.Round(_installments.Sum(x => x.Interest), 2);
        public double Insurance => Math.Round(_installments.Sum(x => x.Insurance), 2);
        public double Total => Math.Round(_installments.Sum(x => x.Total), 2);
        public double CreditBalance => Math.Round(_installments.FirstOrDefault()?.CreditBalance ?? 0 , 2);

        public static int LastYear { private get; set; }
        public double CAGR => CalculateCAGR();

        public YearlyInstallment(List<Installment> installments) 
        {
            _installments = installments;
        }

        private double CalculateCAGR()
        {
            if (_installments.Count < 2)
                return Constants.MIN_RETURN_PERCENTAGE;

            double InitialValue = this.Principal; 
            double FinalValue = this.Interest + this.Insurance;

            if (InitialValue <= 0 || FinalValue <= 0)
                return Constants.MIN_RETURN_PERCENTAGE;

            var CAGR = (Math.Pow(FinalValue / InitialValue, 1.0 / (LastYear - this.Id)) - 1) * 100;

            return Math.Round(CAGR,2);
        }

    }
}
