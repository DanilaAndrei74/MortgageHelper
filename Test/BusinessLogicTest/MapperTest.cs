using Microsoft.VisualBasic;
using MortgageHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Constants = Models.Constants;
using Models.Enums;

namespace BusinessLogicTest
{
    public class MapperTest
    {
        [Fact]
        public void CalculateInstallmentPlanTest()
        {
            //Arrange
            var creditBalance = 100000;
            var months = 100;
            InterestRates.fixedRatePeriod = months;
            InterestRates.fixedRate = 5;
            Insurance.SetPercentageByBank(Banks.CUSTOM, 0.026);
            Helpers.GenerateDates(months);

            //Act
            var installments = Mapper.CalculateInstallmentPlan(creditBalance, months);

            //Assert
            Assert.Equal(100, installments.Count());
            Assert.Equal(0, installments.Last().CreditBalance);
        }

        [Fact]
        public void CalculateInstallmentPlan_PropertiesShouldNotBeNull()
        {
            //Arrange
            var creditBalance = 100000;
            var months = 100;
            InterestRates.fixedRatePeriod = months;
            InterestRates.fixedRate = 5;
            Insurance.SetPercentageByBank(Banks.CUSTOM, 0.026);
            Helpers.GenerateDates(months);

            //Act
            var installments = Mapper.CalculateInstallmentPlan(creditBalance, months);

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
