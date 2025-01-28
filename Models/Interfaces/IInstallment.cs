using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageHelper.Interfaces
{
    public interface IInstallment
    {
        public int Id { get; }
        public DateOnly DueDate { get; }
        public double Principal { get; }
        public double Interest { get; }
        //public double AdministrationFee { get; set; }
        public double Insurance { get; }
        public double Total { get; }
        public double CreditBalance { get;}
        //public string AdjustedInterest { get; set; }
    }
}
