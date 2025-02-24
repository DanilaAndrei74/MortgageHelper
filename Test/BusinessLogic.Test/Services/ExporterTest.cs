using BusinessLogic.Services;
using Models.Enums;
using Models.Interfaces;
using Moq;
using MortgageHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTest.Services
{
    public class ExporterTest
    {
        [Fact]
        public void ToCSV_ShouldReturnFalse_WhenDataIsNull()
        {
            // Arrange
            var mockFileWriter = new Mock<IFileWriter>();
            var exporter = new Exporter(mockFileWriter.Object);

            // Act
            bool result = exporter.ToCSV(null, "dummy.csv");

            // Assert
            Assert.False(result);
            mockFileWriter.Verify(x => x.WriteAllText(It.IsAny<string>(), It.IsAny<string>()), Times.Never);
        }

        [Fact]
        public void ToCSV_ShouldReturnFalse_WhenDataIsEmpty()
        {
            // Arrange
            var mockFileWriter = new Mock<IFileWriter>();
            var exporter = new Exporter(mockFileWriter.Object);

            // Act
            bool result = exporter.ToCSV(null, "dummy.csv");

            // Assert
            Assert.False(result);
            mockFileWriter.Verify(x => x.WriteAllText(It.IsAny<string>(), It.IsAny<string>()), Times.Never);
        }

        [Fact]
        public void ToCSV_ShouldWriteToFile_WhenDataIsValid()
        {
            // Arrange
            var mockFileWriter = new Mock<IFileWriter>();
            var exporter = new Exporter(mockFileWriter.Object);
            var testData = new List<IInstallment>
        {
            new Installment { Principal = 1000, Interest = 50, Insurance = 20, Total = 1070 },
            new Installment { Principal = 2000, Interest = 100, Insurance = 30, Total = 2130 }
        };

            // Act
            bool result = exporter.ToCSV(testData, "dummy.csv");

            // Assert
            Assert.True(result);
            mockFileWriter.Verify(x => x.WriteAllText("dummy.csv",
                It.Is<string>(content => content.Contains("1000,50,20,1070") &&
                                         content.Contains("2000,100,30,2130"))), Times.Once);
        }

        [Fact]
        public void ToCSV_ReturnsFalse_WhenFileWriteFails()
        {
            // Arrange
            var mockFileWriter = new Mock<IFileWriter>();
            var exporter = new Exporter(mockFileWriter.Object);
            var testData = new List<IInstallment>
        {
            new Installment { Principal = 1000, Interest = 50, Insurance = 20, Total = 1070 }
        };

            // Simulate an exception during file writing
            mockFileWriter.Setup(x => x.WriteAllText(It.IsAny<string>(), It.IsAny<string>()))
                          .Throws(new IOException("File system error"));

            // Act & Assert (Exception expected)
            Assert.False(exporter.ToCSV(testData, "csv.csv"));
        }

    }
}
