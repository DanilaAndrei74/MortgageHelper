using Models.Interfaces;

namespace Models.Models
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
