using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Models;
using Models.Enums;
using iText.StyledXmlParser.Jsoup.Safety;
using System.Globalization;

namespace MortgageHelper
{

    public delegate List<string> FilterFunction(string text);
    public static class PdfService
    {
        private static string _regexPattern;
        private static FilterFunction _getFilteredLines;
        public static List<string> ExtractLinesFromBankPdf(string filePath, Banks bank)
        {
            LoadStrategy(bank);
            var pdfText = ExtractTextFromPdf(filePath);
            return _getFilteredLines(pdfText);
        }
        private static string ExtractTextFromPdf(string pdfPath)
        {
            using (PdfReader reader = new PdfReader(pdfPath))
            {
                using (PdfDocument pdfDoc = new PdfDocument(reader))
                {
                    string text = "";
                    for (int page = 1; page <= pdfDoc.GetNumberOfPages(); page++)
                    {
                        var strategy = new SimpleTextExtractionStrategy();
                        text += PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(page), strategy);
                    }
                    return text;
                }
            }
        }

        private static List<string> GetFilteredLinesForBCR(string text)
        {
            return GetLinesFromRegex(text, Constants.RegexPatterns.BCR);
        }

        //TODO: Refector this method and child ones after adding unit tests 
        private static List<string> GetFilteredLinesForMystery(string text)
        {
            //@"^\d{2}-\d{2}-\d{4}$";
            // Extract dates and numbers Remove(19, 20) -> These are not valid data
            // @"^ \d.*"; -> Returns Interest, Principal, Total, CreditBalance, Zeroes
            // First page is 19 entries then 27 for each one after. So last is (Count - 19 - 2)% 27
            var firstPageEntries = 19;

            var dates = GetLinesFromRegex(text, Constants.RegexPatterns.MYSTERY_DATES);

            if (dates.Count >= 21)
                dates.RemoveRange(19, 2); //Remove these values because they are useless data
            else
                dates.RemoveRange(dates.Count-1, 2);

            dates = dates
                    .Select(date => DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture)
                    .ToString("dd/MM/yyyy"))
                    .ToList();


            var pageEntrySize = GeneratePageSize(dates.Count);
            var index = 1;


            var line = 0; // "{index},{dates[index - 1];}, {dates."
            var data = GetLinesFromRegex(text, Constants.RegexPatterns.MYSTERY_DATA);
            data.RemoveAt(data.Count - 1);

            var pages = new List<List<string>>();
            var pageDates = new List<List<string>>();

            var readEntries = 0;
            var pagesAdded = 0;
            foreach(var page in pageEntrySize)
            {
                var toAdd = data.Skip(readEntries).Take(5 * page).ToList();
                readEntries += 5 * page;

                pages.Add(toAdd);

                var pageDatesToAdd = dates.Skip(pagesAdded).Take(page).ToList();
                pagesAdded += page;
                pageDates.Add(pageDatesToAdd); 
            }

            var j = 0;
            var lines = new List<string>();
            var startingIndex = 1;
            foreach (var page in pages)
            {
                
                var a  = GetLinesFromPage(page, pageDates[j], pageEntrySize[j], startingIndex);
                lines.AddRange(a);

                startingIndex += pageEntrySize[j];
                j++;
            }



            return lines;
        }

        private static List<string> GetLinesFromPage(List<string> page, List<string> dates ,int pageSize, int startingIndex)
        {
            var lines = new List<string>();
            for(var index = 0; index < pageSize; index++)
            {
                StringBuilder sb = new StringBuilder();

                string interest = page[index];
                string principal = page[index + pageSize];
                string total = page[index + 2 * pageSize];
                string creditBalance = page[index + 3 * pageSize];
                string zeroes = page[index + 4 * pageSize];

                sb.AppendJoin(" ", new string[] {(startingIndex + index).ToString(), dates[index] ,principal, interest, zeroes, zeroes, total, creditBalance, zeroes });
                lines.Add(sb.ToString());
            }
            return lines;
        }

        private static List<string> GetLinesFromRegex(string text, string regexPattern)
        {
            Regex regex = new Regex(regexPattern, RegexOptions.Multiline);

            List<string> matchedLines = new List<string>();

            // Use regex to find matches in the text
            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                matchedLines.Add(match.Value); // Add the matched line to the list
            }

            return matchedLines;
        }

        private static void LoadStrategy(Banks bank)
        {
            _getFilteredLines = bank switch
            {
                Banks.BCR => GetFilteredLinesForBCR,
                Banks.MYSTERY => GetFilteredLinesForMystery,
                _ => throw new ArgumentException("Invalid bank strategy")
            };
        }

        private static int[] GeneratePageSize(int totalCount)
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
    }
}
