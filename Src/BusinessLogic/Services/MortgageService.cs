using BusinessLogic.BankFactories;
using BusinessLogic.Interfaces;
using Models;
using Models.Enums;
using Models.Interfaces;
using MortgageHelper.Models;

namespace BusinessLogic.Services
{
    public class MortgageService
    {
        public List<Installment> Installments { get; private set; }
        public List<YearlyInstallment> YearlyInstallments { get; private set; }
        public List<Installment> ReplicatedInstallments { get; private set; }
        public List<Installment> NewInstallments { get; private set; }
        public InstallmentDifference AdditionalPaymentSummary { get; private set; }
        public List<(double additionalPayment, double annualizedReturn)> OptimalPayments { get; private set; }
        private double _additionalPayment { get; set; }

        public Banks bank { get; private set; }

        private readonly Mapper _mapper;
        private readonly InterestRatesIterator _interestRates;
        private readonly DueDateIterator _dates;
        private readonly Insurance _insurance;
        private IInstallmentExtractor _extractor;

        public MortgageService()
        {
            _interestRates = new InterestRatesIterator();
            _dates = new DueDateIterator();
            _insurance = new Insurance();
            _mapper = new Mapper(_insurance, _dates, _interestRates);

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
            var installmentsLines = _extractor.ExtractInstallments(filePath);
            Installments = _mapper.ToInstallment(installmentsLines);

            return this;
        }

        public MortgageService AssignInterestRates()
        {
            _interestRates.SetInterestRatesBasedOnInstallments(Installments);
            return this;
        }
        public MortgageService SetInsuranceBasedOnBank()
        {
            _insurance.SetPercentage(bank);
            return this;
        }

        public MortgageService SetAdditionalPayment(double additionalPayment)
        {
            _additionalPayment = additionalPayment;
            return this;
        }

        public MortgageService CalculateInstallments()
        {
            YearlyInstallments = _mapper.ToYearlyInstallment(Installments);
            ReplicatedInstallments = _mapper.ReplicateInstallments(Installments);

            var creditBalance = Math.Floor(Installments.First().CreditBalance + Installments.First().Principal);
           



            AdditionalPaymentSummary.OldPeriod = Installments.Count();
            AdditionalPaymentSummary.NewPeriod = Calculator.GetNewMonthsAfterAdditionalPayment(
                                    creditBalance,
                                    _interestRates.FixedRate,
                                    Installments.Count(),
                                    _additionalPayment);


            NewInstallments = _mapper.MapToNewInstallmentPlan(
                creditBalance - _additionalPayment,
                AdditionalPaymentSummary.NewPeriod);

            AdditionalPaymentSummary.OldInstallment = Calculator.CalculateSummary(new List<IInstallment>(Installments));
            AdditionalPaymentSummary.NewInstallment = Calculator.CalculateSummary(new List<IInstallment>(NewInstallments));

            return this;
        }

        public MortgageService SimulateOptimalPayments()
        {
            OptimalPayments =
                _mapper.MapOptimalPayments(AdditionalPaymentSummary.OldInstallment, AdditionalPaymentSummary.OldPeriod, Installments.First().Principal);

            return this;
        }
    }
}
