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
    public class YearlyInstallment : Installment
    {
        private List<Installment> _installments { get; }

        public YearlyInstallment(List<Installment> installments) 
        {
            _installments = installments;

            Id = (_installments.FirstOrDefault()?.Id / 12 + 1) ?? 1;
            DueDate = _installments.FirstOrDefault()?.DueDate ?? DateOnly.MinValue;
            Principal = Math.Round(_installments.Sum(x => x.Principal), 2);
            Interest = Math.Round(_installments.Sum(x => x.Interest), 2);
            Insurance = Math.Round(_installments.Sum(x => x.Insurance), 2);
            Total = Math.Round(_installments.Sum(x => x.Total), 2);
            CreditBalance = Math.Round(_installments.FirstOrDefault()?.CreditBalance ?? 0, 2);
        }
    }
}
