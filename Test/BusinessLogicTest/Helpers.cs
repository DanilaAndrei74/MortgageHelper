using BusinessLogic.Services;
using MortgageHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTest
{
    public static class Helpers
    {
        public static void GenerateDates(int months, ref DueDateIterator dates)
        {
            DateOnly date = DateOnly.FromDateTime(DateTime.Now);
            for (int i = 0; i < months; i++)
            {
                dates.AddDate(date);
                date.AddMonths(1);
            }
        }
    }
}
