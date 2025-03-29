using Models;
using Models.Enums;

namespace BusinessLogic.Services
{
    public class Insurance
    {
        public double Percentage { get; private set; } = 0.00;
        
        public void SetPercentage(Banks bank, double percentage = 0)
        {
            switch(bank)
            {
                case Banks.BCR:
                {
                    Percentage = Constants.Insurance.BCR_VALUE;
                    break; 
                }
                case Banks.OTP:
                {
                    Percentage = Constants.Insurance.OTP_VALUE;
                    break;
                }
                case Banks.ING:
                {
                    Percentage = Constants.Insurance.ING_VALUE;
                    break;
                }
                case Banks.CUSTOM:
                {
                    Percentage = percentage;
                    break;
                }
                default:
                {
                    Percentage = 0;
                    break;
                }
            };
        }
    }

}
