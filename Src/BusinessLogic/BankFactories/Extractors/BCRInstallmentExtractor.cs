using BusinessLogic.Services;
using Models;
using MortgageHelper;
using MortgageHelper.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BankFactories.Extractors
{
    public class BCRInstallmentExtractor : BaseInstallmentExtractor
    {
        public override List<Installment> ExtractInstallments(string filePath)
        {
            var pdfText = ExtractTextFromPdf(filePath);
            var lines = GetLinesFromRegex(pdfText, Constants.RegexPatterns.BCR);
            var installments = ToInstallment(lines);

            return installments;
        }

        protected override List<Installment> ToInstallment(List<string> lines)
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

                var cagrGrowthFactor = Calculator.CalculateCagrGrowthFactor(installment.Principal, installment.Interest, installment.Insurance);
                var interestRateGrowthFactor = Calculator.CalculateInterestGrowthFactor(installment.Principal, installment.Interest, installment.Insurance);

                installment.RemainingMonths = lastMonth - installment.Id + 1;
                installment.CAGR = Calculator.CalculateCompoundInterest(cagrGrowthFactor, installment.RemainingMonths / 12);
                installment.InterestRate = Calculator.CalculateMortgageRate(
                    installment.Total - installment.Insurance,
                    installment.CreditBalance + installment.Principal,
                    installment.RemainingMonths);

                installments.Add(installment);
            }


            return installments;
        }
    }
}
