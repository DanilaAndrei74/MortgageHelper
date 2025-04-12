using BusinessLogic.Services;
using Models.Models;
using System.Reflection;

namespace TestHelpers.Helpers
{
    public static class Helper
    {
        public static DueDateIterator GenerateDateIterator(int months = 12)
        {
            var dates = new DueDateIterator();
            DateOnly date = DateOnly.FromDateTime(DateTime.Now);
            for (int i = 0; i < months; i++)
            {
                dates.AddDate(date);
                date.AddMonths(1);
            }
            return dates;
        }

        public static List<Installment> GetInstallments(int installmentsNumber, int startingPrincipal)
        {
            var installments = new List<Installment>();

            var creditBalance = (installmentsNumber * (installmentsNumber + 1) * startingPrincipal)/ 2;
            var date = DateTime.Now;
            
            for(int i = 1; i <= installmentsNumber; i++)
            {
                var principal = i * startingPrincipal;
                var interest = (installmentsNumber - i) * startingPrincipal;
                var insurance = 0.03 * interest;
                creditBalance = creditBalance - principal;

                installments.Add(
                    new Installment()
                    {
                        Id = i,
                        Principal = principal,
                        Interest = interest,
                        Insurance = insurance,
                        Total = principal + interest + insurance,
                        CreditBalance = creditBalance,
                        DueDate = DateOnly.FromDateTime(date),
                        RemainingMonths = installmentsNumber - i,

                    });

                date.AddMonths(1);

            }

            return installments;
        }

        public static void SetPrivateField<T>(object target, string fieldName, T value)
        {
            var field = target.GetType().GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(target, value);
        }
    }
}
