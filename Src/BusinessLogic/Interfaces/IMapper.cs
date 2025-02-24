using Models;
using Models.Interfaces;
using MortgageHelper.Models;

namespace BusinessLogic.Interfaces
{
    public interface IMapper
    {
        List<(double additionalPayment, double annualizedReturn)> MapOptimalPayments(IInstallment oldInstallment, int oldPeriod, double startingValue = 1000);
        InstallmentDifference MapToInstallmentDifference(IInstallment oldInstallment, IInstallment newInstallment, int oldMonths, int newMonths);
        List<Installment> MapToNewInstallmentPlan(double creditBalance, int remainingMonths);
        List<Installment> ReplicateInstallments(List<Installment> installments);
        List<Installment> ToInstallment(List<string> lines);
        List<YearlyInstallment> ToYearlyInstallment(List<Installment> installments);
    }
}