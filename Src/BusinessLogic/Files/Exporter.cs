using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Exporter
{
    private readonly IFileWriter _fileWriter;

    public Exporter(IFileWriter fileWriter) => _fileWriter = fileWriter;

    public bool ToCSV(List<IInstallment> data, string filePath)
    {
        if (data == null || data.Count == 0) return false;

        var sb = new StringBuilder();

        // Write Header Row
        sb.AppendLine("Principal,Interest,Insurance,Total");

        // Write Data Rows
        foreach (var item in data)
        {
            sb.AppendLine($"{item.Principal},{item.Interest},{item.Insurance},{item.Total}");
        }

        try
        {
            _fileWriter.WriteAllText(filePath, sb.ToString());
            return true;
        }
        catch
        {
            return false;
        }
    }
}
