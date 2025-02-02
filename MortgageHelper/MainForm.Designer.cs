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
            installmentBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dueDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            principalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            interestDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            insuranceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            creditBalanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yearlyInstallmentsBindingSource = new BindingSource(components);
            YearlyInstallmentsTab = new TabPage();
            yearlyInstallmentsDataGridView = new DataGridView();
            idDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dueDateDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            principalDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            interestDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            insuranceDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            creditBalanceDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            cAGRDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            InstallmentsTab = new TabPage();
            installmentsDataGridView = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dueDateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            principalDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            interestDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            insuranceDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            creditBalanceDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            TabControl = new TabControl();
            ExportButton = new Button();
            groupBox2 = new GroupBox();
            TabelDataGroupbox = new GroupBox();
            TotalValuesBox = new GroupBox();
            TotalPrincipalLabelText = new Label();
            TotalLabel = new Label();
            TotalPrincipalLabel = new Label();
            TotalLabelText = new Label();
            TotalInterestLabelText = new Label();
            TotalInsuranceLabel = new Label();
            TotalInterestLabel = new Label();
            TotalInsuranceLabelText = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)installmentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yearlyInstallmentsBindingSource).BeginInit();
            YearlyInstallmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yearlyInstallmentsDataGridView).BeginInit();
            InstallmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)installmentsDataGridView).BeginInit();
            TabControl.SuspendLayout();
            groupBox2.SuspendLayout();
            TabelDataGroupbox.SuspendLayout();
            TotalValuesBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(selectFileButton);
            groupBox1.Controls.Add(selectFileTextBox);
            groupBox1.Location = new Point(17, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(415, 61);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select PDF to convert:";
            // 
            // selectFileButton
            // 
            selectFileButton.Dock = DockStyle.Right;
            selectFileButton.Location = new Point(330, 24);
            selectFileButton.Margin = new Padding(3, 4, 3, 4);
            selectFileButton.Name = "selectFileButton";
            selectFileButton.Size = new Size(82, 33);
            selectFileButton.TabIndex = 1;
            selectFileButton.Text = "Select";
            selectFileButton.UseVisualStyleBackColor = true;
            selectFileButton.Click += SelectFileButton_Click;
            // 
            // selectFileTextBox
            // 
            selectFileTextBox.Dock = DockStyle.Left;
            selectFileTextBox.Location = new Point(3, 24);
            selectFileTextBox.Margin = new Padding(3, 4, 3, 4);
            selectFileTextBox.Name = "selectFileTextBox";
            selectFileTextBox.Size = new Size(322, 27);
            selectFileTextBox.TabIndex = 0;
            // 
            // GoButton
            // 
            GoButton.Location = new Point(7, 24);
            GoButton.Margin = new Padding(3, 4, 3, 4);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(86, 31);
            GoButton.TabIndex = 2;
            GoButton.Text = "Go";
            GoButton.UseVisualStyleBackColor = true;
            GoButton.Click += GoButton_Click;
            // 
            // installmentBindingSource
            // 
            installmentBindingSource.AllowNew = false;
            installmentBindingSource.DataSource = typeof(Models.Installment);
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
            // yearlyInstallmentsBindingSource
            // 
            yearlyInstallmentsBindingSource.DataSource = typeof(Models.YearlyInstallment);
            // 
            // YearlyInstallmentsTab
            // 
            YearlyInstallmentsTab.Controls.Add(yearlyInstallmentsDataGridView);
            YearlyInstallmentsTab.Location = new Point(4, 29);
            YearlyInstallmentsTab.Margin = new Padding(3, 4, 3, 4);
            YearlyInstallmentsTab.Name = "YearlyInstallmentsTab";
            YearlyInstallmentsTab.Padding = new Padding(3, 4, 3, 4);
            YearlyInstallmentsTab.Size = new Size(1000, 509);
            YearlyInstallmentsTab.TabIndex = 1;
            YearlyInstallmentsTab.Text = "Yearly Installments";
            YearlyInstallmentsTab.UseVisualStyleBackColor = true;
            // 
            // yearlyInstallmentsDataGridView
            // 
            yearlyInstallmentsDataGridView.AllowUserToAddRows = false;
            yearlyInstallmentsDataGridView.AllowUserToDeleteRows = false;
            yearlyInstallmentsDataGridView.AutoGenerateColumns = false;
            yearlyInstallmentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            yearlyInstallmentsDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn2, dueDateDataGridViewTextBoxColumn2, principalDataGridViewTextBoxColumn2, interestDataGridViewTextBoxColumn2, insuranceDataGridViewTextBoxColumn2, totalDataGridViewTextBoxColumn2, creditBalanceDataGridViewTextBoxColumn2, cAGRDataGridViewTextBoxColumn });
            yearlyInstallmentsDataGridView.DataSource = yearlyInstallmentsBindingSource;
            yearlyInstallmentsDataGridView.Dock = DockStyle.Fill;
            yearlyInstallmentsDataGridView.Location = new Point(3, 4);
            yearlyInstallmentsDataGridView.Margin = new Padding(3, 4, 3, 4);
            yearlyInstallmentsDataGridView.Name = "yearlyInstallmentsDataGridView";
            yearlyInstallmentsDataGridView.ReadOnly = true;
            yearlyInstallmentsDataGridView.RowHeadersWidth = 51;
            yearlyInstallmentsDataGridView.Size = new Size(994, 501);
            yearlyInstallmentsDataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn2.HeaderText = "Id";
            idDataGridViewTextBoxColumn2.MinimumWidth = 6;
            idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            idDataGridViewTextBoxColumn2.ReadOnly = true;
            idDataGridViewTextBoxColumn2.Width = 125;
            // 
            // dueDateDataGridViewTextBoxColumn2
            // 
            dueDateDataGridViewTextBoxColumn2.DataPropertyName = "DueDate";
            dueDateDataGridViewTextBoxColumn2.HeaderText = "DueDate";
            dueDateDataGridViewTextBoxColumn2.MinimumWidth = 6;
            dueDateDataGridViewTextBoxColumn2.Name = "dueDateDataGridViewTextBoxColumn2";
            dueDateDataGridViewTextBoxColumn2.ReadOnly = true;
            dueDateDataGridViewTextBoxColumn2.Width = 125;
            // 
            // principalDataGridViewTextBoxColumn2
            // 
            principalDataGridViewTextBoxColumn2.DataPropertyName = "Principal";
            principalDataGridViewTextBoxColumn2.HeaderText = "Principal";
            principalDataGridViewTextBoxColumn2.MinimumWidth = 6;
            principalDataGridViewTextBoxColumn2.Name = "principalDataGridViewTextBoxColumn2";
            principalDataGridViewTextBoxColumn2.ReadOnly = true;
            principalDataGridViewTextBoxColumn2.Width = 125;
            // 
            // interestDataGridViewTextBoxColumn2
            // 
            interestDataGridViewTextBoxColumn2.DataPropertyName = "Interest";
            interestDataGridViewTextBoxColumn2.HeaderText = "Interest";
            interestDataGridViewTextBoxColumn2.MinimumWidth = 6;
            interestDataGridViewTextBoxColumn2.Name = "interestDataGridViewTextBoxColumn2";
            interestDataGridViewTextBoxColumn2.ReadOnly = true;
            interestDataGridViewTextBoxColumn2.Width = 125;
            // 
            // insuranceDataGridViewTextBoxColumn2
            // 
            insuranceDataGridViewTextBoxColumn2.DataPropertyName = "Insurance";
            insuranceDataGridViewTextBoxColumn2.HeaderText = "Insurance";
            insuranceDataGridViewTextBoxColumn2.MinimumWidth = 6;
            insuranceDataGridViewTextBoxColumn2.Name = "insuranceDataGridViewTextBoxColumn2";
            insuranceDataGridViewTextBoxColumn2.ReadOnly = true;
            insuranceDataGridViewTextBoxColumn2.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn2
            // 
            totalDataGridViewTextBoxColumn2.DataPropertyName = "Total";
            totalDataGridViewTextBoxColumn2.HeaderText = "Total";
            totalDataGridViewTextBoxColumn2.MinimumWidth = 6;
            totalDataGridViewTextBoxColumn2.Name = "totalDataGridViewTextBoxColumn2";
            totalDataGridViewTextBoxColumn2.ReadOnly = true;
            totalDataGridViewTextBoxColumn2.Width = 125;
            // 
            // creditBalanceDataGridViewTextBoxColumn2
            // 
            creditBalanceDataGridViewTextBoxColumn2.DataPropertyName = "CreditBalance";
            creditBalanceDataGridViewTextBoxColumn2.HeaderText = "CreditBalance";
            creditBalanceDataGridViewTextBoxColumn2.MinimumWidth = 6;
            creditBalanceDataGridViewTextBoxColumn2.Name = "creditBalanceDataGridViewTextBoxColumn2";
            creditBalanceDataGridViewTextBoxColumn2.ReadOnly = true;
            creditBalanceDataGridViewTextBoxColumn2.Width = 125;
            // 
            // cAGRDataGridViewTextBoxColumn
            // 
            cAGRDataGridViewTextBoxColumn.DataPropertyName = "CAGR";
            cAGRDataGridViewTextBoxColumn.HeaderText = "CAGR";
            cAGRDataGridViewTextBoxColumn.MinimumWidth = 6;
            cAGRDataGridViewTextBoxColumn.Name = "cAGRDataGridViewTextBoxColumn";
            cAGRDataGridViewTextBoxColumn.ReadOnly = true;
            cAGRDataGridViewTextBoxColumn.Width = 125;
            // 
            // InstallmentsTab
            // 
            InstallmentsTab.Controls.Add(installmentsDataGridView);
            InstallmentsTab.Location = new Point(4, 29);
            InstallmentsTab.Margin = new Padding(3, 4, 3, 4);
            InstallmentsTab.Name = "InstallmentsTab";
            InstallmentsTab.Padding = new Padding(3, 4, 3, 4);
            InstallmentsTab.Size = new Size(1000, 509);
            InstallmentsTab.TabIndex = 0;
            InstallmentsTab.Text = "Installments";
            InstallmentsTab.UseVisualStyleBackColor = true;
            // 
            // installmentsDataGridView
            // 
            installmentsDataGridView.AllowUserToAddRows = false;
            installmentsDataGridView.AllowUserToDeleteRows = false;
            installmentsDataGridView.AutoGenerateColumns = false;
            installmentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            installmentsDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, dueDateDataGridViewTextBoxColumn1, principalDataGridViewTextBoxColumn1, interestDataGridViewTextBoxColumn1, insuranceDataGridViewTextBoxColumn1, totalDataGridViewTextBoxColumn1, creditBalanceDataGridViewTextBoxColumn1 });
            installmentsDataGridView.DataSource = installmentBindingSource;
            installmentsDataGridView.Dock = DockStyle.Fill;
            installmentsDataGridView.Location = new Point(3, 4);
            installmentsDataGridView.Margin = new Padding(3, 4, 3, 4);
            installmentsDataGridView.Name = "installmentsDataGridView";
            installmentsDataGridView.ReadOnly = true;
            installmentsDataGridView.RowHeadersWidth = 51;
            installmentsDataGridView.Size = new Size(994, 501);
            installmentsDataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dueDateDataGridViewTextBoxColumn1
            // 
            dueDateDataGridViewTextBoxColumn1.DataPropertyName = "DueDate";
            dueDateDataGridViewTextBoxColumn1.HeaderText = "DueDate";
            dueDateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            dueDateDataGridViewTextBoxColumn1.Name = "dueDateDataGridViewTextBoxColumn1";
            dueDateDataGridViewTextBoxColumn1.ReadOnly = true;
            dueDateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // principalDataGridViewTextBoxColumn1
            // 
            principalDataGridViewTextBoxColumn1.DataPropertyName = "Principal";
            principalDataGridViewTextBoxColumn1.HeaderText = "Principal";
            principalDataGridViewTextBoxColumn1.MinimumWidth = 6;
            principalDataGridViewTextBoxColumn1.Name = "principalDataGridViewTextBoxColumn1";
            principalDataGridViewTextBoxColumn1.ReadOnly = true;
            principalDataGridViewTextBoxColumn1.Width = 125;
            // 
            // interestDataGridViewTextBoxColumn1
            // 
            interestDataGridViewTextBoxColumn1.DataPropertyName = "Interest";
            interestDataGridViewTextBoxColumn1.HeaderText = "Interest";
            interestDataGridViewTextBoxColumn1.MinimumWidth = 6;
            interestDataGridViewTextBoxColumn1.Name = "interestDataGridViewTextBoxColumn1";
            interestDataGridViewTextBoxColumn1.ReadOnly = true;
            interestDataGridViewTextBoxColumn1.Width = 125;
            // 
            // insuranceDataGridViewTextBoxColumn1
            // 
            insuranceDataGridViewTextBoxColumn1.DataPropertyName = "Insurance";
            insuranceDataGridViewTextBoxColumn1.HeaderText = "Insurance";
            insuranceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            insuranceDataGridViewTextBoxColumn1.Name = "insuranceDataGridViewTextBoxColumn1";
            insuranceDataGridViewTextBoxColumn1.ReadOnly = true;
            insuranceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn1
            // 
            totalDataGridViewTextBoxColumn1.DataPropertyName = "Total";
            totalDataGridViewTextBoxColumn1.HeaderText = "Total";
            totalDataGridViewTextBoxColumn1.MinimumWidth = 6;
            totalDataGridViewTextBoxColumn1.Name = "totalDataGridViewTextBoxColumn1";
            totalDataGridViewTextBoxColumn1.ReadOnly = true;
            totalDataGridViewTextBoxColumn1.Width = 125;
            // 
            // creditBalanceDataGridViewTextBoxColumn1
            // 
            creditBalanceDataGridViewTextBoxColumn1.DataPropertyName = "CreditBalance";
            creditBalanceDataGridViewTextBoxColumn1.HeaderText = "CreditBalance";
            creditBalanceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            creditBalanceDataGridViewTextBoxColumn1.Name = "creditBalanceDataGridViewTextBoxColumn1";
            creditBalanceDataGridViewTextBoxColumn1.ReadOnly = true;
            creditBalanceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // TabControl
            // 
            TabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl.Controls.Add(InstallmentsTab);
            TabControl.Controls.Add(YearlyInstallmentsTab);
            TabControl.Location = new Point(6, 27);
            TabControl.Margin = new Padding(3, 4, 3, 4);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1008, 542);
            TabControl.TabIndex = 3;
            // 
            // ExportButton
            // 
            ExportButton.Location = new Point(99, 23);
            ExportButton.Margin = new Padding(3, 4, 3, 4);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(105, 31);
            ExportButton.TabIndex = 4;
            ExportButton.Text = "Export To CSV";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ExportButton);
            groupBox2.Controls.Add(GoButton);
            groupBox2.Location = new Point(451, 16);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(218, 61);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Actions";
            // 
            // TabelDataGroupbox
            // 
            TabelDataGroupbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TabelDataGroupbox.Controls.Add(TotalValuesBox);
            TabelDataGroupbox.Controls.Add(TabControl);
            TabelDataGroupbox.Location = new Point(20, 84);
            TabelDataGroupbox.Name = "TabelDataGroupbox";
            TabelDataGroupbox.Size = new Size(1020, 639);
            TabelDataGroupbox.TabIndex = 6;
            TabelDataGroupbox.TabStop = false;
            // 
            // TotalValuesBox
            // 
            TotalValuesBox.Anchor = AnchorStyles.Bottom;
            TotalValuesBox.Controls.Add(TotalPrincipalLabelText);
            TotalValuesBox.Controls.Add(TotalLabel);
            TotalValuesBox.Controls.Add(TotalPrincipalLabel);
            TotalValuesBox.Controls.Add(TotalLabelText);
            TotalValuesBox.Controls.Add(TotalInterestLabelText);
            TotalValuesBox.Controls.Add(TotalInsuranceLabel);
            TotalValuesBox.Controls.Add(TotalInterestLabel);
            TotalValuesBox.Controls.Add(TotalInsuranceLabelText);
            TotalValuesBox.Location = new Point(13, 564);
            TotalValuesBox.Name = "TotalValuesBox";
            TotalValuesBox.Size = new Size(994, 69);
            TotalValuesBox.TabIndex = 11;
            TotalValuesBox.TabStop = false;
            TotalValuesBox.Visible = false;
            // 
            // TotalPrincipalLabelText
            // 
            TotalPrincipalLabelText.AutoSize = true;
            TotalPrincipalLabelText.Location = new Point(16, 23);
            TotalPrincipalLabelText.Name = "TotalPrincipalLabelText";
            TotalPrincipalLabelText.Size = new Size(69, 20);
            TotalPrincipalLabelText.TabIndex = 4;
            TotalPrincipalLabelText.Text = "Principal:";
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Location = new Point(847, 23);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(36, 20);
            TotalLabel.TabIndex = 10;
            TotalLabel.Text = "N/A";
            // 
            // TotalPrincipalLabel
            // 
            TotalPrincipalLabel.AutoSize = true;
            TotalPrincipalLabel.Location = new Point(91, 23);
            TotalPrincipalLabel.Name = "TotalPrincipalLabel";
            TotalPrincipalLabel.Size = new Size(36, 20);
            TotalPrincipalLabel.TabIndex = 5;
            TotalPrincipalLabel.Text = "N/A";
            // 
            // TotalLabelText
            // 
            TotalLabelText.AutoSize = true;
            TotalLabelText.Location = new Point(796, 23);
            TotalLabelText.Name = "TotalLabelText";
            TotalLabelText.Size = new Size(45, 20);
            TotalLabelText.TabIndex = 5;
            TotalLabelText.Text = "Total:";
            // 
            // TotalInterestLabelText
            // 
            TotalInterestLabelText.AutoSize = true;
            TotalInterestLabelText.Location = new Point(248, 23);
            TotalInterestLabelText.Name = "TotalInterestLabelText";
            TotalInterestLabelText.Size = new Size(61, 20);
            TotalInterestLabelText.TabIndex = 6;
            TotalInterestLabelText.Text = "Interest:";
            // 
            // TotalInsuranceLabel
            // 
            TotalInsuranceLabel.AutoSize = true;
            TotalInsuranceLabel.Location = new Point(597, 23);
            TotalInsuranceLabel.Name = "TotalInsuranceLabel";
            TotalInsuranceLabel.Size = new Size(36, 20);
            TotalInsuranceLabel.TabIndex = 9;
            TotalInsuranceLabel.Text = "N/A";
            // 
            // TotalInterestLabel
            // 
            TotalInterestLabel.AutoSize = true;
            TotalInterestLabel.Location = new Point(315, 23);
            TotalInterestLabel.Name = "TotalInterestLabel";
            TotalInterestLabel.Size = new Size(36, 20);
            TotalInterestLabel.TabIndex = 7;
            TotalInterestLabel.Text = "N/A";
            // 
            // TotalInsuranceLabelText
            // 
            TotalInsuranceLabelText.AutoSize = true;
            TotalInsuranceLabelText.Location = new Point(517, 23);
            TotalInsuranceLabelText.Name = "TotalInsuranceLabelText";
            TotalInsuranceLabelText.Size = new Size(74, 20);
            TotalInsuranceLabelText.TabIndex = 8;
            TotalInsuranceLabelText.Text = "Insurance:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 735);
            Controls.Add(TabelDataGroupbox);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)installmentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)yearlyInstallmentsBindingSource).EndInit();
            YearlyInstallmentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)yearlyInstallmentsDataGridView).EndInit();
            InstallmentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)installmentsDataGridView).EndInit();
            TabControl.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            TabelDataGroupbox.ResumeLayout(false);
            TotalValuesBox.ResumeLayout(false);
            TotalValuesBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button selectFileButton;
        private TextBox selectFileTextBox;
        private Button GoButton;
        private BindingSource installmentBindingSource;
        private GroupBox tableBox;
        private TabControl tabControl1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn principalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn interestDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn insuranceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn creditBalanceDataGridViewTextBoxColumn;
        private BindingSource yearlyInstallmentsBindingSource;
        private TabPage YearlyInstallmentsTab;
        private TabPage InstallmentsTab;
        private DataGridView installmentsDataGridView;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn principalDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn interestDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn insuranceDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn creditBalanceDataGridViewTextBoxColumn1;
        private TabControl TabControl;
        private DataGridView yearlyInstallmentsDataGridView;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn principalDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn interestDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn insuranceDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn creditBalanceDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn cAGRDataGridViewTextBoxColumn;
        private Button ExportButton;
        private GroupBox groupBox2;
        private GroupBox TabelDataGroupbox;
        private Label TotalLabel;
        private Label TotalLabelText;
        private Label TotalInsuranceLabel;
        private Label TotalInsuranceLabelText;
        private Label TotalInterestLabel;
        private Label TotalInterestLabelText;
        private Label TotalPrincipalLabel;
        private Label TotalPrincipalLabelText;
        private GroupBox TotalValuesBox;
    }
}
