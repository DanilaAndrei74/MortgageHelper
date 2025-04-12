using Models.Interfaces;
using Models.Models;

namespace BusinessLogic.Interfaces
{
    public interface IMapper
    {
        List<EstimatedPerformance> MapOptimalPayments(IInstallment oldInstallment, int oldPeriod, double startingValue = 1000);
        InstallmentDifference MapToInstallmentDifference(IInstallment oldInstallment, IInstallment newInstallment, int oldMonths, int newMonths);
        List<Installment> MapToNewInstallmentPlan(double creditBalance, int remainingMonths);
        List<Installment> ReplicateInstallments(List<Installment> installments);
        List<YearlyInstallment> ToYearlyInstallment(List<Installment> installments);
    }
}