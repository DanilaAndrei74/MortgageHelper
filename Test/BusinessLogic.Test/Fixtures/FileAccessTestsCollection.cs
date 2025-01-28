using System;
using Xunit;

[CollectionDefinition("FileAccessTests", DisableParallelization = true)]
public class FileAccessTestsCollection
{
    public FileAccessTestsCollection()
    {
        Console.WriteLine("FileAccessTestsCollection initialized");
    }
}
