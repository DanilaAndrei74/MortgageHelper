namespace BusinessLogic.Helpers
{
    public static class ObjectExtensions
    {
        public static void RoundDoubleProperties(this object obj, int decimalPlaces = 2)
        {
            if (obj == null) return;

            // Get all properties of the object
            var properties = obj.GetType().GetProperties();

            foreach (var prop in properties)
            {
                // Check if the property is of type double and is writable
                if (prop.PropertyType == typeof(double) && prop.CanWrite)
                {
                    // Get the current value
                    double value = (double)prop.GetValue(obj);

                    // Round it
                    double roundedValue = Math.Round(value, decimalPlaces);

                    // Set the new value
                    prop.SetValue(obj, roundedValue);
                }
            }
        }
    }
}
