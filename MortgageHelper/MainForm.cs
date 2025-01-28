using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MortgageHelper
{
    public partial class MainForm : Form
    {

        private string _filePath;
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

                var installments = Mapper.ToInstallment(filteredLines);
                var yearlyInstallments = Mapper.ToYearlyInstallment(installments);

                installmentsDataGridView.DataSource = installments;
                yearlyInstallmentsDataGridView.DataSource = yearlyInstallments;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

    }
}
