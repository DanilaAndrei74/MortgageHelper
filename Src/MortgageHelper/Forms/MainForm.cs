using BusinessLogic.BankFactories;
using Models.Enums;
using Models.Interfaces;
using MortgageHelper.Models;
using BusinessLogic.Services;

namespace MortgageHelper
{
    public partial class MainForm : Form
    {

        private string _filePath;
        private IInstallment _summary;
        private int _selectedTab;
        
        private readonly MortgageService _mortgage;
        public MainForm()
        {
            InitializeComponent();
            bankComboBox.DataSource = Enum.GetValues(typeof(Banks));

            _mortgage = new MortgageService();
        }

        #region Controls
        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "PDF (*.pdf)|*.pdf";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectFileTextBox.Text = openFileDialog.FileName;
                _filePath = openFileDialog.FileName;
            }


        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_filePath))
            {
                MessageBox.Show("Please select a file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                _mortgage.SetBank((Banks)bankComboBox.SelectedValue!)
                    .ExtractInstallmentsFrom(_filePath)
                    .SetInsuranceBasedOnBank()
                    .SetInterestRatesBasedOnInstallments()
                    .SetAdditionalPayment(GetAdditionalPaymentFromTextBox())
                    .CalculateDerivates()
                    .SimulateOptimalPayments();


                ShowDifferenceButton.Visible = true;


                newInstallmentsDataGridView.DataSource = _mortgage.NewInstallments;
                replicatedInstallmentsDataGridView.DataSource = _mortgage.ReplicatedInstallments;
                installmentsDataGridView.DataSource = _mortgage.Installments;
                yearlyInstallmentsDataGridView.DataSource = _mortgage.YearlyInstallments;
                estimatedPerformanceDataGridView.DataSource = _mortgage.OptimalPayments;


            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            InitializeTotalBox();
        }


        private double GetAdditionalPaymentFromTextBox()
        {
            double extraordinaryPayment = 0; // Default value if parsing fails

            double.TryParse(additionalPaymentTextBox.Text, out extraordinaryPayment);

            return extraordinaryPayment;
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
                saveFileDialog.DefaultExt = "csv";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var data = GetListBasedOnInstallmentType((InstallmentTypes)TabControl.SelectedIndex);
                        var exporter = new Exporter(new FileWriter());
                        exporter.ToCSV(data, saveFileDialog.FileName);
                        MessageBox.Show("Data successfully exported to CSV.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error exporting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        public void InitializeTotalBox()
        {
            UpdateTotals();
            TotalValuesBox.Visible = true;
        }

        private void UpdateTotals()
        {
            _summary = Calculator.CalculateSummary(GetListBasedOnInstallmentType((InstallmentTypes)TabControl.SelectedIndex));
            TotalPrincipalLabel.Text = _summary.Principal.ToString();
            TotalInterestLabel.Text = _summary.Interest.ToString();
            TotalInsuranceLabel.Text = _summary.Insurance.ToString();
            TotalLabel.Text = _summary.Total.ToString();
        }

      

        #endregion

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void additionalPaymentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true; // Block invalid characters
            }

            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true; // Only one decimal point allowed
            }
        }

        private void ShowDifferences_Click(object sender, EventArgs e)
        {
            var summaryForm = new SummaryForm(_mortgage.AdditionalPaymentSummary);
            summaryForm.ShowDialog();
        }

        public List<IInstallment> GetListBasedOnInstallmentType(InstallmentTypes installmentType)
        {
            switch (installmentType)
            {
                case InstallmentTypes.Installment:
                    return new List<IInstallment>(_mortgage.Installments);
                case InstallmentTypes.YearlyInstallment:
                    return new List<IInstallment>(_mortgage.YearlyInstallments);
                case InstallmentTypes.ReplicatedInstallment:
                    return new List<IInstallment>(_mortgage.ReplicatedInstallments);
                case InstallmentTypes.NewInstallments:
                    return new List<IInstallment>(_mortgage.NewInstallments);
                default:
                    return new List<IInstallment>();
            }
        }
    }
}
