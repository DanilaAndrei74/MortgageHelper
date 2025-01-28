using BusinessLogic.BankFactories.Extractors;
using BusinessLogic.BankFactories;
using Models.Enums;
using System;
using Xunit;

public class BankFactoryTests
{
    [Fact]
    public void GetExtractor_ShouldReturnBCRExtractor_WhenBankIsBCR()
    {
        // Act
        var extractor = BankFactory.GetExtractor(Banks.BCR);

        // Assert
        Assert.NotNull(extractor);
        Assert.IsType<BCRInstallmentExtractor>(extractor);
    }

    [Fact]
    public void GetExtractor_ShouldReturnOTPExtractor_WhenBankIsOTP()
    {
        // Act
        var extractor = BankFactory.GetExtractor(Banks.OTP);

        // Assert
        Assert.NotNull(extractor);
        Assert.IsType<OTPInstallmentExtractor>(extractor);
    }

    [Fact]
    public void GetExtractor_ShouldThrowArgumentException_WhenBankIsInvalid()
    {
        // Act & Assert
        var ex = Assert.Throws<ArgumentException>(() => BankFactory.GetExtractor((Banks)999));

        // Ensure exception message is correct
        Assert.Equal("Invalid bank strategy", ex.Message);
    }
}
