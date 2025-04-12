using BusinessLogic.Services;
using Models;
using Models.Enums;
using Models.Models;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

namespace BusinessLogic.BankFactories.Extractors
{
    //TODO: Add unit tests for this some day
    [ExcludeFromCodeCoverage]
    public class OTPInstallmentExtractor : BaseInstallmentExtractor
    {
        public override List<Installment> ExtractInstallments(string filePath)
        {
            var pdfText = ExtractTextFromPdf(filePath);
            var lines = GetFilteredLinesForOTP(pdfText);
            var installments = ToInstallment(lines);
            return installments;
        }

        //TODO: Refector this method and child ones after adding unit tests 
        private List<string> GetFilteredLinesForOTP(string text)
        {
            var lines = new List<string>();

            try
            {
                //@"^\d{2}-\d{2}-\d{4}$";
                // Extract dates and numbers Remove(19, 20) -> These are not valid data
                // @"^ \d.*"; -> Returns Interest, Principal, Total, CreditBalance, Zeroes
                // First page is 19 entries then 27 for each one after. So last is (Count - 19 - 2)% 27
                var firstPageEntries = 19;

                var dates = GetLinesFromRegex(text, Constants.RegexPatterns.OTP_DATES);

                if (dates.Count >= 21)
                    dates.RemoveRange(19, 2); //Remove these values because they are useless data
                else
                    dates.RemoveRange(dates.Count - 1, 2);

                dates = dates
                        .Select(date => DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture)
                        .ToString("dd/MM/yyyy"))
                        .ToList();


                var pageEntrySize = GeneratePageSize(dates.Count);
                var index = 1;


                var line = 0; // "{index},{dates[index - 1];}, {dates."
                var data = GetLinesFromRegex(text, Constants.RegexPatterns.OTP_DATA);
                data.RemoveAt(data.Count - 1);

                var pages = new List<List<string>>();
                var pageDates = new List<List<string>>();

                var readEntries = 0;
                var pagesAdded = 0;
                foreach (var page in pageEntrySize)
                {
                    var toAdd = data.Skip(readEntries).Take(5 * page).ToList();
                    readEntries += 5 * page;

                    pages.Add(toAdd);

                    var pageDatesToAdd = dates.Skip(pagesAdded).Take(page).ToList();
                    pagesAdded += page;
                    pageDates.Add(pageDatesToAdd);
                }

                var j = 0;
                
                var startingIndex = 1;
                foreach (var page in pages)
                {

                    var a = GetLinesFromPage(page, pageDates[j], pageEntrySize[j], startingIndex);
                    lines.AddRange(a);

                    startingIndex += pageEntrySize[j];
                    j++;
                }
            }
            catch(Exception e)
            {

            }


            return lines;
        }

        private List<string> GetLinesFromPage(List<string> page, List<string> dates, int pageSize, int startingIndex)
        {
            var lines = new List<string>();
            for (var index = 0; index < pageSize; index++)
            {
                StringBuilder sb = new StringBuilder();

                string interest = page[index];
                string principal = page[index + pageSize];
                string total = page[index + 2 * pageSize];
                string creditBalance = page[index + 3 * pageSize];
                string zeroes = page[index + 4 * pageSize];

                sb.AppendJoin(" ", new string[] { (startingIndex + index).ToString(), dates[index], principal, interest, zeroes, zeroes, total, creditBalance, zeroes });
                lines.Add(sb.ToString());
            }
            return lines;
        }

        private int[] GeneratePageSize(int totalCount)
        {
            List<int> chunks = new List<int>();

            if (totalCount <= 19)
            {
                chunks.Add(totalCount);
                return chunks.ToArray();
            }

            chunks.Add(19);
            totalCount -= 19;

            while (totalCount > 27)
            {
                chunks.Add(27);
                totalCount -= 27;
            }

            if (totalCount > 0)
            {
                chunks.Add(totalCount);
            }

            return chunks.ToArray();
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
