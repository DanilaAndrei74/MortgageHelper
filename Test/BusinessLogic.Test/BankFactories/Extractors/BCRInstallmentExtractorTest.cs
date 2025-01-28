using BusinessLogic.BankFactories;
using BusinessLogic.BankFactories.Extractors;
using Models.Enums;
using MortgageHelper.Models;
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
            var example = new Installment()
            { 
                Id = 1,
                DueDate = new DateOnly(2000, 1, 1),
                Principal = 3000,
                Interest = 1000,
                Insurance = 100,
                Total = 4100,
                CreditBalance = 100000,
                CAGR = -100,
                InterestRate = -1153.4,
                RemainingMonths = 1
            };


            // Act
            List<Installment> extractedLines = extractor.ExtractInstallments(testPdfPath);

            // Assert
            Assert.Equal(example.Principal , extractedLines.First().Principal);
            Assert.Equal(example.Interest, extractedLines.First().Interest);
            Assert.Equal(example.Insurance, extractedLines.First().Insurance);
            Assert.Equal(example.Total, extractedLines.First().Total);
            Assert.Equal(example.CreditBalance, extractedLines.First().CreditBalance);


            // Cleanup
            File.Delete(testPdfPath);
        }
    }
}
