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
    public class Installment : SimpleInstallment
    {
        public int Id { get; set; }
        public DateOnly DueDate { get; set; }
        public double CreditBalance { get; set; }
        public double CAGR { get; set; }
    }
}
