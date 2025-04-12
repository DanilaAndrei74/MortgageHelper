using BusinessLogic.Services;
using Models.Enums;
using TestHelpers.Helpers;
public class MortgageServiceTests
{
    private readonly MortgageService _sut;

    public MortgageServiceTests()
    {
        _sut = new MortgageService();
    }

    [Fact]
    public void MortgageService_Test()
    {
        var text = @"
                1 01/01/2001 3,028.94 122.57 0.00 4.80 3,156.31 15,448.51 0.00
                2 01/01/2002 3,049.03 102.48 0.00 4.02 3,155.53 12,399.48 0.00
                3 01/01/2003 3,069.26 82.25 0.00 3.22 3,154.73 9,330.22 0.00
                4 01/01/2004 3,089.62 61.89 0.00 2.43 3,153.94 6,240.60 0.00
                5 01/01/2005 3,110.11 41.40 0.00 1.62 3,153.13 3,130.49 0.00
                6 01/01/2006 3,130.49 20.77 0.00 0.81 3,152.07 0.00 0.00";

        var path = TestPdfGenerator.CreateSamplePdf(text);

        _sut.SetBank(Banks.BCR)
                    .ExtractInstallmentsFrom(path)
                    .SetInsuranceBasedOnBank()
                    .SetInterestRatesBasedOnInstallments()
                    .SetAdditionalPayment(1000)
                    .CalculateDerivates()
                    .SimulateOptimalPayments();

        Assert.NotEmpty(_sut.Installments);
        Assert.NotEmpty(_sut.ReplicatedInstallments);
        Assert.NotEmpty(_sut.YearlyInstallments);
        Assert.NotEmpty(_sut.NewInstallments);
        Assert.NotEmpty(_sut.OptimalPayments);
        Assert.All(
            _sut.Installments.Zip(_sut.ReplicatedInstallments, (orig, replica) => (orig, replica)),
            pair => Assert.InRange(pair.orig.Principal, pair.replica.Principal - 1, pair.replica.Principal + 1)
        );

        Assert.All(
            _sut.Installments.Zip(_sut.ReplicatedInstallments, (orig, replica) => (orig, replica)),
            pair => Assert.InRange(pair.orig.Interest, pair.replica.Interest - 1, pair.replica.Interest + 1)
        );

        Assert.All(
            _sut.Installments.Zip(_sut.ReplicatedInstallments, (orig, replica) => (orig, replica)),
            pair => Assert.InRange(pair.orig.Insurance, pair.replica.Insurance - 1, pair.replica.Interest + 1)
        );

        Assert.InRange(_sut.Installments.Sum(x => x.Principal),
            _sut.ReplicatedInstallments.Sum(x => x.Principal) - 1,
            _sut.ReplicatedInstallments.Sum(x => x.Principal) + 1);

    }

}
