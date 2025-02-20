using Microsoft.VisualBasic;
using Models;
using Models.Interfaces;
using MortgageHelper;
using Constants = Models.Constants;

namespace BusinessLogic
{
    public static class CalculatorService
    {
        public static IInstallment CalculateSummary(List<IInstallment> installments)
        {
            var summary = new SimpleInstallment
            {
                Principal = installments.Sum(p => p.Principal),
                Interest = installments.Sum(p => p.Interest),
                Insurance = installments.Sum(p => p.Insurance)
            };
            summary.Total = summary.Principal + summary.Interest + summary.Insurance;

            summary.RoundDoubleProperties();
            return summary;
        }

        public static int DetermineFixedPaymentPeriod(List<IInstallment> installments)
        {
            if (installments.Count < 3) return installments.Count;

            double fixedPayment = installments[1].Total; // Use second payment as reference
            const double tolerance = 20; // Allow small rounding differences

            for (int i = 2; i < installments.Count; i++) // Start from the third payment
            {
                if (Math.Abs(installments[i].Total - fixedPayment) > tolerance)
                    return i; // Return the number of months before first change
            }

            return installments.Count; // If no change, assume entire period is fixed
        }

        public static List<(double additionalPayment, double annualizedReturn)> CalculateOptimalPayment(IInstallment oldInstallment, int oldPeriod)
        {
            var incrementValue = 100;
            var startingValue = 2000;

            var result = new List<(double additionalPayment, double annualizedReturn)>();
            double best = 0;

            for (int additionalPayment = startingValue; additionalPayment < oldInstallment.Principal; additionalPayment += incrementValue)
            {
                var newMonths = CalculatorService.GetNewMonthsAfterExtraordinaryPayment(
                                        oldInstallment.Principal,
                                        InterestRates.fixedRate,
                                        oldPeriod,
                                        additionalPayment);

                var newInstallments = Mapper.CalculateInstallmentPlan(
                    oldInstallment.Principal - additionalPayment,
                    newMonths);

                var newSummary = CalculatorService.CalculateSummary(new List<IInstallment>(newInstallments));

                var difference = Mapper.MapToInstallmentDifference(_oldSummary, newSummary, _oldMonths, newMonths);

                if (difference.AnnualizedReturn > best)
                {
                    result.Add(new(additionalPayment, difference.AnnualizedReturn));
                    best = difference.AnnualizedReturn;
                }
            }
            var a = result.OrderByDescending(x => x.annualizedReturn).ToList();
            return a;
        }

        public static double CalculateCompoundInterest(double growthFactor, double numberOfYears)
        {

            // Compute the annual growth rate
            double annualGrowthRate = Math.Pow(growthFactor, 1.0 / numberOfYears) - 1;

            // Convert to percentage
            double compoundInterestRate = annualGrowthRate * 100;

            return Math.Round(compoundInterestRate, 3);
        }

        public static double CalculatePayment(double creditBalance, double annualRate, int months) 
        {
            var payment = Financial.Pmt((annualRate / 100) / 12, months, -creditBalance);
            return payment;
        }

        public static double CalculateMonthlyInterestPaid(double remainingPrincipal, double annualRate)
        {
            return remainingPrincipal * (annualRate / 12 / 100);
        }

        public static int GetNewMonthsAfterExtraordinaryPayment(double principal, double annualRate, int termMonths, double extraPayment)
        {
            if (extraPayment == 0) return termMonths;

            double monthlyRate = (annualRate / 100) / 12;

            // Calculate original monthly payment
            double monthlyPayment = principal * (monthlyRate * Math.Pow(1 + monthlyRate, termMonths)) /
                                    (Math.Pow(1 + monthlyRate, termMonths) - 1);

            // New principal after extra payment
            double newPrincipal = principal - extraPayment;

            // Calculate the new loan term
            int newTermMonths = (int)Math.Ceiling(
                Math.Log(monthlyPayment / (monthlyPayment - monthlyRate * newPrincipal)) / Math.Log(1 + monthlyRate)
            );

            // Return new term months
            return newTermMonths;
        }


        public static double CalculateMortgageRate(double total, double creditBalance, double numberOfMonths)
        {
            if (numberOfMonths == 0) return 0;
            double monthlyRate = Financial.Rate(numberOfMonths, -total, creditBalance, Guess: 0.07);

            // Convert to annual interest rate
            double annualRate = monthlyRate * 12 * 100;

            return Math.Round(annualRate, 2);
        }


        public static double CalculateInterestGrowthFactor(double principal, double interest, double insurance)
        {
            return (principal + interest + insurance) / principal;
        }

        public static double CalculateCagrGrowthFactor(double principal, double interest, double insurance)
        {
            return (interest + insurance) / principal;
        }

        public static double CalculatePeriod()
        {
            return 0;
        }

        internal static double CalculateInsurance(double creditBalance)
        {
            return Math.Max(0 ,creditBalance * Insurance.Percentage / 100);
        }
    }
}
