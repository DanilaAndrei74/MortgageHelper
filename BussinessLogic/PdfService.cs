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

namespace MortgageHelper
{
    public static class PdfService
    {

        public static List<string> ExtractLinesFromPdf(string filePath)
        {
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
            // Define a regular expression to match lines starting with the pattern
            string regexPattern = Constants.LINES_REGEX_PATTERN;
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
    }
}
