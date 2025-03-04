using BusinessLogic.Services;
using Models;
using Models.Enums;

namespace BusinessLogicTest.Services
{
    public class InsuranceTests
    {
        [Fact]
        public void SetPercentage_ShouldSetBCRValue_WhenBankIsBCR()
        {
            // Arrange
            var insurance = new Insurance();

            // Act
            insurance.SetPercentage(Banks.BCR);

            // Assert
            Assert.Equal(Constants.Insurance.BCR_VALUE, insurance.Percentage);
        }

        [Fact]
        public void SetPercentage_ShouldSetOTPValue_WhenBankIsOTP()
        {
            // Arrange
            var insurance = new Insurance();

            // Act
            insurance.SetPercentage(Banks.OTP);

            // Assert
            Assert.Equal(Constants.Insurance.OTP_VALUE, insurance.Percentage);
        }

        [Fact]
        public void SetPercentage_ShouldSetCustomValue_WhenBankIsCUSTOM()
        {
            // Arrange
            var insurance = new Insurance();
            double customPercentage = 0.026;

            // Act
            insurance.SetPercentage(Banks.CUSTOM, customPercentage);

            // Assert
            Assert.Equal(customPercentage, insurance.Percentage);
        }

        [Fact]
        public void SetPercentage_ShouldSetZero_WhenBankIsUnknown()
        {
            // Arrange
            var insurance = new Insurance();

            // Act
            insurance.SetPercentage((Banks)999);

            // Assert
            Assert.Equal(0, insurance.Percentage);
        }
    }
}
