using BussinessLogic;
using iText.Kernel.Geom;
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

                var growthFactor = CalculatorService.CalculateGrowthFactor(installment.Principal, installment.Interest, installment.Insurance);
                var remainingYears = (lastMonth - installment.Id) / 12.00;
                installment.CAGR = CalculatorService.CalculateCAGR(growthFactor, remainingYears);

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

                var growthFactor = CalculatorService.CalculateGrowthFactor(yearlyInstallment.Principal, yearlyInstallment.Interest, yearlyInstallment.Insurance);
                var remainingYears = lastMonth / 12.00 - yearlyInstallment.Id;
                yearlyInstallment.CAGR = CalculatorService.CalculateCAGR(growthFactor, remainingYears);

                yearlyInstallments.Add(yearlyInstallment); // Create a new YearlyInstallment with the batch
            }

            return yearlyInstallments;
        }
    }

    public enum TableHeader
    {
        Number = 0,
        DueDate = 1,
        Principal = 2,
        Interest = 3,
        AdministrationFee = 4,
        InsuranceCosts = 5,
        Total = 6,
        CreditBalance = 7,
        AdjustedInterest = 8,
    }

}
