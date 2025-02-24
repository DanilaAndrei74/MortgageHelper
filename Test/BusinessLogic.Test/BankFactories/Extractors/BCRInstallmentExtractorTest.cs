using BusinessLogic.BankFactories;
using BusinessLogic.BankFactories.Extractors;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Helpers;
using TestHelpers.Helpers;

namespace BusinessLogic.Test.BankFactories.Extractors
{
    [Collection("FileAccessTests")]
    public class BCRInstallmentExtractorTest
    {
        [Fact]
        public void ExtractInstallments_ShouldReturnMatchingLines_WhenValidPdfProvided()
        {
            // Arrange
            string testPdfPath = TestPdfGenerator.CreateSamplePdf(HelperConstants.BCR_PDF_LINE);
            var extractor = BankFactory.GetExtractor(Banks.BCR);


            // Act
            List<string> extractedLines = extractor.ExtractInstallments(testPdfPath);

            // Assert
            Assert.Equal(new List<string>() { HelperConstants.BCR_PDF_LINE } , extractedLines);


            // Cleanup
            File.Delete(testPdfPath);
        }
    }
}
