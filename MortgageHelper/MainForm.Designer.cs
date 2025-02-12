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
            YearlyInstallmentsTab = new TabPage();
            yearlyInstallmentsDataGridView = new DataGridView();
            Year = new DataGridViewTextBoxColumn();
            dueDateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            principalDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            interestDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            insuranceDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            cAGRDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            creditBalanceDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            installmentBindingSource = new BindingSource(components);
            yearlyInstallmentBindingSource = new BindingSource(components);
            InstallmentsTab = new TabPage();
            installmentsDataGridView = new DataGridView();
            Month = new DataGridViewTextBoxColumn();
            dueDateDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            principalDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            interestDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            insuranceDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            cAGRDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            creditBalanceDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            TabControl = new TabControl();
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
            bankComboBox = new ComboBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            YearlyInstallmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yearlyInstallmentsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)installmentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yearlyInstallmentBindingSource).BeginInit();
            InstallmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)installmentsDataGridView).BeginInit();
            TabControl.SuspendLayout();
            groupBox2.SuspendLayout();
            TabelDataGroupbox.SuspendLayout();
            TotalValuesBox.SuspendLayout();
            groupBox3.SuspendLayout();
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
            // YearlyInstallmentsTab
            // 
            YearlyInstallmentsTab.Controls.Add(yearlyInstallmentsDataGridView);
            YearlyInstallmentsTab.Location = new Point(4, 24);
            YearlyInstallmentsTab.Name = "YearlyInstallmentsTab";
            YearlyInstallmentsTab.Padding = new Padding(3);
            YearlyInstallmentsTab.Size = new Size(829, 393);
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
            yearlyInstallmentsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Year, dueDateDataGridViewTextBoxColumn1, principalDataGridViewTextBoxColumn1, interestDataGridViewTextBoxColumn1, insuranceDataGridViewTextBoxColumn1, totalDataGridViewTextBoxColumn1, cAGRDataGridViewTextBoxColumn, creditBalanceDataGridViewTextBoxColumn1 });
            yearlyInstallmentsDataGridView.DataSource = installmentBindingSource;
            yearlyInstallmentsDataGridView.Dock = DockStyle.Fill;
            yearlyInstallmentsDataGridView.Location = new Point(3, 3);
            yearlyInstallmentsDataGridView.Name = "yearlyInstallmentsDataGridView";
            yearlyInstallmentsDataGridView.ReadOnly = true;
            yearlyInstallmentsDataGridView.RowHeadersWidth = 51;
            yearlyInstallmentsDataGridView.Size = new Size(823, 387);
            yearlyInstallmentsDataGridView.TabIndex = 0;
            // 
            // Year
            // 
            Year.DataPropertyName = "Id";
            Year.HeaderText = "Year";
            Year.Name = "Year";
            Year.ReadOnly = true;
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
            installmentBindingSource.DataSource = typeof(Models.Installment);
            // 
            // yearlyInstallmentBindingSource
            // 
            yearlyInstallmentBindingSource.DataSource = typeof(Models.YearlyInstallment);
            // 
            // InstallmentsTab
            // 
            InstallmentsTab.Controls.Add(installmentsDataGridView);
            InstallmentsTab.Location = new Point(4, 24);
            InstallmentsTab.Name = "InstallmentsTab";
            InstallmentsTab.Padding = new Padding(3);
            InstallmentsTab.Size = new Size(829, 393);
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
            installmentsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Month, dueDateDataGridViewTextBoxColumn2, principalDataGridViewTextBoxColumn2, interestDataGridViewTextBoxColumn2, insuranceDataGridViewTextBoxColumn2, totalDataGridViewTextBoxColumn2, cAGRDataGridViewTextBoxColumn1, creditBalanceDataGridViewTextBoxColumn2 });
            installmentsDataGridView.DataSource = installmentBindingSource;
            installmentsDataGridView.Dock = DockStyle.Fill;
            installmentsDataGridView.Location = new Point(3, 3);
            installmentsDataGridView.Name = "installmentsDataGridView";
            installmentsDataGridView.ReadOnly = true;
            installmentsDataGridView.RowHeadersWidth = 51;
            installmentsDataGridView.Size = new Size(823, 387);
            installmentsDataGridView.TabIndex = 0;
            // 
            // Month
            // 
            Month.DataPropertyName = "Id";
            Month.HeaderText = "Month";
            Month.Name = "Month";
            Month.ReadOnly = true;
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
            // TabControl
            // 
            TabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl.Controls.Add(InstallmentsTab);
            TabControl.Controls.Add(YearlyInstallmentsTab);
            TabControl.Location = new Point(5, 20);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(837, 421);
            TabControl.TabIndex = 3;
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
            TabelDataGroupbox.Location = new Point(18, 63);
            TabelDataGroupbox.Margin = new Padding(3, 2, 3, 2);
            TabelDataGroupbox.Name = "TabelDataGroupbox";
            TabelDataGroupbox.Padding = new Padding(3, 2, 3, 2);
            TabelDataGroupbox.Size = new Size(847, 494);
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
            TotalValuesBox.Location = new Point(-12, 438);
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 566);
            Controls.Add(groupBox3);
            Controls.Add(TabelDataGroupbox);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            YearlyInstallmentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)yearlyInstallmentsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)installmentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)yearlyInstallmentBindingSource).EndInit();
            InstallmentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)installmentsDataGridView).EndInit();
            TabControl.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            TabelDataGroupbox.ResumeLayout(false);
            TotalValuesBox.ResumeLayout(false);
            TotalValuesBox.PerformLayout();
            groupBox3.ResumeLayout(false);
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
        private TabPage YearlyInstallmentsTab;
        private TabPage InstallmentsTab;
        private DataGridView installmentsDataGridView;
        private TabControl TabControl;
        private DataGridView yearlyInstallmentsDataGridView;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private Button ExportButton;
        private GroupBox groupBox2;
        private GroupBox TabelDataGroupbox;
        private Label TotalLabelText;
        private Label TotalInsuranceLabelText;
        private Label TotalInterestLabelText;
        private Label TotalPrincipalLabelText;
        private GroupBox TotalValuesBox;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn yearNumberDataGridViewTextBoxColumn;
        private BindingSource yearlyInstallmentBindingSource;
        private DataGridViewTextBoxColumn yearNumberDataGridViewTextBoxColumn1;
        private BindingSource installmentBindingSource;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn principalDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn interestDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn insuranceDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cAGRDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn creditBalanceDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Month;
        private DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn principalDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn interestDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn insuranceDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn cAGRDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn creditBalanceDataGridViewTextBoxColumn2;
        private TextBox TotalInsuranceLabel;
        private TextBox TotalInterestLabel;
        private TextBox TotalPrincipalLabel;
        private TextBox TotalLabel;
        private ComboBox bankComboBox;
        private GroupBox groupBox3;
    }
}
