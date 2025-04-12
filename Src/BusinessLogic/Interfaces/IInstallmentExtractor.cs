using Models.Models;

namespace BusinessLogic.Interfaces
{
    public interface IInstallmentExtractor
    {
        List<Installment> ExtractInstallments(string filePath);
    }
}
