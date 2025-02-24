using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace TestHelpers.Helpers
{
    public static class TestPdfGenerator
    {
        public static string CreateSamplePdf(string text)
        {
            string filePath = Path.Combine(Path.GetTempPath(), "test.pdf");

            using (PdfWriter writer = new PdfWriter(filePath))
            using (PdfDocument pdfDoc = new PdfDocument(writer))
            using (Document document = new Document(pdfDoc))
            {
                document.Add(new Paragraph(text));
            }

            return filePath;
        }
    }
}