using BussinessLogic;
using MortgageHelper.Models;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MortgageHelper
{
    public partial class MainForm : Form
    {

        private string _filePath;
        private List<Installment> _installments;
        private List<YearlyInstallment> _yearlyInstallments;
        public MainForm()
        {
            InitializeComponent();
        }

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
                        Exporter.ToCSV(_yearlyInstallments, saveFileDialog.FileName);
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
    }
}
