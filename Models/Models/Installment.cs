using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MortgageHelper.Interfaces;

namespace MortgageHelper.Models
{
    public class Installment : IInstallment
    {
        public int Id { get; set; }
        public DateOnly DueDate { get; set; }
        public double Principal { get; set; }
        public double Interest { get; set; }
        public double Insurance { get; set; }
        public double Total { get; set; }
        public double CreditBalance { get; set; }
    }
}
