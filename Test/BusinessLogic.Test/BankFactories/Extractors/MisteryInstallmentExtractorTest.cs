using BusinessLogic.BankFactories;
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
    public class MisteryInstallmentExtractorTest
    {
        [Fact]
        public void ExtractInstallments_ShouldReturnEmptyList_WhenInValidPdfProvided()
        {
            // Arrange
            string testPdfPath = TestPdfGenerator.CreateSamplePdf("100 \n 200 \n 300 \n");
            var extractor = BankFactory.GetExtractor(Banks.MISTERY);

            // Act
            List<string> extractedLines = extractor.ExtractInstallments(testPdfPath);

            // Assert
            Assert.Equal(new List<string>(), extractedLines);


            // Cleanup
            File.Delete(testPdfPath);
        }
    }
}
