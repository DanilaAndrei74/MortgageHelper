namespace Models.Interfaces
{
    public interface IInstallment
    {
        double Principal { get; }
        double Interest { get; }
        double Insurance { get; }
        double Total { get; }
    }
}
