using BusinessLogic;
using BusinessLogic.BankFactories;
using BusinessLogic;
using Models.Enums;
using Models.Interfaces;
using MortgageHelper.Models;

namespace MortgageHelper
{
    public partial class MainForm : Form
    {

        private string _filePath;
        private double _totalPrincipal;
        private double _totalInterest;
        private double _totalInsurance;
        private double _totalTotal;
        private List<Installment> _installments;
        private List<Installment> _replicatedInstallments;
        private List<Installment> _newInstallments;
        private List<YearlyInstallment> _yearlyInstallments;
        private IInstallment _summary;

        private IInstallment _newSummary;
        private IInstallment _oldSummary;
        private int _oldMonths;
        private int _newMonths;
        public MainForm()
        {
            InitializeComponent();
            bankComboBox.DataSource = Enum.GetValues(typeof(Banks));
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
                _installments = BankFactory
                    .GetExtractor((Banks)bankComboBox.SelectedValue)
                    .ExtractInstallments(_filePath);
                Insurance.SetPercentageByBank((Banks)bankComboBox.SelectedValue);

                _yearlyInstallments = Mapper.ToYearlyInstallment(_installments);

                double extraordinaryPayment = RetreiveAdditionalPaymentFromTextBox();
                var creditBalance = _installments.First().CreditBalance + _installments.First().Principal;


                InterestRates.fixedRatePeriod = CalculatorService.DetermineFixedPaymentPeriod(new List<IInstallment>(_installments));
                var fixedRateInstallments = _installments.Take(InterestRates.fixedRatePeriod).ToList();
                var variableRateInstallments = _installments.Skip(InterestRates.fixedRatePeriod).ToList();
                InterestRates.fixedRate = fixedRateInstallments[fixedRateInstallments.Count() / 2].InterestRate;
                if (variableRateInstallments.Count() > 0) InterestRates.variableRate = variableRateInstallments[variableRateInstallments.Count() / 2].InterestRate;


                _oldMonths = _installments.Count();
                _newMonths = CalculatorService.GetNewMonthsAfterExtraordinaryPayment(
                                        creditBalance,
                                        InterestRates.fixedRate,
                                        _installments.Count(),
                                        extraordinaryPayment);


                _replicatedInstallments = Mapper.ReplicateInstallments(_installments);
                _newInstallments = Mapper.CalculateInstallmentPlan(
                    creditBalance - extraordinaryPayment,
                    _newMonths);

                _oldSummary = CalculatorService.CalculateSummary(new List<IInstallment>(_installments));
                _newSummary = CalculatorService.CalculateSummary(new List<IInstallment>(_newInstallments));

                ShowDifferenceButton.Visible = true;

                List<(double additionalPayment, double annualizedReturn)> result = CalculatorService.CalculateOptimalPayment(_oldSummary, _oldMonths);

                newInstallmentsDataGridView.DataSource = _newInstallments;
                replicatedInstallmentsDataGridView.DataSource = _replicatedInstallments;
                installmentsDataGridView.DataSource = _installments;
                yearlyInstallmentsDataGridView.DataSource = _yearlyInstallments;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            InitializeTotalBox();
        }


        private double RetreiveAdditionalPaymentFromTextBox()
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
                        var data = GetListBasedOnInstallmentType();
                        Exporter.ToCSV(data, saveFileDialog.FileName);
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
            _summary = CalculatorService.CalculateSummary(GetListBasedOnInstallmentType());
            TotalPrincipalLabel.Text = _summary.Principal.ToString();
            TotalInterestLabel.Text = _summary.Interest.ToString();
            TotalInsuranceLabel.Text = _summary.Insurance.ToString();
            TotalLabel.Text = _summary.Total.ToString();
        }

        public List<IInstallment> GetListBasedOnInstallmentType()
        {
            switch (TabControl.SelectedIndex)
            {
                case (int)InstallmentTypes.Installment:
                    return new List<IInstallment>(_installments);
                case (int)InstallmentTypes.YearlyInstallment:
                    return new List<IInstallment>(_yearlyInstallments);
                case (int)InstallmentTypes.ReplicatedInstallment:
                    return new List<IInstallment>(_replicatedInstallments);
                case (int)InstallmentTypes.NewInstallments:
                    return new List<IInstallment>(_newInstallments);
                default:
                    return null;
            }
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
            var installmentDifference = Mapper.MapToInstallmentDifference(_oldSummary, _newSummary, _oldMonths, _newMonths);
            var summaryForm = new SummaryForm(installmentDifference);
            summaryForm.ShowDialog();
        }
    }
}
