using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class Constants
    {
        public const int MIN_RETURN_PERCENTAGE = -100;

        public static class RegexPatterns
        {
            public const string BCR = @"^\d{1,3}\s\d{2}/\d{2}/\d{4}.*"; //Matches line starting like "1 DATE" - "999 DATE"
            public const string MISTERY_DATES = @"^\d{2}-\d{2}-\d{4}$";
            public const string MISTERY_DATA = @"^ \d.*\.\d{2}$";
        }

        public static class Insurance
        {
            public static double Value { get; set; }
            public const double BCR_VALUE = 0.026;
            public const double MISTERY_VALUE = 0.0;
        }
    }
}
/*
 * De adaugat un line graph
 */