using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Helpers.Fixtures
{
    public class CreditInfoFixture
    {
        public double CreditBalance { get; set; } = 100000;
        public int CreditMonths { get; set; } = 360;
        public int FixedPeriod { get; set; } = 36;
        public double FixedRate { get; set; } = 5;
        public double VariableRate { get; set; } = 8;
    }
}
