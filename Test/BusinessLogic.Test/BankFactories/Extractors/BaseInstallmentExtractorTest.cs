using BusinessLogic.BankFactories.Extractors;
using BusinessLogic.Interfaces;
using Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Helpers;
using TestHelpers.Helpers;

namespace BusinessLogicTest.BankFactories.Extractors
{
    [Collection("FileAccessTests")]
    public class BaseInstallmentExtractorTest
    {
        #region Regex
        [Fact]
        public void GetLinesFromRegex_ShouldReturnMatchedLine()
        {
            // Arrange
            string text = "143 01/01/2054 3000.00 1000.00 0.00 50.00 4,050.00 100,000.00 0.00";
            string regexPattern = Constants.RegexPatterns.BCR;

            // Act
            var _sut = new TestableBaseInstallmentExtractor();
            var result = _sut.GetLinesFromRegex(text, regexPattern);

            // Assert
            Assert.Contains("143 01/01/2054 3000.00 1000.00 0.00 50.00 4,050.00 100,000.00 0.00", result);
        }

        [Fact]
        public void GetLinesFromRegex_ShouldReturnEmptyList_WhenNoMatches()
        {
            // Arrange
            string text = "Interest: 5%";
            string regexPattern = @"Payment\s*\d*"; // No "Payment" found

            // Act
            var _sut = new TestableBaseInstallmentExtractor();
            var result = _sut.GetLinesFromRegex(text, regexPattern);

            // Assert
            Assert.Empty(result);
        }
        #endregion

        #region PDF Extractor
        [Fact]
        public void ExtractTextFromPdf_ShouldReturnExtractedText()
        {
            // Arrange
            string pdfPath = TestPdfGenerator.CreateSamplePdf(HelperConstants.BCR_PDF_LINE);
            var extractor = new TestableBaseInstallmentExtractor();
            var example = "\n" + HelperConstants.BCR_PDF_LINE;

            // Act
            string extractedText = extractor.ExtractTextFromPdf(pdfPath);

            // Assert
            Assert.Equal(example, extractedText);

            //Cleanup
            File.Delete(pdfPath);
        }
        #endregion
    }
}
