using BusinessLogic.BankFactories.Extractors;
using BusinessLogic.Interfaces;

namespace BusinessLogicTest.BankFactories.Extractors
{
    [Collection("FileAccessTests")]
    public class TestableBaseInstallmentExtractor : BaseInstallmentExtractor
    {
        public TestableBaseInstallmentExtractor()
        {
        }

        public override List<string> ExtractInstallments(string filePath)
        {
            return new List<string>(); // Not needed for testing protected methods
        }

        // Expose protected methods for testing
        public List<string> GetLinesFromRegex(string text, string pattern)
        {
            return base.GetLinesFromRegex(text, pattern);
        }

        public string ExtractTextFromPdf(string pdfPath)
        {
            return base.ExtractTextFromPdf(pdfPath);
        }
    }
}
