using BussinessLogic;
using Models.Enums;
using Models.Interfaces;
using Models.Models;
using MortgageHelper.Models;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
        private List<YearlyInstallment> _yearlyInstallments;
        private IInstallment _summary;
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
                var filteredLines = PdfService.ExtractLinesFromBankPdf(_filePath, (Banks)bankComboBox.SelectedValue);

                _installments = Mapper.ToInstallment(filteredLines);
                _yearlyInstallments = Mapper.ToYearlyInstallment(_installments);

                installmentsDataGridView.DataSource = _installments;
                yearlyInstallmentsDataGridView.DataSource = _yearlyInstallments;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            InitializeTotalBox();
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
            _summary = CalculatorService.CalculateSummary(new List<IInstallment>(_installments));
            UpdateTotals();
            TotalValuesBox.Visible = true;
        }

        private void UpdateTotals()
        {
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
                default:
                    return null;
            }
        }

        #endregion

    }
}
