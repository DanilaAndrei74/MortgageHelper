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
            public const string MYSTERY_DATES = @"^\d{2}-\d{2}-\d{4}$";
            public const string MYSTERY_DATA = @"^ \d.*\.\d{2}$";
        }
    }
}
/*
 * De adaugat un line graph
 */