using BusinessLogic.Interfaces;
using System.Text.RegularExpressions;
using BusinessLogic.Files;
using MortgageHelper.Models;

namespace BusinessLogic.BankFactories.Extractors
{
    public abstract class BaseInstallmentExtractor : IInstallmentExtractor
    {
        public abstract List<Installment> ExtractInstallments(string filePath);
        private readonly IFileExtractor _pdfExtractor;

        protected BaseInstallmentExtractor()
        {
            _pdfExtractor = new PdfExtractor();
        }


        protected List<string> GetLinesFromRegex(string text, string regexPattern)
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

        protected string ExtractTextFromPdf(string pdfPath)
        {
            return _pdfExtractor.ExtractText(pdfPath);
        }

        protected abstract List<Installment> ToInstallment(List<string> lines);
    }
}
