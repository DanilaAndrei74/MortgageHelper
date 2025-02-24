namespace BusinessLogic.Interfaces
{
    public interface IInstallmentExtractor
    {
        List<string> ExtractInstallments(string filePath);
    }
}
