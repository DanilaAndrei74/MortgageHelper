using Test.Helpers.Fixtures;

namespace BusinessLogicTest.Services
{
    public class InterestRatesIteratorTest
    {
        [Fact]
        public void SetInterestRatesBasedOnInstallments_Test()
        {
            //Arrange
            var data = new CreditInfoFixture();
            var mapperFixture = new MapperFixture(data.FixedPeriod, data.FixedRate, data.VariableRate);
            var installments = mapperFixture.Mapper.MapToNewInstallmentPlan(data.CreditBalance, data.CreditMonths);

            //Act
            mapperFixture.InterestRates.SetInterestRatesBasedOnInstallments(installments);

            //Assert
            Assert.Equal(data.FixedRate, mapperFixture.InterestRates.FixedRate);
            Assert.Equal(data.VariableRate, mapperFixture.InterestRates.VariableRate);
            Assert.Equal(data.FixedPeriod, mapperFixture.InterestRates.FixedRatePeriod);

        }
    }
}
