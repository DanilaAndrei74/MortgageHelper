using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MortgageHelper.Interfaces;

namespace MortgageHelper.Models
{
    public class YearlyInstallment : IInstallment
    {
        private List<Installment> _installments { get; }
        public int Id => (_installments.FirstOrDefault()?.Id / 12 + 1) ?? 1 ;
        public DateOnly DueDate => _installments.FirstOrDefault()?.DueDate ?? DateOnly.MinValue;
        public double Principal => Math.Round(_installments.Sum(x => x.Principal),2);
        public double Interest => Math.Round(_installments.Sum(x => x.Interest), 2);
        public double Insurance => Math.Round(_installments.Sum(x => x.Insurance), 2);
        public double Total => Math.Round(_installments.Sum(x => x.Total), 2);
        public double CreditBalance => Math.Round(_installments.FirstOrDefault()?.CreditBalance ?? 0 , 2);

        public YearlyInstallment(List<Installment> installments) 
        {
            _installments = installments;
        }

    }
}
