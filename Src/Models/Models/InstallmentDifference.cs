using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class InstallmentDifference
    {
        public IInstallment OldInstallment { get; set; }
        public IInstallment NewInstallment { get; set; }
        public IInstallment Difference { get; set; }
        public int OldPeriod { get; set; }
        public int NewPeriod { get; set; }
        public int PeriodDifference { get; set; }
        public double AnnualizedReturn { get; set; }
    }
}
