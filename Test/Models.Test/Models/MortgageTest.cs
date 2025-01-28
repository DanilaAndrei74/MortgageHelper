using Models.Enums;
using Models.Models;


namespace ModelsTest.Models
{
    public class MortgageTest
    {
        [Fact]
        public void CreateMortgage()
        {
            var mortgage = new Mortgage(Banks.BCR);

            Assert.NotNull(mortgage);
        }
    }
}
