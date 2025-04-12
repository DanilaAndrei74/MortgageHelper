namespace Models.Models
{
    public class YearlyInstallment : Installment
    {
        public IReadOnlyList<Installment> Installments { get; }

        public YearlyInstallment(List<Installment> installments)
        {
            if (installments == null || installments.Count == 0)
            {
                throw new ArgumentException("Installments list cannot be null or empty", nameof(installments));
            }

            Installments = installments.AsReadOnly();

            Id = Installments.First().Id / 12 + 1;
            DueDate = Installments.First().DueDate;
            Principal = Math.Round(Installments.Sum(x => x.Principal), 2);
            Interest = Math.Round(Installments.Sum(x => x.Interest), 2);
            Insurance = Math.Round(Installments.Sum(x => x.Insurance), 2);
            Total = Math.Round(Installments.Sum(x => x.Total), 2);
            CreditBalance = Math.Round(Installments.First().CreditBalance - Installments.Skip(1).Sum(x => x.Principal), 2);
        }
    }
}
