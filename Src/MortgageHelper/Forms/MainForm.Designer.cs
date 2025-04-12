using Models.Models;

namespace MortgageHelper
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            selectFileButton = new Button();
            selectFileTextBox = new TextBox();
            GoButton = new Button();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dueDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            principalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            interestDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            insuranceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            creditBalanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ExportButton = new Button();
            groupBox2 = new GroupBox();
            TabelDataGroupbox = new GroupBox();
            TotalValuesBox = new GroupBox();
            TotalLabel = new TextBox();
            TotalInsuranceLabel = new TextBox();
            TotalInterestLabel = new TextBox();
            TotalPrincipalLabel = new TextBox();
            TotalPrincipalLabelText = new Label();
            TotalLabelText = new Label();
            TotalInterestLabelText = new Label();
            TotalInsuranceLabelText = new Label();
            TabControl = new TabControl();
            InstallmentsTab = new TabPage();
            installmentsDataGridView = new DataGridView();
            Month = new DataGridViewTextBoxColumn();
            dueDateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            principalDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            interestDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            insuranceDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            interestRateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cAGRDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            creditBalanceDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            installmentBindingSource = new BindingSource(components);
            YearlyInstallmentsTab = new TabPage();
            yearlyInstallmentsDataGridView = new DataGridView();
            Year = new DataGridViewTextBoxColumn();
            dueDateDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            principalDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            interestDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            insuranceDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            interestRateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            cAGRDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            creditBalanceDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            yearlyInstallmentBindingSource = new BindingSource(components);
            replicatedInstallments = new TabPage();
            replicatedInstallmentsDataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            NewInstallments = new TabPage();
            newInstallmentsDataGridView = new DataGridView();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            EstimatedPerformanceTab = new TabPage();
            estimatedPerformanceDataGridView = new DataGridView();
            estimatedPerformanceBindingSource = new BindingSource(components);
            bankComboBox = new ComboBox();
            groupBox3 = new GroupBox();
            additionalPaymentGroupBox = new GroupBox();
            ShowDifferenceButton = new Button();
            additionalPaymentTextBox = new TextBox();
            principalDataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            estimatedReturnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            TabelDataGroupbox.SuspendLayout();
            TotalValuesBox.SuspendLayout();
            TabControl.SuspendLayout();
            InstallmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)installmentsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)installmentBindingSource).BeginInit();
            YearlyInstallmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yearlyInstallmentsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yearlyInstallmentBindingSource).BeginInit();
            replicatedInstallments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)replicatedInstallmentsDataGridView).BeginInit();
            NewInstallments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)newInstallmentsDataGridView).BeginInit();
            EstimatedPerformanceTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)estimatedPerformanceDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)estimatedPerformanceBindingSource).BeginInit();
            groupBox3.SuspendLayout();
            additionalPaymentGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(selectFileButton);
            groupBox1.Controls.Add(selectFileTextBox);
            groupBox1.Location = new Point(15, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 46);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select PDF to convert:";
            // 
            // selectFileButton
            // 
            selectFileButton.Dock = DockStyle.Right;
            selectFileButton.Location = new Point(288, 19);
            selectFileButton.Name = "selectFileButton";
            selectFileButton.Size = new Size(72, 24);
            selectFileButton.TabIndex = 1;
            selectFileButton.Text = "Select";
            selectFileButton.UseVisualStyleBackColor = true;
            selectFileButton.Click += SelectFileButton_Click;
            // 
            // selectFileTextBox
            // 
            selectFileTextBox.Dock = DockStyle.Left;
            selectFileTextBox.Location = new Point(3, 19);
            selectFileTextBox.Name = "selectFileTextBox";
            selectFileTextBox.Size = new Size(282, 23);
            selectFileTextBox.TabIndex = 0;
            // 
            // GoButton
            // 
            GoButton.Location = new Point(6, 18);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(75, 23);
            GoButton.TabIndex = 2;
            GoButton.Text = "Go";
            GoButton.UseVisualStyleBackColor = true;
            GoButton.Click += GoButton_Click;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            dueDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            dueDateDataGridViewTextBoxColumn.ReadOnly = true;
            dueDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // principalDataGridViewTextBoxColumn
            // 
            principalDataGridViewTextBoxColumn.DataPropertyName = "Principal";
            principalDataGridViewTextBoxColumn.HeaderText = "Principal";
            principalDataGridViewTextBoxColumn.MinimumWidth = 6;
            principalDataGridViewTextBoxColumn.Name = "principalDataGridViewTextBoxColumn";
            principalDataGridViewTextBoxColumn.ReadOnly = true;
            principalDataGridViewTextBoxColumn.Width = 125;
            // 
            // interestDataGridViewTextBoxColumn
            // 
            interestDataGridViewTextBoxColumn.DataPropertyName = "Interest";
            interestDataGridViewTextBoxColumn.HeaderText = "Interest";
            interestDataGridViewTextBoxColumn.MinimumWidth = 6;
            interestDataGridViewTextBoxColumn.Name = "interestDataGridViewTextBoxColumn";
            interestDataGridViewTextBoxColumn.ReadOnly = true;
            interestDataGridViewTextBoxColumn.Width = 125;
            // 
            // insuranceDataGridViewTextBoxColumn
            // 
            insuranceDataGridViewTextBoxColumn.DataPropertyName = "Insurance";
            insuranceDataGridViewTextBoxColumn.HeaderText = "Insurance";
            insuranceDataGridViewTextBoxColumn.MinimumWidth = 6;
            insuranceDataGridViewTextBoxColumn.Name = "insuranceDataGridViewTextBoxColumn";
            insuranceDataGridViewTextBoxColumn.ReadOnly = true;
            insuranceDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            totalDataGridViewTextBoxColumn.HeaderText = "Total";
            totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            totalDataGridViewTextBoxColumn.ReadOnly = true;
            totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // creditBalanceDataGridViewTextBoxColumn
            // 
            creditBalanceDataGridViewTextBoxColumn.DataPropertyName = "CreditBalance";
            creditBalanceDataGridViewTextBoxColumn.HeaderText = "CreditBalance";
            creditBalanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            creditBalanceDataGridViewTextBoxColumn.Name = "creditBalanceDataGridViewTextBoxColumn";
            creditBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            creditBalanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // ExportButton
            // 
            ExportButton.Location = new Point(87, 17);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(92, 23);
            ExportButton.TabIndex = 4;
            ExportButton.Text = "Export To CSV";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ExportButton);
            groupBox2.Controls.Add(GoButton);
            groupBox2.Location = new Point(525, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(191, 46);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Actions";
            // 
            // TabelDataGroupbox
            // 
            TabelDataGroupbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabelDataGroupbox.Controls.Add(TotalValuesBox);
            TabelDataGroupbox.Controls.Add(TabControl);
            TabelDataGroupbox.Location = new Point(18, 122);
            TabelDataGroupbox.Margin = new Padding(3, 2, 3, 2);
            TabelDataGroupbox.Name = "TabelDataGroupbox";
            TabelDataGroupbox.Padding = new Padding(3, 2, 3, 2);
            TabelDataGroupbox.Size = new Size(956, 607);
            TabelDataGroupbox.TabIndex = 6;
            TabelDataGroupbox.TabStop = false;
            // 
            // TotalValuesBox
            // 
            TotalValuesBox.Anchor = AnchorStyles.Bottom;
            TotalValuesBox.Controls.Add(TotalLabel);
            TotalValuesBox.Controls.Add(TotalInsuranceLabel);
            TotalValuesBox.Controls.Add(TotalInterestLabel);
            TotalValuesBox.Controls.Add(TotalPrincipalLabel);
            TotalValuesBox.Controls.Add(TotalPrincipalLabelText);
            TotalValuesBox.Controls.Add(TotalLabelText);
            TotalValuesBox.Controls.Add(TotalInterestLabelText);
            TotalValuesBox.Controls.Add(TotalInsuranceLabelText);
            TotalValuesBox.Location = new Point(43, 551);
            TotalValuesBox.Margin = new Padding(3, 2, 3, 2);
            TotalValuesBox.Name = "TotalValuesBox";
            TotalValuesBox.Padding = new Padding(3, 2, 3, 2);
            TotalValuesBox.Size = new Size(870, 52);
            TotalValuesBox.TabIndex = 11;
            TotalValuesBox.TabStop = false;
            TotalValuesBox.Visible = false;
            // 
            // TotalLabel
            // 
            TotalLabel.Location = new Point(737, 14);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.ReadOnly = true;
            TotalLabel.Size = new Size(100, 23);
            TotalLabel.TabIndex = 14;
            // 
            // TotalInsuranceLabel
            // 
            TotalInsuranceLabel.Location = new Point(519, 14);
            TotalInsuranceLabel.Name = "TotalInsuranceLabel";
            TotalInsuranceLabel.ReadOnly = true;
            TotalInsuranceLabel.Size = new Size(100, 23);
            TotalInsuranceLabel.TabIndex = 13;
            // 
            // TotalInterestLabel
            // 
            TotalInterestLabel.Location = new Point(269, 14);
            TotalInterestLabel.Name = "TotalInterestLabel";
            TotalInterestLabel.ReadOnly = true;
            TotalInterestLabel.Size = new Size(100, 23);
            TotalInterestLabel.TabIndex = 12;
            // 
            // TotalPrincipalLabel
            // 
            TotalPrincipalLabel.Location = new Point(76, 14);
            TotalPrincipalLabel.Name = "TotalPrincipalLabel";
            TotalPrincipalLabel.ReadOnly = true;
            TotalPrincipalLabel.Size = new Size(100, 23);
            TotalPrincipalLabel.TabIndex = 11;
            // 
            // TotalPrincipalLabelText
            // 
            TotalPrincipalLabelText.AutoSize = true;
            TotalPrincipalLabelText.Location = new Point(14, 17);
            TotalPrincipalLabelText.Name = "TotalPrincipalLabelText";
            TotalPrincipalLabelText.Size = new Size(56, 15);
            TotalPrincipalLabelText.TabIndex = 4;
            TotalPrincipalLabelText.Text = "Principal:";
            // 
            // TotalLabelText
            // 
            TotalLabelText.AutoSize = true;
            TotalLabelText.Location = new Point(696, 17);
            TotalLabelText.Name = "TotalLabelText";
            TotalLabelText.Size = new Size(35, 15);
            TotalLabelText.TabIndex = 5;
            TotalLabelText.Text = "Total:";
            // 
            // TotalInterestLabelText
            // 
            TotalInterestLabelText.AutoSize = true;
            TotalInterestLabelText.Location = new Point(217, 17);
            TotalInterestLabelText.Name = "TotalInterestLabelText";
            TotalInterestLabelText.Size = new Size(49, 15);
            TotalInterestLabelText.TabIndex = 6;
            TotalInterestLabelText.Text = "Interest:";
            // 
            // TotalInsuranceLabelText
            // 
            TotalInsuranceLabelText.AutoSize = true;
            TotalInsuranceLabelText.Location = new Point(452, 17);
            TotalInsuranceLabelText.Name = "TotalInsuranceLabelText";
            TotalInsuranceLabelText.Size = new Size(61, 15);
            TotalInsuranceLabelText.TabIndex = 8;
            TotalInsuranceLabelText.Text = "Insurance:";
            // 
            // TabControl
            // 
            TabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl.Controls.Add(InstallmentsTab);
            TabControl.Controls.Add(YearlyInstallmentsTab);
            TabControl.Controls.Add(replicatedInstallments);
            TabControl.Controls.Add(NewInstallments);
            TabControl.Controls.Add(EstimatedPerformanceTab);
            TabControl.Location = new Point(5, 20);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(946, 534);
            TabControl.TabIndex = 3;
            TabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // InstallmentsTab
            // 
            InstallmentsTab.Controls.Add(installmentsDataGridView);
            InstallmentsTab.Location = new Point(4, 24);
            InstallmentsTab.Name = "InstallmentsTab";
            InstallmentsTab.Padding = new Padding(3);
            InstallmentsTab.Size = new Size(938, 506);
            InstallmentsTab.TabIndex = 0;
            InstallmentsTab.Text = "Installments";
            InstallmentsTab.UseVisualStyleBackColor = true;
            // 
            // installmentsDataGridView
            // 
            installmentsDataGridView.AllowUserToAddRows = false;
            installmentsDataGridView.AllowUserToDeleteRows = false;
            installmentsDataGridView.AutoGenerateColumns = false;
            installmentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            installmentsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            installmentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            installmentsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Month, dueDateDataGridViewTextBoxColumn1, principalDataGridViewTextBoxColumn1, interestDataGridViewTextBoxColumn1, insuranceDataGridViewTextBoxColumn1, totalDataGridViewTextBoxColumn1, interestRateDataGridViewTextBoxColumn, cAGRDataGridViewTextBoxColumn, creditBalanceDataGridViewTextBoxColumn1 });
            installmentsDataGridView.DataSource = installmentBindingSource;
            installmentsDataGridView.Dock = DockStyle.Fill;
            installmentsDataGridView.Location = new Point(3, 3);
            installmentsDataGridView.Name = "installmentsDataGridView";
            installmentsDataGridView.ReadOnly = true;
            installmentsDataGridView.RowHeadersWidth = 51;
            installmentsDataGridView.Size = new Size(932, 500);
            installmentsDataGridView.TabIndex = 0;
            // 
            // Month
            // 
            Month.DataPropertyName = "Id";
            Month.HeaderText = "Month";
            Month.Name = "Month";
            Month.ReadOnly = true;
            // 
            // dueDateDataGridViewTextBoxColumn1
            // 
            dueDateDataGridViewTextBoxColumn1.DataPropertyName = "DueDate";
            dueDateDataGridViewTextBoxColumn1.HeaderText = "DueDate";
            dueDateDataGridViewTextBoxColumn1.Name = "dueDateDataGridViewTextBoxColumn1";
            dueDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // principalDataGridViewTextBoxColumn1
            // 
            principalDataGridViewTextBoxColumn1.DataPropertyName = "Principal";
            principalDataGridViewTextBoxColumn1.HeaderText = "Principal";
            principalDataGridViewTextBoxColumn1.Name = "principalDataGridViewTextBoxColumn1";
            principalDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // interestDataGridViewTextBoxColumn1
            // 
            interestDataGridViewTextBoxColumn1.DataPropertyName = "Interest";
            interestDataGridViewTextBoxColumn1.HeaderText = "Interest";
            interestDataGridViewTextBoxColumn1.Name = "interestDataGridViewTextBoxColumn1";
            interestDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // insuranceDataGridViewTextBoxColumn1
            // 
            insuranceDataGridViewTextBoxColumn1.DataPropertyName = "Insurance";
            insuranceDataGridViewTextBoxColumn1.HeaderText = "Insurance";
            insuranceDataGridViewTextBoxColumn1.Name = "insuranceDataGridViewTextBoxColumn1";
            insuranceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn1
            // 
            totalDataGridViewTextBoxColumn1.DataPropertyName = "Total";
            totalDataGridViewTextBoxColumn1.HeaderText = "Total";
            totalDataGridViewTextBoxColumn1.Name = "totalDataGridViewTextBoxColumn1";
            totalDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // interestRateDataGridViewTextBoxColumn
            // 
            interestRateDataGridViewTextBoxColumn.DataPropertyName = "InterestRate";
            interestRateDataGridViewTextBoxColumn.HeaderText = "Interest Rate";
            interestRateDataGridViewTextBoxColumn.Name = "interestRateDataGridViewTextBoxColumn";
            interestRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cAGRDataGridViewTextBoxColumn
            // 
            cAGRDataGridViewTextBoxColumn.DataPropertyName = "CAGR";
            cAGRDataGridViewTextBoxColumn.HeaderText = "CAGR";
            cAGRDataGridViewTextBoxColumn.Name = "cAGRDataGridViewTextBoxColumn";
            cAGRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creditBalanceDataGridViewTextBoxColumn1
            // 
            creditBalanceDataGridViewTextBoxColumn1.DataPropertyName = "CreditBalance";
            creditBalanceDataGridViewTextBoxColumn1.HeaderText = "CreditBalance";
            creditBalanceDataGridViewTextBoxColumn1.Name = "creditBalanceDataGridViewTextBoxColumn1";
            creditBalanceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // installmentBindingSource
            // 
            installmentBindingSource.DataSource = typeof(Installment);
            // 
            // YearlyInstallmentsTab
            // 
            YearlyInstallmentsTab.Controls.Add(yearlyInstallmentsDataGridView);
            YearlyInstallmentsTab.Location = new Point(4, 24);
            YearlyInstallmentsTab.Name = "YearlyInstallmentsTab";
            YearlyInstallmentsTab.Padding = new Padding(3);
            YearlyInstallmentsTab.Size = new Size(938, 506);
            YearlyInstallmentsTab.TabIndex = 1;
            YearlyInstallmentsTab.Text = "Yearly Installments";
            YearlyInstallmentsTab.UseVisualStyleBackColor = true;
            // 
            // yearlyInstallmentsDataGridView
            // 
            yearlyInstallmentsDataGridView.AllowUserToAddRows = false;
            yearlyInstallmentsDataGridView.AllowUserToDeleteRows = false;
            yearlyInstallmentsDataGridView.AutoGenerateColumns = false;
            yearlyInstallmentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            yearlyInstallmentsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            yearlyInstallmentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            yearlyInstallmentsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Year, dueDateDataGridViewTextBoxColumn2, principalDataGridViewTextBoxColumn2, interestDataGridViewTextBoxColumn2, insuranceDataGridViewTextBoxColumn2, totalDataGridViewTextBoxColumn2, interestRateDataGridViewTextBoxColumn1, cAGRDataGridViewTextBoxColumn1, creditBalanceDataGridViewTextBoxColumn2 });
            yearlyInstallmentsDataGridView.DataSource = yearlyInstallmentBindingSource;
            yearlyInstallmentsDataGridView.Dock = DockStyle.Fill;
            yearlyInstallmentsDataGridView.Location = new Point(3, 3);
            yearlyInstallmentsDataGridView.Name = "yearlyInstallmentsDataGridView";
            yearlyInstallmentsDataGridView.ReadOnly = true;
            yearlyInstallmentsDataGridView.RowHeadersWidth = 51;
            yearlyInstallmentsDataGridView.Size = new Size(932, 500);
            yearlyInstallmentsDataGridView.TabIndex = 0;
            // 
            // Year
            // 
            Year.DataPropertyName = "Id";
            Year.HeaderText = "Year";
            Year.Name = "Year";
            Year.ReadOnly = true;
            // 
            // dueDateDataGridViewTextBoxColumn2
            // 
            dueDateDataGridViewTextBoxColumn2.DataPropertyName = "DueDate";
            dueDateDataGridViewTextBoxColumn2.HeaderText = "DueDate";
            dueDateDataGridViewTextBoxColumn2.Name = "dueDateDataGridViewTextBoxColumn2";
            dueDateDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // principalDataGridViewTextBoxColumn2
            // 
            principalDataGridViewTextBoxColumn2.DataPropertyName = "Principal";
            principalDataGridViewTextBoxColumn2.HeaderText = "Principal";
            principalDataGridViewTextBoxColumn2.Name = "principalDataGridViewTextBoxColumn2";
            principalDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // interestDataGridViewTextBoxColumn2
            // 
            interestDataGridViewTextBoxColumn2.DataPropertyName = "Interest";
            interestDataGridViewTextBoxColumn2.HeaderText = "Interest";
            interestDataGridViewTextBoxColumn2.Name = "interestDataGridViewTextBoxColumn2";
            interestDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // insuranceDataGridViewTextBoxColumn2
            // 
            insuranceDataGridViewTextBoxColumn2.DataPropertyName = "Insurance";
            insuranceDataGridViewTextBoxColumn2.HeaderText = "Insurance";
            insuranceDataGridViewTextBoxColumn2.Name = "insuranceDataGridViewTextBoxColumn2";
            insuranceDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn2
            // 
            totalDataGridViewTextBoxColumn2.DataPropertyName = "Total";
            totalDataGridViewTextBoxColumn2.HeaderText = "Total";
            totalDataGridViewTextBoxColumn2.Name = "totalDataGridViewTextBoxColumn2";
            totalDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // interestRateDataGridViewTextBoxColumn1
            // 
            interestRateDataGridViewTextBoxColumn1.DataPropertyName = "InterestRate";
            interestRateDataGridViewTextBoxColumn1.HeaderText = "Interest Rate";
            interestRateDataGridViewTextBoxColumn1.Name = "interestRateDataGridViewTextBoxColumn1";
            interestRateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cAGRDataGridViewTextBoxColumn1
            // 
            cAGRDataGridViewTextBoxColumn1.DataPropertyName = "CAGR";
            cAGRDataGridViewTextBoxColumn1.HeaderText = "CAGR";
            cAGRDataGridViewTextBoxColumn1.Name = "cAGRDataGridViewTextBoxColumn1";
            cAGRDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // creditBalanceDataGridViewTextBoxColumn2
            // 
            creditBalanceDataGridViewTextBoxColumn2.DataPropertyName = "CreditBalance";
            creditBalanceDataGridViewTextBoxColumn2.HeaderText = "CreditBalance";
            creditBalanceDataGridViewTextBoxColumn2.Name = "creditBalanceDataGridViewTextBoxColumn2";
            creditBalanceDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // yearlyInstallmentBindingSource
            // 
            yearlyInstallmentBindingSource.DataSource = typeof(YearlyInstallment);
            // 
            // replicatedInstallments
            // 
            replicatedInstallments.Controls.Add(replicatedInstallmentsDataGridView);
            replicatedInstallments.Location = new Point(4, 24);
            replicatedInstallments.Name = "replicatedInstallments";
            replicatedInstallments.Padding = new Padding(3);
            replicatedInstallments.Size = new Size(938, 506);
            replicatedInstallments.TabIndex = 2;
            replicatedInstallments.Text = "ReplicatedInstallments";
            replicatedInstallments.UseVisualStyleBackColor = true;
            // 
            // replicatedInstallmentsDataGridView
            // 
            replicatedInstallmentsDataGridView.AllowUserToAddRows = false;
            replicatedInstallmentsDataGridView.AllowUserToDeleteRows = false;
            replicatedInstallmentsDataGridView.AutoGenerateColumns = false;
            replicatedInstallmentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            replicatedInstallmentsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            replicatedInstallmentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            replicatedInstallmentsDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9 });
            replicatedInstallmentsDataGridView.DataSource = installmentBindingSource;
            replicatedInstallmentsDataGridView.Dock = DockStyle.Fill;
            replicatedInstallmentsDataGridView.Location = new Point(3, 3);
            replicatedInstallmentsDataGridView.Name = "replicatedInstallmentsDataGridView";
            replicatedInstallmentsDataGridView.ReadOnly = true;
            replicatedInstallmentsDataGridView.RowHeadersWidth = 51;
            replicatedInstallmentsDataGridView.Size = new Size(932, 500);
            replicatedInstallmentsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Month";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "DueDate";
            dataGridViewTextBoxColumn2.HeaderText = "DueDate";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Principal";
            dataGridViewTextBoxColumn3.HeaderText = "Principal";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Interest";
            dataGridViewTextBoxColumn4.HeaderText = "Interest";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Insurance";
            dataGridViewTextBoxColumn5.HeaderText = "Insurance";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Total";
            dataGridViewTextBoxColumn6.HeaderText = "Total";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "InterestRate";
            dataGridViewTextBoxColumn7.HeaderText = "Interest Rate";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "CAGR";
            dataGridViewTextBoxColumn8.HeaderText = "CAGR";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "CreditBalance";
            dataGridViewTextBoxColumn9.HeaderText = "CreditBalance";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // NewInstallments
            // 
            NewInstallments.Controls.Add(newInstallmentsDataGridView);
            NewInstallments.Location = new Point(4, 24);
            NewInstallments.Name = "NewInstallments";
            NewInstallments.Padding = new Padding(3);
            NewInstallments.Size = new Size(938, 506);
            NewInstallments.TabIndex = 3;
            NewInstallments.Text = "NewInstallments";
            NewInstallments.UseVisualStyleBackColor = true;
            // 
            // newInstallmentsDataGridView
            // 
            newInstallmentsDataGridView.AllowUserToAddRows = false;
            newInstallmentsDataGridView.AllowUserToDeleteRows = false;
            newInstallmentsDataGridView.AutoGenerateColumns = false;
            newInstallmentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            newInstallmentsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            newInstallmentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            newInstallmentsDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn16, dataGridViewTextBoxColumn17, dataGridViewTextBoxColumn18 });
            newInstallmentsDataGridView.DataSource = installmentBindingSource;
            newInstallmentsDataGridView.Dock = DockStyle.Fill;
            newInstallmentsDataGridView.Location = new Point(3, 3);
            newInstallmentsDataGridView.Name = "newInstallmentsDataGridView";
            newInstallmentsDataGridView.ReadOnly = true;
            newInstallmentsDataGridView.RowHeadersWidth = 51;
            newInstallmentsDataGridView.Size = new Size(932, 500);
            newInstallmentsDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "Id";
            dataGridViewTextBoxColumn10.HeaderText = "Month";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "DueDate";
            dataGridViewTextBoxColumn11.HeaderText = "DueDate";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "Principal";
            dataGridViewTextBoxColumn12.HeaderText = "Principal";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.DataPropertyName = "Interest";
            dataGridViewTextBoxColumn13.HeaderText = "Interest";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.DataPropertyName = "Insurance";
            dataGridViewTextBoxColumn14.HeaderText = "Insurance";
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.DataPropertyName = "Total";
            dataGridViewTextBoxColumn15.HeaderText = "Total";
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.DataPropertyName = "InterestRate";
            dataGridViewTextBoxColumn16.HeaderText = "Interest Rate";
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.DataPropertyName = "CAGR";
            dataGridViewTextBoxColumn17.HeaderText = "CAGR";
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            dataGridViewTextBoxColumn18.DataPropertyName = "CreditBalance";
            dataGridViewTextBoxColumn18.HeaderText = "CreditBalance";
            dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // EstimatedPerformanceTab
            // 
            EstimatedPerformanceTab.Controls.Add(estimatedPerformanceDataGridView);
            EstimatedPerformanceTab.Location = new Point(4, 24);
            EstimatedPerformanceTab.Name = "EstimatedPerformanceTab";
            EstimatedPerformanceTab.Padding = new Padding(3);
            EstimatedPerformanceTab.Size = new Size(938, 506);
            EstimatedPerformanceTab.TabIndex = 4;
            EstimatedPerformanceTab.Text = "EstimatedPerformance";
            EstimatedPerformanceTab.UseVisualStyleBackColor = true;
            // 
            // estimatedPerformanceDataGridView
            // 
            estimatedPerformanceDataGridView.AllowUserToAddRows = false;
            estimatedPerformanceDataGridView.AllowUserToDeleteRows = false;
            estimatedPerformanceDataGridView.AutoGenerateColumns = false;
            estimatedPerformanceDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            estimatedPerformanceDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            estimatedPerformanceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            estimatedPerformanceDataGridView.Columns.AddRange(new DataGridViewColumn[] { principalDataGridViewTextBoxColumn3, estimatedReturnDataGridViewTextBoxColumn });
            estimatedPerformanceDataGridView.DataSource = estimatedPerformanceBindingSource;
            estimatedPerformanceDataGridView.Dock = DockStyle.Fill;
            estimatedPerformanceDataGridView.Location = new Point(3, 3);
            estimatedPerformanceDataGridView.Name = "estimatedPerformanceDataGridView";
            estimatedPerformanceDataGridView.ReadOnly = true;
            estimatedPerformanceDataGridView.RowHeadersWidth = 51;
            estimatedPerformanceDataGridView.Size = new Size(932, 500);
            estimatedPerformanceDataGridView.TabIndex = 3;
            // 
            // estimatedPerformanceBindingSource
            // 
            estimatedPerformanceBindingSource.DataSource = typeof(EstimatedPerformance);
            // 
            // bankComboBox
            // 
            bankComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            bankComboBox.FormattingEnabled = true;
            bankComboBox.Location = new Point(6, 17);
            bankComboBox.Name = "bankComboBox";
            bankComboBox.Size = new Size(121, 23);
            bankComboBox.TabIndex = 7;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(bankComboBox);
            groupBox3.Location = new Point(381, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(138, 46);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Bank";
            // 
            // additionalPaymentGroupBox
            // 
            additionalPaymentGroupBox.Controls.Add(ShowDifferenceButton);
            additionalPaymentGroupBox.Controls.Add(additionalPaymentTextBox);
            additionalPaymentGroupBox.Location = new Point(18, 64);
            additionalPaymentGroupBox.Name = "additionalPaymentGroupBox";
            additionalPaymentGroupBox.Size = new Size(268, 53);
            additionalPaymentGroupBox.TabIndex = 9;
            additionalPaymentGroupBox.TabStop = false;
            additionalPaymentGroupBox.Text = "Additional reinbursment";
            // 
            // ShowDifferenceButton
            // 
            ShowDifferenceButton.Location = new Point(150, 21);
            ShowDifferenceButton.Name = "ShowDifferenceButton";
            ShowDifferenceButton.Size = new Size(112, 23);
            ShowDifferenceButton.TabIndex = 1;
            ShowDifferenceButton.Text = "Show differences";
            ShowDifferenceButton.UseVisualStyleBackColor = true;
            ShowDifferenceButton.Visible = false;
            ShowDifferenceButton.Click += ShowDifferences_Click;
            // 
            // additionalPaymentTextBox
            // 
            additionalPaymentTextBox.Location = new Point(9, 22);
            additionalPaymentTextBox.Name = "additionalPaymentTextBox";
            additionalPaymentTextBox.Size = new Size(135, 23);
            additionalPaymentTextBox.TabIndex = 0;
            additionalPaymentTextBox.KeyPress += additionalPaymentTextBox_KeyPress;
            // 
            // principalDataGridViewTextBoxColumn3
            // 
            principalDataGridViewTextBoxColumn3.DataPropertyName = "Principal";
            principalDataGridViewTextBoxColumn3.HeaderText = "Principal";
            principalDataGridViewTextBoxColumn3.Name = "principalDataGridViewTextBoxColumn3";
            principalDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // estimatedReturnDataGridViewTextBoxColumn
            // 
            estimatedReturnDataGridViewTextBoxColumn.DataPropertyName = "EstimatedReturn";
            estimatedReturnDataGridViewTextBoxColumn.HeaderText = "EstimatedReturn";
            estimatedReturnDataGridViewTextBoxColumn.Name = "estimatedReturnDataGridViewTextBoxColumn";
            estimatedReturnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 738);
            Controls.Add(additionalPaymentGroupBox);
            Controls.Add(groupBox3);
            Controls.Add(TabelDataGroupbox);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            TabelDataGroupbox.ResumeLayout(false);
            TotalValuesBox.ResumeLayout(false);
            TotalValuesBox.PerformLayout();
            TabControl.ResumeLayout(false);
            InstallmentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)installmentsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)installmentBindingSource).EndInit();
            YearlyInstallmentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)yearlyInstallmentsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)yearlyInstallmentBindingSource).EndInit();
            replicatedInstallments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)replicatedInstallmentsDataGridView).EndInit();
            NewInstallments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)newInstallmentsDataGridView).EndInit();
            EstimatedPerformanceTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)estimatedPerformanceDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)estimatedPerformanceBindingSource).EndInit();
            groupBox3.ResumeLayout(false);
            additionalPaymentGroupBox.ResumeLayout(false);
            additionalPaymentGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button selectFileButton;
        private TextBox selectFileTextBox;
        private Button GoButton;
        private GroupBox tableBox;
        private TabControl tabControl1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn principalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn interestDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn insuranceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn creditBalanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private Button ExportButton;
        private GroupBox groupBox2;
        private GroupBox TabelDataGroupbox;
        private Label TotalLabelText;
        private Label TotalInsuranceLabelText;
        private Label TotalInterestLabelText;
        private Label TotalPrincipalLabelText;
        private GroupBox TotalValuesBox;
        private DataGridViewTextBoxColumn yearNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearNumberDataGridViewTextBoxColumn1;
        private TextBox TotalInsuranceLabel;
        private TextBox TotalInterestLabel;
        private TextBox TotalPrincipalLabel;
        private TextBox TotalLabel;
        private ComboBox bankComboBox;
        private GroupBox groupBox3;
        private TabControl TabControl;
        private TabPage InstallmentsTab;
        private DataGridView installmentsDataGridView;
        private TabPage YearlyInstallmentsTab;
        private DataGridView yearlyInstallmentsDataGridView;
        private BindingSource installmentBindingSource;
        private BindingSource yearlyInstallmentBindingSource;
        private DataGridViewTextBoxColumn Month;
        private DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn principalDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn interestDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn insuranceDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn interestRateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cAGRDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn creditBalanceDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn principalDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn interestDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn insuranceDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn interestRateDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cAGRDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn creditBalanceDataGridViewTextBoxColumn2;
        private TabPage replicatedInstallments;
        private DataGridView replicatedInstallmentsDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private TabPage NewInstallments;
        private DataGridView newInstallmentsDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private GroupBox additionalPaymentGroupBox;
        private TextBox additionalPaymentTextBox;
        private Button ShowDifferenceButton;
        private TabPage EstimatedPerformanceTab;
        private DataGridView estimatedPerformanceDataGridView;
        private BindingSource estimatedPerformanceBindingSource;
        private DataGridViewTextBoxColumn principalDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn estimatedReturnDataGridViewTextBoxColumn;
    }
}
