using BusinessLogic.BankFactories.Extractors;
using BusinessLogic.Interfaces;
using MortgageHelper.Models;

namespace BusinessLogicTest.BankFactories.Extractors
{
    [Collection("FileAccessTests")]
    public class TestableBaseInstallmentExtractor : BaseInstallmentExtractor
    {
        public TestableBaseInstallmentExtractor()
        {
        }

        public override List<Installment> ExtractInstallments(string filePath)
        {
            return new List<Installment>(); // Not needed for testing protected methods
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

        protected override List<Installment> ToInstallment(List<string> lines)
        {
            throw new NotImplementedException();
        }
    }
}
