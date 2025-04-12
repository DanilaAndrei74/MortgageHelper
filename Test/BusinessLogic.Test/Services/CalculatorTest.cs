using BusinessLogic.Services;
using Models.Interfaces;
using Models.Models;

public class CalculatorTest
{
    [Fact]
    public void CalculateSummary_ShouldSumInstallments()
    {
        // Arrange
        var installments = new List<IInstallment>
        {
            new SimpleInstallment { Principal = 1000, Interest = 200, Insurance = 50 },
            new SimpleInstallment { Principal = 500, Interest = 100, Insurance = 25 }
        };

        // Act
        var summary = Calculator.CalculateSummary(installments);

        // Assert
        Assert.Equal(1500, summary.Principal);
        Assert.Equal(300, summary.Interest);
        Assert.Equal(75, summary.Insurance);
        Assert.Equal(1875, summary.Total);
    }

    [Fact]
    public void DetermineFixedPaymentPeriod_ShouldReturnCorrectPeriod()
    {
        // Arrange
        var installments = new List<IInstallment>
        {
            new SimpleInstallment { Total = 500 },
            new SimpleInstallment { Total = 500 },
            new SimpleInstallment { Total = 500 },
            new SimpleInstallment { Total = 800 } 
        };

        // Act
        int period = Calculator.DetermineFixedPaymentPeriod(installments);

        // Assert
        Assert.Equal(3, period); // Should return index of first change
    }

    [Fact]
    public void DetermineFixedPaymentPeriod_ShouldReturnCount_WhenToFewInstallments()
    {
        // Arrange
        var installments = new List<IInstallment>
        {
            new SimpleInstallment { Total = 500 },
            new SimpleInstallment { Total = 500 },
        };

        // Act
        int period = Calculator.DetermineFixedPaymentPeriod(installments);

        // Assert
        Assert.Equal(2, period); // Should return index of first change
    }

    [Fact]
    public void DetermineFixedPaymentPeriod_ShouldReturnCount_WhenPeriodIsFixed()
    {
        // Arrange
        var installments = new List<IInstallment>
        {
            new SimpleInstallment { Total = 500 },
            new SimpleInstallment { Total = 500 },
            new SimpleInstallment { Total = 500 },
            new SimpleInstallment { Total = 500 },
            new SimpleInstallment { Total = 500 }
        };

        // Act
        int period = Calculator.DetermineFixedPaymentPeriod(installments);

        // Assert
        Assert.Equal(5, period); // Should return index of first change
    }

    [Fact]
    public void CalculateCompoundInterest_ShouldReturnCorrectRate()
    {
        // Act
        double result = Calculator.CalculateCompoundInterest(2, 5);

        // Assert
        Assert.Equal(14.87, result, 2); // Approximate expected value
    }

    [Fact]
    public void CalculatePayment_ShouldReturnCorrectAmount()
    {
        // Act
        double payment = Calculator.CalculatePayment(10000, 5, 60);

        // Assert
        Assert.True(payment > 0);
    }

    [Fact]
    public void CalculateMonthlyInterestPaid_ShouldReturnCorrectInterest()
    {
        // Act
        double interest = Calculator.CalculateMonthlyInterestPaid(10000, 5);

        // Assert
        Assert.Equal(41.67, interest, 2);
    }

    [Fact]
    public void GetNewMonthsAfterAdditionalPayment_ShouldReduceMonths()
    {
        // Act
        int newMonths = Calculator.GetNewMonthsAfterAdditionalPayment(10000, 5, 60, 1000);

        // Assert
        Assert.True(newMonths < 60);
    }

    [Fact]
    public void GetNewMonthsAfterAdditionalPayment_ShouldReturnPeriod_WhenPayment0()
    {
        // Act
        int newMonths = Calculator.GetNewMonthsAfterAdditionalPayment(10000, 5, 60, 0);

        // Assert
        Assert.Equal(60, newMonths);
    }

    [Fact]
    public void CalculateMortgageRate_ShouldReturnCorrectRate()
    {
        // Act
        double rate = Calculator.CalculateMortgageRate(500, 10000, 60);

        // Assert
        Assert.True(rate > 0);
    }

    [Fact]
    public void CalculateMortgageRate_ShouldReturn0_WhenMonths0()
    {
        // Act
        double rate = Calculator.CalculateMortgageRate(500, 10000, 0);

        // Assert
        Assert.Equal(0, rate);
    }

    [Fact]
    public void CalculateInterestGrowthFactor_ShouldReturnCorrectFactor()
    {
        // Act
        double result = Calculator.CalculateInterestGrowthFactor(10000, 500, 100);

        // Assert
        Assert.Equal(1.06, result, 2);
    }

    [Fact]
    public void CalculateCagrGrowthFactor_ShouldReturnCorrectFactor()
    {
        // Act
        double result = Calculator.CalculateCagrGrowthFactor(10000, 500, 100);

        // Assert
        Assert.Equal(0.06, result, 2);
    }

    [Fact]
    public void CalculatePeriod()
    {
        // Act
        double period = Calculator.CalculatePeriod();

        // Assert
        Assert.Equal(0, period);
    }


    [Fact]
    public void CalculateInsurance_ShouldReturnCorrectInsurance()
    {
        // Act
        double insurance = Calculator.CalculateInsurance(10000, 0.5);

        // Assert
        Assert.Equal(50, insurance);
    }
}
