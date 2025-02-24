using Models.Interfaces;

namespace Models
{
    public class SimpleInstallment : IInstallment
    {
        public double Principal { get; set; }
        public double Interest { get; set; }
        public double Insurance { get; set; }
        public double Total { get; set; }
    }
}
