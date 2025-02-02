using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class BaseInstallment : IInstallment
    {
        public double Principal { get; set; }
        public double Interest { get; set; }
        public double Insurance { get; set; }
        public double Total { get; set; }
    }
}
