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
    public class TextService
    {

        public TextService()
        {
        }

        public string ExtractTextFromPdf(string pdfPath)
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

        public List<string> GetLines(string text)
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
