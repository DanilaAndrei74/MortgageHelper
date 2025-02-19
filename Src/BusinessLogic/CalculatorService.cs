using BusinessLogic;
using Microsoft.VisualBasic;
using Models;
using Models.Interfaces;
using Models.Models;
using MortgageHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Constants = Models.Constants;

namespace BussinessLogic
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
            return termMonths - newTermMonths;
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
            return (principal + interest ) / principal;
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
            return creditBalance * Constants.Insurance.Value / 100;
        }
    }
}
