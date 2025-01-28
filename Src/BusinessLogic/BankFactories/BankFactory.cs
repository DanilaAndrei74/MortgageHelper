using BusinessLogic.BankFactories.Extractors;
using BusinessLogic.Interfaces;
using Models.Enums;

namespace BusinessLogic.BankFactories
{
    public static class BankFactory
    {
        public static IInstallmentExtractor GetExtractor(Banks bank)
        {
            //TODO: Refactor this to use a foreach in enum instead of a switch
            return bank switch
            {
                Banks.BCR => new BCRInstallmentExtractor(),
                Banks.OTP => new OTPInstallmentExtractor(),
                Banks.ING => new INGInstallmentExtractor(),
                Banks.BT => new BTInstallmentExtractor(),
                _ => throw new ArgumentException("Invalid bank strategy")
            };
        }
    }

}
