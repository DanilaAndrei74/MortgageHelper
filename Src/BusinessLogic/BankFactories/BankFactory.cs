using BusinessLogic.BankFactories.Extractors;
using BusinessLogic.Interfaces;
using Models.Enums;

namespace BusinessLogic.BankFactories
{
    public static class BankFactory
    {
        public static IInstallmentExtractor GetExtractor(Banks bank)
        {
            return bank switch
            {
                Banks.BCR => new BCRInstallmentExtractor(),
                Banks.MISTERY => new MisteryInstallmentExtractor(),
                _ => throw new ArgumentException("Invalid bank strategy")
            };
        }
    }

}
