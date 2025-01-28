using System.Diagnostics.CodeAnalysis;

[ExcludeFromCodeCoverage]
public class FileWriter : IFileWriter
{
    public void WriteAllText(string path, string content) => File.WriteAllText(path, content);
}
