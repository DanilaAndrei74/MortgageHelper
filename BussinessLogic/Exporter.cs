using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class Exporter
    {
        public static bool ToCSV<T>(List<T> data, string filePath)
        {
            if (data == null || data.Count == 0)
            {
                return false;
            }

            var sb = new StringBuilder();
            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            // Write Header Row (Column Names)
            sb.AppendLine(string.Join(",", properties.Select(p => p.Name)));

            // Write Data Rows
            foreach (var item in data)
            {
                var values = properties.Select(p => p.GetValue(item)?.ToString()?.Replace(",", " ") ?? "");
                sb.AppendLine(string.Join(",", values));
            }

            try
            {
                // Save to File
                File.WriteAllText(filePath, sb.ToString());
                Console.WriteLine($"CSV file saved to: {filePath}");
                return true;
            }
            catch (Exception e) { return false; } ;
        }
    }
}
