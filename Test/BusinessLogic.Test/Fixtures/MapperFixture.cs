using BusinessLogic.Services;
using Models.Enums;

namespace Test.Helpers.Fixtures
{
    public class MapperFixture
    {
        public InterestRatesIterator InterestRates { get; }
        public Insurance Insurance { get; }
        public DueDateIterator DueDates { get; }
        public Mapper Mapper { get; }

        public MapperFixture(int months, double fixedRate, double variableRate)
        {
            InterestRates = new InterestRatesIterator();
            InterestRates.SetInterestRates(months, fixedRate, variableRate);

            Insurance = new Insurance();
            Insurance.SetPercentage(Banks.CUSTOM, 0.026);

            DueDates = new DueDateIterator();

            Mapper = new Mapper(Insurance, DueDates, InterestRates);
        }
    }
}
