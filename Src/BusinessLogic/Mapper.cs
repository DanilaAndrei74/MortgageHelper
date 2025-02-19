using BusinessLogic;
using BussinessLogic;
using iText.Kernel.Geom;
using Models.Enums;
using Models.Interfaces;
using MortgageHelper.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageHelper
{
    public static class Mapper
    {
        public static List<Installment> CalculateInstallmentPlan(double creditBalance, int remainingMonths)
        {
            var installments = new List<Installment>();
            var interest = new NumberGenerator();

            for (int i = 0; i < remainingMonths; i++) 
            {
                var installment = new Installment();
                var interestRate = interest.GetNext();

                installment.RemainingMonths = remainingMonths - i;
                installment.Id = i + 1;
                installment.Total = CalculatorService.CalculatePayment(creditBalance, interestRate, installment.RemainingMonths);
                installment.Interest = CalculatorService.CalculateMonthlyInterestPaid(creditBalance, interestRate);
                installment.Principal = installment.Total - installment.Interest;
                installment.Total += installment.Insurance;
                installment.CreditBalance = creditBalance - installment.Principal;
                installment.Insurance = installment.CreditBalance * 0.026 / 100;
                
                creditBalance -= installment.Principal;

                installment.RoundDoubleProperties();
                installments.Add(installment);
            }
            return installments;
        }

        public static List<Installment> ReplicateInstallments(List<Installment> installments)
        {
            var result = new List<Installment>();
            var balance = installments.First().CreditBalance + installments.First().Principal;
            var interest = new NumberGenerator();
            foreach (var installment in installments)
            {
                var newInstallment = new Installment();
                var interestRate = interest.GetNext();

                newInstallment.Id = installment.Id;

                newInstallment.DueDate = installment.DueDate;
                newInstallment.RemainingMonths = installment.RemainingMonths;

                newInstallment.Total = CalculatorService.CalculatePayment(balance, interestRate, installment.RemainingMonths);
                newInstallment.Interest = CalculatorService.CalculateMonthlyInterestPaid(balance, interestRate);
                newInstallment.Principal = newInstallment.Total - newInstallment.Interest;

                balance -= newInstallment.Principal;
                newInstallment.CreditBalance = balance;
                newInstallment.InterestRate = CalculatorService.CalculateMortgageRate(newInstallment.Total, balance, newInstallment.RemainingMonths);


                if (installment.Insurance != 0)
                {
                    newInstallment.Insurance = newInstallment.CreditBalance * 0.026 / 100;
                    newInstallment.Total += newInstallment.Insurance;
                }
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

            return result;
        }

        public static List<Installment> ToInstallment(List<string> lines)
        {
            var installments = new List<Installment>();
            var lastMonth = lines.Count;
            foreach (var line in lines)
            {
                // Split the line into columns
                string[] columns = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var installment = new Installment()
                {
                    Id = int.Parse(columns[(int)TableHeader.Number]),
                    DueDate = DateOnly.ParseExact(columns[(int)TableHeader.DueDate], "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Principal = double.Parse(columns[(int)TableHeader.Principal].Replace(",", ""), CultureInfo.InvariantCulture),
                    Interest = double.Parse(columns[(int)TableHeader.Interest].Replace(",", ""), CultureInfo.InvariantCulture),
                    //AdministrationFee = double.Parse(columns[(int)TableHeader.AdministrationFee].Replace(",", ""), CultureInfo.InvariantCulture),
                    Insurance = double.Parse(columns[(int)TableHeader.InsuranceCosts].Replace(",", ""), CultureInfo.InvariantCulture),
                    Total = double.Parse(columns[(int)TableHeader.Total].Replace(",", ""), CultureInfo.InvariantCulture),
                    CreditBalance = double.Parse(columns[(int)TableHeader.CreditBalance].Replace(",", ""), CultureInfo.InvariantCulture),
                    //AdjustedInterest = columns.Length > (int)TableHeader.AdjustedInterest ? columns[(int)TableHeader.AdjustedInterest] : string.Empty

                };

                var cagrGrowthFactor = CalculatorService.CalculateCagrGrowthFactor(installment.Principal, installment.Interest, installment.Insurance);
                var interestRateGrowthFactor = CalculatorService.CalculateInterestGrowthFactor(installment.Principal, installment.Interest, installment.Insurance);

                installment.RemainingMonths = lastMonth - installment.Id + 1;
                installment.CAGR = CalculatorService.CalculateCompoundInterest(cagrGrowthFactor, installment.RemainingMonths / 12);
                installment.InterestRate = CalculatorService.CalculateMortgageRate(
                    installment.Total - installment.Insurance,
                    installment.CreditBalance + installment.Principal,
                    installment.RemainingMonths);

                installments.Add(installment);
            }


            return installments;
        }

        public static List<YearlyInstallment> ToYearlyInstallment(List<Installment> installments)
        {
            var sortedInstallments = installments.OrderBy(x => x.Id).ToList();  
            var yearlyInstallments = new List<YearlyInstallment>();
            var lastMonth = installments.Count;

            for (int i = 0; i < installments.Count; i += 12)
            {
                var batch = installments.Skip(i).Take(12).ToList(); // Take the next 12 installments
                var yearlyInstallment = new YearlyInstallment(batch);

                var growthFactor = CalculatorService.CalculateCagrGrowthFactor(yearlyInstallment.Principal, yearlyInstallment.Interest, yearlyInstallment.Insurance);
                var interestRateGrowthFactor = CalculatorService.CalculateInterestGrowthFactor(yearlyInstallment.Principal, yearlyInstallment.Interest, yearlyInstallment.Insurance);
                var remainingYears = Math.Max(0, (lastMonth / 12.0) - yearlyInstallment.Id + 1);
                yearlyInstallment.RemainingMonths = lastMonth - yearlyInstallment.Id * 12 + 1; ; 
                yearlyInstallment.CAGR = CalculatorService.CalculateCompoundInterest(growthFactor, remainingYears);
                yearlyInstallment.InterestRate = CalculatorService.CalculateCompoundInterest(interestRateGrowthFactor, remainingYears);

                yearlyInstallments.Add(yearlyInstallment); // Create a new YearlyInstallment with the batch
            }

            return yearlyInstallments;
        }
    }
    public class NumberGenerator
    {
        private int count = 0; // Tracks how many times the function is called

        public double GetNext()
        {

            if (count < 36)
            {
                count++;
                return 4.99;
            }
            return 8.16;
        }
    }

}
