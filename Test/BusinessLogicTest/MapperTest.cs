using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Constants = Models.Constants;
using Models.Enums;
using BusinessLogic.Services;

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
            var fixedRate = 5;
            var variableRate = 8;

            var _interestRates = new InterestRatesIterator();
            _interestRates.SetInterestRates(months, fixedRate, variableRate);
            var _insurace = new Insurance();
            _insurace.SetPercentage(Banks.CUSTOM, 0.026);
            var _dates = new DueDateIterator();
            var _mapper = new Mapper(_insurace, _dates, _interestRates);
            Helpers.GenerateDates(months, ref _dates);

            //Act
            var installments = _mapper.MapToNewInstallmentPlan(creditBalance, months);

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
            var fixedRate = 5;
            var variableRate = 8;

            var _interestRates = new InterestRatesIterator();
            _interestRates.SetInterestRates(months, fixedRate, variableRate);
            var _insurace = new Insurance();
            _insurace.SetPercentage(Banks.CUSTOM, 0.026);
            var _dates = new DueDateIterator();
            var _mapper = new Mapper(_insurace, _dates, _interestRates);
            Helpers.GenerateDates(months, ref _dates);

            //Act
            var installments = _mapper.MapToNewInstallmentPlan(creditBalance, months);

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
