using Models;

namespace MortgageHelper.Models
{
    public class Installment : SimpleInstallment
    {
        public int Id { get; set; }
        public DateOnly DueDate { get; set; }
        public double CreditBalance { get; set; }
        public int RemainingMonths { get; set; }
        public double InterestRate { get; set; }
        public double CAGR { get; set; }
    }
}
