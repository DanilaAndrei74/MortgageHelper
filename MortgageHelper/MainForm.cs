using BussinessLogic;
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
                TextService textFilter = new TextService();
                var pdfText = textFilter.ExtractTextFromPdf(_filePath);

                var filteredLines = textFilter.GetLines(pdfText);

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

                // Show the dialog to the user
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var data = GetListBasedOnSelectedTab();
                        Exporter.ToCSV(data, saveFileDialog.FileName);
                        MessageBox.Show("Data successfully exported to CSV.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Handle any errors during file writing
                        MessageBox.Show($"Error exporting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        public void InitializeTotalBox()
        {
            _summary = CalculateSummary(new List<IInstallment>(_installments));
            UpdateTotals();
            TotalValuesBox.Visible = true;
        }

        public List<Object> GetListBasedOnSelectedTab()
        {
            switch (TabControl.SelectedIndex)
            {
                case ((int)InstallmentTab.Installment):
                    return new List<object>(_installments);
                case (int)InstallmentTab.YearlyInstallment:
                    return new List<object>(_yearlyInstallments);
                default:
                    return null; 
            }
        }
        #endregion

        #region Data

        private IInstallment CalculateSummary(List<IInstallment> installments)
        {
            var summary =  new BaseInstallment
            {
                Principal = Math.Round(installments.Sum(p => p.Principal), 2),
                Interest = Math.Round(installments.Sum(p => p.Interest), 2),
                Insurance = Math.Round(installments.Sum(p => p.Insurance), 2)
            };
            summary.Total = summary.Principal + summary.Total + summary.Interest;

            return summary;
        }
        private void UpdateTotals()
        {
            TotalPrincipalLabel.Text = _summary.Principal.ToString();
            TotalInterestLabel.Text = _summary.Interest.ToString();
            TotalInsuranceLabel.Text = _summary.Insurance.ToString();
            TotalLabel.Text = _summary.Total.ToString();
        }

        #endregion

        public enum InstallmentTab
        {
            Installment,
            YearlyInstallment
        }

    }
}
