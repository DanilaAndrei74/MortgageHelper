namespace MortgageHelper
{
    partial class SummaryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ReinbursementPerformanceGroupBox = new GroupBox();
            SummaryGridView = new DataGridView();
            ValuesColumn = new DataGridViewTextBoxColumn();
            PrincipalColumn = new DataGridViewTextBoxColumn();
            InterestColumn = new DataGridViewTextBoxColumn();
            InsuranceColumn = new DataGridViewTextBoxColumn();
            TotalColumn = new DataGridViewTextBoxColumn();
            RemainingMonthsColumn = new DataGridViewTextBoxColumn();
            AnnualizedReturnTextBox = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            ReinbursementPerformanceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SummaryGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ReinbursementPerformanceGroupBox
            // 
            ReinbursementPerformanceGroupBox.Controls.Add(SummaryGridView);
            ReinbursementPerformanceGroupBox.Location = new Point(6, 0);
            ReinbursementPerformanceGroupBox.Name = "ReinbursementPerformanceGroupBox";
            ReinbursementPerformanceGroupBox.Size = new Size(646, 119);
            ReinbursementPerformanceGroupBox.TabIndex = 1;
            ReinbursementPerformanceGroupBox.TabStop = false;
            // 
            // SummaryGridView
            // 
            SummaryGridView.AllowUserToAddRows = false;
            SummaryGridView.AllowUserToDeleteRows = false;
            SummaryGridView.AllowUserToResizeColumns = false;
            SummaryGridView.AllowUserToResizeRows = false;
            SummaryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SummaryGridView.Columns.AddRange(new DataGridViewColumn[] { ValuesColumn, PrincipalColumn, InterestColumn, InsuranceColumn, TotalColumn, RemainingMonthsColumn });
            SummaryGridView.Dock = DockStyle.Fill;
            SummaryGridView.Location = new Point(3, 19);
            SummaryGridView.Name = "SummaryGridView";
            SummaryGridView.ReadOnly = true;
            SummaryGridView.ScrollBars = ScrollBars.None;
            SummaryGridView.Size = new Size(640, 97);
            SummaryGridView.TabIndex = 3;
            // 
            // ValuesColumn
            // 
            ValuesColumn.HeaderText = "Values";
            ValuesColumn.Name = "ValuesColumn";
            ValuesColumn.ReadOnly = true;
            // 
            // PrincipalColumn
            // 
            PrincipalColumn.HeaderText = "Principal";
            PrincipalColumn.Name = "PrincipalColumn";
            PrincipalColumn.ReadOnly = true;
            // 
            // InterestColumn
            // 
            InterestColumn.HeaderText = "Interest";
            InterestColumn.Name = "InterestColumn";
            InterestColumn.ReadOnly = true;
            // 
            // InsuranceColumn
            // 
            InsuranceColumn.HeaderText = "Insurance";
            InsuranceColumn.Name = "InsuranceColumn";
            InsuranceColumn.ReadOnly = true;
            // 
            // TotalColumn
            // 
            TotalColumn.HeaderText = "Total";
            TotalColumn.Name = "TotalColumn";
            TotalColumn.ReadOnly = true;
            // 
            // RemainingMonthsColumn
            // 
            RemainingMonthsColumn.HeaderText = "Months";
            RemainingMonthsColumn.Name = "RemainingMonthsColumn";
            RemainingMonthsColumn.ReadOnly = true;
            // 
            // AnnualizedReturnTextBox
            // 
            AnnualizedReturnTextBox.Location = new Point(216, 22);
            AnnualizedReturnTextBox.Name = "AnnualizedReturnTextBox";
            AnnualizedReturnTextBox.ReadOnly = true;
            AnnualizedReturnTextBox.Size = new Size(164, 23);
            AnnualizedReturnTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(204, 15);
            label1.TabIndex = 1;
            label1.Text = "Annualized Return of reinbursement: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AnnualizedReturnTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(9, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(640, 54);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // SummaryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 181);
            Controls.Add(groupBox1);
            Controls.Add(ReinbursementPerformanceGroupBox);
            Name = "SummaryForm";
            Text = "SummaryForm";
            ReinbursementPerformanceGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SummaryGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox ReinbursementPerformanceGroupBox;
        private Label label1;
        private TextBox AnnualizedReturnTextBox;
        private DataGridView SummaryGridView;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn ValuesColumn;
        private DataGridViewTextBoxColumn PrincipalColumn;
        private DataGridViewTextBoxColumn InterestColumn;
        private DataGridViewTextBoxColumn InsuranceColumn;
        private DataGridViewTextBoxColumn TotalColumn;
        private DataGridViewTextBoxColumn RemainingMonthsColumn;
    }
}