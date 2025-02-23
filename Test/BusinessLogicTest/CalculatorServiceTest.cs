using BusinessLogic.Services;

namespace BusinessLogicTest
{
    public class CalculatorServiceTest
    {
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