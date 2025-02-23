using Models.Enums;
using MortgageHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Mortgage
    {
        public Mortgage(Banks bank)
        {

        }

        private List<Installment> _installments;
    }
}
