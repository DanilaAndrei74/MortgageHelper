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

namespace MortgageHelper
{
    public static class PdfService
    {
        private static string _regexPattern;

        public static List<string> ExtractLinesFromBankPdf(string filePath, Banks bank)
        {
            LoadStrategy(bank);
            var pdfText = ExtractTextFromPdf(filePath);
            return GetFilteredLines(pdfText);
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

        private static List<string> GetFilteredLines(string text)
        {
            Regex regex = new Regex(_regexPattern, RegexOptions.Multiline);

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
            switch (bank)
            {
                case Banks.BCR:
                    _regexPattern = Constants.RegexPatterns.BCR;
                    return;
            }
        }
    }
}
