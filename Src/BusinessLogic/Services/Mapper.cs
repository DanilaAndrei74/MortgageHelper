using BusinessLogic.Helpers;
using BusinessLogic.Interfaces;
using Models;
using Models.Interfaces;
using Models.Models;
using MortgageHelper;
using MortgageHelper.Models;
using System.Globalization;

namespace BusinessLogic.Services
{
    public class Mapper : IMapper
    {
        private readonly Insurance _insurance;
        private readonly DueDateIterator _dates;
        private readonly InterestRatesIterator _interestRates;
        public Mapper(Insurance insurance, DueDateIterator dates, InterestRatesIterator rates)
        {
            _insurance = insurance;
            _dates = dates;
            _interestRates = rates;
        }

        public InstallmentDifference MapToInstallmentDifference(IInstallment oldInstallment, IInstallment newInstallment, int oldMonths, int newMonths)
        {
            var installmentDifference = new InstallmentDifference();

            installmentDifference.OldInstallment = oldInstallment;
            installmentDifference.NewInstallment = newInstallment;
            installmentDifference.OldPeriod = oldMonths;
            installmentDifference.NewPeriod = newMonths;
            installmentDifference.PeriodDifference = oldMonths - newMonths;

            installmentDifference.Difference = new SimpleInstallment()
            {
                Principal = oldInstallment.Principal - newInstallment.Principal,
                Interest = oldInstallment.Interest - newInstallment.Interest,
                Insurance = oldInstallment.Insurance - newInstallment.Insurance,
                Total = oldInstallment.Total - newInstallment.Total,
            };
            installmentDifference.Difference.RoundDoubleProperties();

            var growthFactor = Calculator.CalculateInterestGrowthFactor(
                installmentDifference.Difference.Principal,
                installmentDifference.Difference.Interest,
                installmentDifference.Difference.Insurance);

            installmentDifference.AnnualizedReturn = Calculator.CalculateCompoundInterest(growthFactor, oldMonths / 12.00);


            return installmentDifference;

        }
        public List<Installment> MapToNewInstallmentPlan(double creditBalance, int remainingMonths)
        {
            var installments = new List<Installment>();
            _dates.Reset();
            _interestRates.Reset();

            for (int i = 0; i < remainingMonths; i++)
            {
                var installment = new Installment();
                var interestRate = _interestRates.GetNext();

                installment.RemainingMonths = remainingMonths - i;
                installment.Id = i + 1;
                installment.DueDate = _dates.Next() ?? new DateOnly();
                installment.Total = Calculator.CalculatePayment(creditBalance, interestRate, installment.RemainingMonths);
                installment.Interest = Calculator.CalculateMonthlyInterestPaid(creditBalance, interestRate);
                installment.Principal = installment.Total - installment.Interest;
                installment.CreditBalance = Math.Max(0, creditBalance - installment.Principal);
                installment.Insurance = Calculator.CalculateInsurance(installment.CreditBalance, _insurance.Percentage);
                installment.Total += installment.Insurance;
                installment.InterestRate = interestRate;

                creditBalance -= installment.Principal;

                installment.RoundDoubleProperties();
                installments.Add(installment);
            }
            return installments;
        }

        public List<EstimatedPerformance> MapOptimalPayments(IInstallment oldInstallment, int oldPeriod, double startingValue = 1000)
        {
            var incrementValue = 100;
            startingValue = Math.Floor(startingValue - startingValue % 100);

            var result = new List<EstimatedPerformance>();
            double best = 0;

            for (double additionalPayment = startingValue; additionalPayment < oldInstallment.Principal; additionalPayment += incrementValue)
            {
                var newMonths = Calculator.GetNewMonthsAfterAdditionalPayment(
                                        oldInstallment.Principal,
                                        _interestRates.FixedRate,
                                        oldPeriod,
                                        additionalPayment);

                var newInstallments = MapToNewInstallmentPlan(
                    oldInstallment.Principal - additionalPayment,
                    newMonths);

                var newSummary = Calculator.CalculateSummary(new List<IInstallment>(newInstallments));

                var difference = MapToInstallmentDifference(oldInstallment, newSummary, oldPeriod, newMonths);

                result.Add(new EstimatedPerformance { Principal = additionalPayment, EstimatedReturn = difference.AnnualizedReturn });

                if (difference.AnnualizedReturn > best)
                {
                    best = difference.AnnualizedReturn;
                }
            }
            return result.OrderByDescending(x => x.EstimatedReturn).ToList();
        }

        public List<Installment> ReplicateInstallments(List<Installment> installments)
        {
            var result = new List<Installment>();
            var balance = Math.Floor(installments.First().CreditBalance + installments.First().Principal);

            foreach (var installment in installments)
            {
                var newInstallment = new Installment();
                var interestRate = _interestRates.GetNext();

                newInstallment.Id = installment.Id;

                newInstallment.DueDate = installment.DueDate;
                newInstallment.RemainingMonths = installment.RemainingMonths;

                //newInstallment.Total = installment.Total - installment.Insurance;
                newInstallment.Total = Calculator.CalculatePayment(balance, interestRate, installment.RemainingMonths);
                newInstallment.Interest = Calculator.CalculateMonthlyInterestPaid(balance, interestRate);
                newInstallment.Principal = newInstallment.Total - newInstallment.Interest;

                balance -= newInstallment.Principal;
                newInstallment.CreditBalance = balance;
                newInstallment.InterestRate = interestRate;


                newInstallment.Insurance = newInstallment.CreditBalance * _insurance.Percentage / 100;
                newInstallment.Total += newInstallment.Insurance;


                newInstallment.RoundDoubleProperties();

                result.Add(newInstallment);
            }

            var differences = installments.Zip(result, (oldPay, newPay) => new
            {
                PrincipalDiff = newPay.Principal - oldPay.Principal,
                InterestDiff = newPay.Interest - oldPay.Interest,
                InsuranceDiff = newPay.Insurance - oldPay.Insurance,
                TotalDiff = newPay.Total - oldPay.Total,
                CreditBalanceDiff = newPay.CreditBalance - oldPay.CreditBalance
            });
            differences.RoundDoubleProperties();


            return result;
        }

        public List<YearlyInstallment> ToYearlyInstallment(List<Installment> installments)
        {
            var sortedInstallments = installments.OrderBy(x => x.Id).ToList();
            var yearlyInstallments = new List<YearlyInstallment>();
            var lastMonth = installments.Count;

            for (int i = 0; i < installments.Count; i += 12)
            {
                var batch = installments.Skip(i).Take(12).ToList(); // Take the next 12 installments
                var yearlyInstallment = new YearlyInstallment(batch);

                var growthFactor = Calculator.CalculateCagrGrowthFactor(yearlyInstallment.Principal, yearlyInstallment.Interest, yearlyInstallment.Insurance);
                var interestRateGrowthFactor = Calculator.CalculateInterestGrowthFactor(yearlyInstallment.Principal, yearlyInstallment.Interest, yearlyInstallment.Insurance);
                var remainingYears = Math.Max(0, lastMonth / 12.0 - yearlyInstallment.Id + 1);
                yearlyInstallment.RemainingMonths = lastMonth - yearlyInstallment.Id * 12 + 1; ;
                yearlyInstallment.CAGR = Calculator.CalculateCompoundInterest(growthFactor, remainingYears);
                yearlyInstallment.InterestRate = Calculator.CalculateCompoundInterest(interestRateGrowthFactor, remainingYears);

                yearlyInstallments.Add(yearlyInstallment); // Create a new YearlyInstallment with the batch
            }

            return yearlyInstallments;
        }
    }

}
