using Models.Interfaces;
using MortgageHelper.Models;

namespace BusinessLogic.Services
{
    public class InterestRatesIterator
    {
        private int Count = 0; // Tracks how many times the function is called
        public int FixedRatePeriod { get; set; }
        public double FixedRate { get; set; }
        public double VariableRate { get; set; }

        public void SetInterestRates(int fixedRatePeriod, double fixedRate, double variableRate)
        {
            this.FixedRatePeriod = fixedRatePeriod;
            this.FixedRate = fixedRate;
            this.VariableRate = variableRate;
        }

        public void SetInterestRatesBasedOnInstallments(List<Installment> installments)
        {
            this.FixedRatePeriod = Calculator.DetermineFixedPaymentPeriod(new List<IInstallment>(installments));
            var fixedRateInstallments = installments.Take(this.FixedRatePeriod).ToList();
            var variableRateInstallments = installments.Skip(this.FixedRatePeriod).ToList();
            this.FixedRate = fixedRateInstallments[fixedRateInstallments.Count() / 2].InterestRate;
            if (variableRateInstallments.Count() > 0) this.VariableRate = variableRateInstallments[variableRateInstallments.Count() / 2].InterestRate;
        }

        public double GetNext()
        {

            if (Count < FixedRatePeriod)
            {
                Count++;
                return FixedRate;
            }
            return VariableRate;
        }

        public void Reset()
        {
            Count = 0;
        }
    }

}
