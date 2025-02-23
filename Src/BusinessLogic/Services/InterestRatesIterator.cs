namespace BusinessLogic.Services
{
    public class InterestRatesIterator
    {
        private int count = 0; // Tracks how many times the function is called
        public int fixedRatePeriod { get; set; }
        public double fixedRate { get; set; }
        public double variableRate { get; set; }

        public void SetInterestRates(int fixedRatePeriod, double fixedRate, double variableRate)
        {
            this.fixedRatePeriod = fixedRatePeriod;
            this.fixedRate = fixedRate;
            this.variableRate = variableRate;
        }

        public double GetNext()
        {

            if (count < fixedRatePeriod)
            {
                count++;
                return fixedRate;
            }
            return variableRate;
        }

        public void Reset()
        {
            count = 0;
        }
    }

}
