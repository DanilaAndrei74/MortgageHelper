using Test.Helpers.Fixtures;

namespace BusinessLogicTest.Services
{
    public class MapperTest
    {
        [Fact]
        public void CalculateInstallmentPlanTest()
        {
            //Arrange
            var data = new CreditInfoFixture();
            var fixture = new MapperFixture(data.FixedPeriod, data.FixedRate, data.VariableRate);

            //Act
            var installments = fixture.Mapper.MapToNewInstallmentPlan(data.CreditBalance, data.CreditMonths);

            //Assert
            Assert.Equal(data.CreditMonths, installments.Count());
            Assert.Equal(0, installments.Last().CreditBalance);
        }

        [Fact]
        public void CalculateInstallmentPlan_PropertiesShouldNotBeNull()
        {
            //Arrange
            var data = new CreditInfoFixture();
            var fixture = new MapperFixture(data.FixedPeriod, data.FixedRate, data.VariableRate);

            //Act
            var installments = fixture.Mapper.MapToNewInstallmentPlan(data.CreditBalance, data.CreditMonths);

            //Assert
            foreach (var installment in installments)
            {
                bool isLastInstallment = installment == installments.Last();

                Assert.NotEqual(0, installment.Principal);
                Assert.NotEqual(0, installment.Interest);
                Assert.True(installment.Insurance >= 0);

                if (isLastInstallment) Assert.True(installment.CreditBalance == 0);
                else Assert.True(installment.CreditBalance > 0);
            }
        }
    }

   
}
