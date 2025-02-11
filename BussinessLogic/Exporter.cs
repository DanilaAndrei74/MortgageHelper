using Models.Interfaces;
using MortgageHelper.Models;
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
        public static bool ToCSV(List<IInstallment> data, string filePath)
        {
            if (data == null || data.Count == 0)
            {
                return false;
            }

            var sb = new StringBuilder();

            // Write Header Row (Column Names)
            sb.AppendLine(string.Join(",", 
                [
                    "Principal",
                    "Interest",
                    "Insurance",
                    "Total",
                ]));

            // Write Data Rows
            foreach (var item in data)
            {
                sb.AppendLine(string.Join(",",
                    [
                        item.Principal.ToString(),
                        item.Interest.ToString(),
                        item.Insurance.ToString(),
                        item.Total.ToString()
                    ]));
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
