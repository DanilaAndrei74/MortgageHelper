using Models.Models;


namespace MortgageHelper
{
    public partial class SummaryForm : Form
    {
        public SummaryForm(InstallmentDifference installmentDifference)
        {
            InitializeComponent();
            
            SummaryGridView.Rows.Add("Old",
                installmentDifference.OldInstallment.Principal,
                installmentDifference.OldInstallment.Interest,
                installmentDifference.OldInstallment.Insurance,
                installmentDifference.OldInstallment.Total,
                installmentDifference.OldPeriod);

            SummaryGridView.Rows.Add("New",
                installmentDifference.NewInstallment.Principal,
                installmentDifference.NewInstallment.Interest,
                installmentDifference.NewInstallment.Insurance,
                installmentDifference.NewInstallment.Total,
                installmentDifference.NewPeriod);

            SummaryGridView.Rows.Add("Difference",
                installmentDifference.Difference.Principal,
                installmentDifference.Difference.Interest,
                installmentDifference.Difference.Insurance,
                installmentDifference.Difference.Total,
                installmentDifference.PeriodDifference);

            AnnualizedReturnTextBox.Text = installmentDifference.AnnualizedReturn.ToString() + " %";
        }

    }
}
