using Microsoft.VisualBasic;
using Models;
using Models.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public static class CalculatorService
    {
        public static IInstallment CalculateSummary(List<IInstallment> installments)
        {
            var summary = new SimpleInstallment
            {
                Principal = Math.Round(installments.Sum(p => p.Principal), 2),
                Interest = Math.Round(installments.Sum(p => p.Interest), 2),
                Insurance = Math.Round(installments.Sum(p => p.Insurance), 2)
            };
            summary.Total = Math.Round(summary.Principal + summary.Total + summary.Interest, 2);

            return summary;
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

        public static int CalculateMonthsSaved(double creditBalance, double annualRate, int months, double monthlyPayment, double extraPayment)
        {
            double monthlyRate = (annualRate / 100) / 12; // Convert annual rate to monthly decimal
            double newPrincipal = creditBalance - extraPayment; // Reduce the principal

            if (newPrincipal <= 0)
                return months; // Loan is fully paid off!

            // Calculate new loan duration
            double newMonths = Math.Log(monthlyPayment / (monthlyPayment - (monthlyRate * newPrincipal))) / Math.Log(1 + monthlyRate);
            int roundedNewMonths = (int)Math.Floor(newMonths);

            return months - roundedNewMonths; // Months saved
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
    }
}
