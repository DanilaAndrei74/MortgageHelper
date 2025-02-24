using BusinessLogic.Services;
using Models.Interfaces;
using TestHelpers.Helpers;

namespace BusinessLogicTest.Services
{
    public class CalculatorServiceTest
    {
        [Theory]
        [InlineData(12, 100)]
        [InlineData(100, 500)]
        [InlineData(360, 1000)]
        public void CalculateSummaryTest(int numberOfInstallments, int startingPrincipal)
        {
            var installments = Helper.GetInstallments(numberOfInstallments, startingPrincipal);

            var summary = Calculator.CalculateSummary(new List<IInstallment>(installments));

            Assert.Equal(installments.Sum(x => x.Principal), summary.Principal);
            Assert.Equal(installments.Sum(x => x.Insurance), summary.Insurance);
            Assert.Equal(installments.Sum(x => x.Interest), summary.Interest);
            Assert.Equal(installments.Sum(x => x.Total), summary.Total);

        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(2, 1, 100)]
        [InlineData(1.5, 5, 8.447)]
        [InlineData(1.1, 1, 10)]
        public void CalculateCompoundInterestTest(double growthFactor, double numberOfYears, double expected)
        {
            double result = Calculator.CalculateCompoundInterest(growthFactor, numberOfYears);

            Assert.Equal(expected, result, 3);
        }
    }
}