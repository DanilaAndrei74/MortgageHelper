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
            TabControl = new TabControl();
            InstallmentsTab = new TabPage();
            installmentsDataGridView = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dueDateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            principalDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            interestDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            insuranceDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            creditBalanceDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            YearlyInstallmentsTab = new TabPage();
            yearlyInstallmentsDataGridView = new DataGridView();
            idDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dueDateDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            principalDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            interestDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            insuranceDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            creditBalanceDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            yearlyInstallmentsBindingSource = new BindingSource(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)installmentBindingSource).BeginInit();
            TabControl.SuspendLayout();
            InstallmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)installmentsDataGridView).BeginInit();
            YearlyInstallmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yearlyInstallmentsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yearlyInstallmentsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(selectFileButton);
            groupBox1.Controls.Add(selectFileTextBox);
            groupBox1.Location = new Point(15, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 46);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select PDF to convert:";
            // 
            // selectFileButton
            // 
            selectFileButton.Dock = DockStyle.Right;
            selectFileButton.Location = new Point(291, 19);
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
            GoButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            GoButton.Location = new Point(387, 30);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(75, 23);
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
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            dueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // principalDataGridViewTextBoxColumn
            // 
            principalDataGridViewTextBoxColumn.DataPropertyName = "Principal";
            principalDataGridViewTextBoxColumn.HeaderText = "Principal";
            principalDataGridViewTextBoxColumn.Name = "principalDataGridViewTextBoxColumn";
            principalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // interestDataGridViewTextBoxColumn
            // 
            interestDataGridViewTextBoxColumn.DataPropertyName = "Interest";
            interestDataGridViewTextBoxColumn.HeaderText = "Interest";
            interestDataGridViewTextBoxColumn.Name = "interestDataGridViewTextBoxColumn";
            interestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // insuranceDataGridViewTextBoxColumn
            // 
            insuranceDataGridViewTextBoxColumn.DataPropertyName = "Insurance";
            insuranceDataGridViewTextBoxColumn.HeaderText = "Insurance";
            insuranceDataGridViewTextBoxColumn.Name = "insuranceDataGridViewTextBoxColumn";
            insuranceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            totalDataGridViewTextBoxColumn.HeaderText = "Total";
            totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creditBalanceDataGridViewTextBoxColumn
            // 
            creditBalanceDataGridViewTextBoxColumn.DataPropertyName = "CreditBalance";
            creditBalanceDataGridViewTextBoxColumn.HeaderText = "CreditBalance";
            creditBalanceDataGridViewTextBoxColumn.Name = "creditBalanceDataGridViewTextBoxColumn";
            creditBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(InstallmentsTab);
            TabControl.Controls.Add(YearlyInstallmentsTab);
            TabControl.Location = new Point(18, 64);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(758, 400);
            TabControl.TabIndex = 3;
            // 
            // InstallmentsTab
            // 
            InstallmentsTab.Controls.Add(installmentsDataGridView);
            InstallmentsTab.Location = new Point(4, 24);
            InstallmentsTab.Name = "InstallmentsTab";
            InstallmentsTab.Padding = new Padding(3);
            InstallmentsTab.Size = new Size(750, 372);
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
            installmentsDataGridView.Location = new Point(3, 3);
            installmentsDataGridView.Name = "installmentsDataGridView";
            installmentsDataGridView.ReadOnly = true;
            installmentsDataGridView.Size = new Size(744, 366);
            installmentsDataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // creditBalanceDataGridViewTextBoxColumn1
            // 
            creditBalanceDataGridViewTextBoxColumn1.DataPropertyName = "CreditBalance";
            creditBalanceDataGridViewTextBoxColumn1.HeaderText = "CreditBalance";
            creditBalanceDataGridViewTextBoxColumn1.Name = "creditBalanceDataGridViewTextBoxColumn1";
            creditBalanceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // YearlyInstallmentsTab
            // 
            YearlyInstallmentsTab.Controls.Add(yearlyInstallmentsDataGridView);
            YearlyInstallmentsTab.Location = new Point(4, 24);
            YearlyInstallmentsTab.Name = "YearlyInstallmentsTab";
            YearlyInstallmentsTab.Padding = new Padding(3);
            YearlyInstallmentsTab.Size = new Size(750, 372);
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
            yearlyInstallmentsDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn2, dueDateDataGridViewTextBoxColumn2, principalDataGridViewTextBoxColumn2, interestDataGridViewTextBoxColumn2, insuranceDataGridViewTextBoxColumn2, totalDataGridViewTextBoxColumn2, creditBalanceDataGridViewTextBoxColumn2 });
            yearlyInstallmentsDataGridView.DataSource = yearlyInstallmentsBindingSource;
            yearlyInstallmentsDataGridView.Dock = DockStyle.Fill;
            yearlyInstallmentsDataGridView.Location = new Point(3, 3);
            yearlyInstallmentsDataGridView.Name = "yearlyInstallmentsDataGridView";
            yearlyInstallmentsDataGridView.ReadOnly = true;
            yearlyInstallmentsDataGridView.Size = new Size(744, 366);
            yearlyInstallmentsDataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn2.HeaderText = "Id";
            idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            idDataGridViewTextBoxColumn2.ReadOnly = true;
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
            // creditBalanceDataGridViewTextBoxColumn2
            // 
            creditBalanceDataGridViewTextBoxColumn2.DataPropertyName = "CreditBalance";
            creditBalanceDataGridViewTextBoxColumn2.HeaderText = "CreditBalance";
            creditBalanceDataGridViewTextBoxColumn2.Name = "creditBalanceDataGridViewTextBoxColumn2";
            creditBalanceDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // yearlyInstallmentsBindingSource
            // 
            yearlyInstallmentsBindingSource.DataSource = typeof(Models.YearlyInstallment);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 476);
            Controls.Add(TabControl);
            Controls.Add(GoButton);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)installmentBindingSource).EndInit();
            TabControl.ResumeLayout(false);
            InstallmentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)installmentsDataGridView).EndInit();
            YearlyInstallmentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)yearlyInstallmentsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)yearlyInstallmentsBindingSource).EndInit();
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
        private TabControl TabControl;
        private TabPage InstallmentsTab;
        private DataGridView installmentsDataGridView;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn principalDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn interestDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn insuranceDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn creditBalanceDataGridViewTextBoxColumn1;
        private TabPage YearlyInstallmentsTab;
        private BindingSource yearlyInstallmentsBindingSource;
        private DataGridView yearlyInstallmentsDataGridView;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn principalDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn interestDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn insuranceDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn creditBalanceDataGridViewTextBoxColumn2;
    }
}
