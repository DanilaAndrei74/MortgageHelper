namespace Models
{
    public static class Constants
    {
        public static class RegexPatterns
        {
            public const string BCR = @"^\d{1,3}\s\d{2}/\d{2}/\d{4}.*"; //Matches line starting like "1 DATE" - "999 DATE"
            public const string ING = @"^\d{1,3}\s\d{2}-\d{2}-\d{4}.*"; //Matches line starting like "1 DATE" - "999 DATE"
            public const string OTP_DATES = @"^\d{2}-\d{2}-\d{4}$";
            public const string OTP_DATA = @"^ \d.*\.\d{2}$";
            public const string BT = @"^\d{1,3}\s\d{2}-[A-Z]{3}-\d{4}(\s.+)?$";

        }

        public static class Insurance
        {
            public const double BCR_VALUE = 0.026;
            public const double ING_VALUE = 0.029;
            public const double OTP_VALUE = 0.0;
        }
    }
}