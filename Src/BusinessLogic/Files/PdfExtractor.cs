using BusinessLogic.Interfaces;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf;

namespace BusinessLogic.Files
{
    public class PdfExtractor : IFileExtractor
    {
        public string ExtractText(string pdfPath)
        {
            using (PdfReader reader = new PdfReader(pdfPath))
            using (PdfDocument pdfDoc = new PdfDocument(reader))
            {
                string text = "";
                for (int page = 1; page <= pdfDoc.GetNumberOfPages(); page++)
                {
                    var strategy = new SimpleTextExtractionStrategy();
                    text += "\n" + PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(page), strategy);
                }
                return text;
            }
        }
    }
}
