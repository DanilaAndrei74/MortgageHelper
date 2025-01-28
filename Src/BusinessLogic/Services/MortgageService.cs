using BusinessLogic.BankFactories;
using BusinessLogic.Interfaces;
using Models;
using Models.Enums;
using Models.Interfaces;
using Models.Models;
using MortgageHelper.Models;
using System.ComponentModel;

namespace BusinessLogic.Services
{
    public class MortgageService
    {
        public List<Installment> Installments { get; private set; }
        public List<YearlyInstallment> YearlyInstallments { get; private set; }
        public List<Installment> ReplicatedInstallments { get; private set; }
        public List<Installment> NewInstallments { get; private set; }
        public InstallmentDifference AdditionalPaymentSummary { get; private set; }
        public List<EstimatedPerformance> OptimalPayments { get; private set; }
        private double _additionalPayment { get; set; }

        public Banks bank { get; private set; }

        public readonly Mapper Mapper;
        public readonly InterestRatesIterator InterestRates;
        public readonly DueDateIterator DueDates;
        public readonly Insurance Insurance;
        private IInstallmentExtractor _extractor;

        public MortgageService()
        {
            InterestRates = new InterestRatesIterator();
            DueDates = new DueDateIterator();
            Insurance = new Insurance();
            Mapper = new Mapper(Insurance, DueDates, InterestRates);

            Installments = new List<Installment>();
            YearlyInstallments = new List<YearlyInstallment>();
            ReplicatedInstallments = new List<Installment>();
            NewInstallments = new List<Installment>();
            AdditionalPaymentSummary = new InstallmentDifference();
        }

        public MortgageService SetBank(Banks bank)
        {
            this.bank = bank;
            _extractor = BankFactory.GetExtractor(bank);
            return this;
        }

        public MortgageService ExtractInstallmentsFrom(string filePath)
        {
            Installments = _extractor.ExtractInstallments(filePath);
            InitializeDueDatesFromInstallments();
            return this;
        }

        public MortgageService GenerateInstallments(double creditBalance, int remainingMonths)
        {
            Installments = Mapper.MapToNewInstallmentPlan(creditBalance, remainingMonths);

            return this;
        }

        public MortgageService SetInterestRatesBasedOnInstallments()
        {
            InterestRates.SetInterestRatesBasedOnInstallments(Installments);
            return this;
        }

        private MortgageService InitializeDueDatesFromInstallments()
        {
            Installments.ForEach(installment => DueDates.AddDate(installment.DueDate));
            return this;
        }

        public MortgageService SetInterestRates(int fixedRatePeriod, double fixedRate, double variableRate)
        {
            InterestRates.SetInterestRates(fixedRatePeriod, fixedRate, variableRate);
            return this;
        }
        
        public MortgageService SetInsurance(double percentage)
        {
            Insurance.SetPercentage(Banks.CUSTOM, percentage);
            return this;
        }
        public MortgageService SetInsuranceBasedOnBank()
        {
            Insurance.SetPercentage(bank);
            return this;
        }

        public MortgageService SetAdditionalPayment(double additionalPayment)
        {
            _additionalPayment = additionalPayment;
            return this;
        }

        public MortgageService CalculateDerivates()
        {
            YearlyInstallments = Mapper.ToYearlyInstallment(Installments);
            ReplicatedInstallments = Mapper.ReplicateInstallments(Installments);

            var creditBalance = Math.Floor(Installments.First().CreditBalance + Installments.First().Principal);
           



            var oldPeriod = Installments.Count();
            var newPeriod = Calculator.GetNewMonthsAfterAdditionalPayment(
                                    creditBalance,
                                    InterestRates.FixedRate,
                                    Installments.Count(),
                                    _additionalPayment);


            NewInstallments = Mapper.MapToNewInstallmentPlan(
                creditBalance - _additionalPayment,
                newPeriod);

            var oldInstallmentSummary = Calculator.CalculateSummary(new List<IInstallment>(Installments));
            var newInstallmentSummary = Calculator.CalculateSummary(new List<IInstallment>(NewInstallments));
            AdditionalPaymentSummary = Mapper.MapToInstallmentDifference(
                oldInstallmentSummary,
                newInstallmentSummary,
                oldPeriod,
                newPeriod
                );
            
            return this;
        }

        public MortgageService SimulateOptimalPayments()
        {
            OptimalPayments =
                Mapper.MapOptimalPayments(AdditionalPaymentSummary.OldInstallment, AdditionalPaymentSummary.OldPeriod, Installments.First().Principal);

            return this;
        }
    }
}
