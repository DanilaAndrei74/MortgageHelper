using MortgageHelper.Models;
using TestHelpers.Helpers;

namespace ModelsTest.Models
{
    public class YearlyInstallmentTest
    {
        [Fact]
        public void CreateYearlyInstallment_Success()
        {
            int installmentsNumber = 12;
            int firstPrincipal = 100;

            var installements = Helper.GetInstallments(installmentsNumber, firstPrincipal);

            var yearlyInstallment = new YearlyInstallment(installements);

            Assert.Equal(1, yearlyInstallment.Id);
            Assert.Equal(installements.Select(x => x.Principal).Sum(), yearlyInstallment.Principal);
            Assert.Equal(installements.Select(x => x.Insurance).Sum(), yearlyInstallment.Insurance);
            Assert.Equal(installements.Select(x => x.Interest).Sum(), yearlyInstallment.Interest);
            Assert.Equal(installements.Select(x => x.Total).Sum(), yearlyInstallment.Total);
            Assert.Equal(installements.Count, yearlyInstallment.Installments.Count);
            Assert.Equal(0, yearlyInstallment.CreditBalance);
        }

        [Fact]
        public void CreateYearlyInstallment_Error()
        {
            var installements = Helper.GetInstallments(0, 0);

            Assert.Throws<ArgumentException>(() => new YearlyInstallment(installements));
            Assert.Throws<ArgumentException>(() => new YearlyInstallment(null));
        }
    }
}