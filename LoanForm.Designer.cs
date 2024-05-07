namespace ClientLoanSystem
{
    partial class LoanForm
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
            this.components = new System.ComponentModel.Container();
            this.currentClientLabel = new System.Windows.Forms.Label();
            this.loanTable = new System.Windows.Forms.DataGridView();
            this.paidBtn = new System.Windows.Forms.Button();
            this.addLoanBtn = new System.Windows.Forms.Button();
            this.loanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanAMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestedAMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivableAMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPayableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.loanTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // currentClientLabel
            // 
            this.currentClientLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.currentClientLabel.Font = new System.Drawing.Font("Calisto MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentClientLabel.Location = new System.Drawing.Point(0, 0);
            this.currentClientLabel.Name = "currentClientLabel";
            this.currentClientLabel.Size = new System.Drawing.Size(1041, 56);
            this.currentClientLabel.TabIndex = 0;
            this.currentClientLabel.Text = "Loan of Client ID";
            this.currentClientLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loanTable
            // 
            this.loanTable.AllowUserToAddRows = false;
            this.loanTable.AllowUserToDeleteRows = false;
            this.loanTable.AutoGenerateColumns = false;
            this.loanTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loanTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.loanTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loanTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loanIDDataGridViewTextBoxColumn,
            this.clientIdDataGridViewTextBoxColumn,
            this.loanAMTDataGridViewTextBoxColumn,
            this.interestDataGridViewTextBoxColumn,
            this.termDataGridViewTextBoxColumn,
            this.noOfPaymentDataGridViewTextBoxColumn,
            this.deductionDataGridViewTextBoxColumn,
            this.interestedAMTDataGridViewTextBoxColumn,
            this.receivableAMTDataGridViewTextBoxColumn,
            this.totalPayableDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.statusPaidDataGridViewTextBoxColumn});
            this.loanTable.DataSource = this.loanBindingSource;
            this.loanTable.Location = new System.Drawing.Point(16, 59);
            this.loanTable.Name = "loanTable";
            this.loanTable.ReadOnly = true;
            this.loanTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.loanTable.Size = new System.Drawing.Size(1013, 207);
            this.loanTable.TabIndex = 1;
            this.loanTable.SelectionChanged += new System.EventHandler(this.loanTable_SelectionChanged);
            // 
            // paidBtn
            // 
            this.paidBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.paidBtn.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidBtn.Location = new System.Drawing.Point(439, 272);
            this.paidBtn.Name = "paidBtn";
            this.paidBtn.Size = new System.Drawing.Size(85, 53);
            this.paidBtn.TabIndex = 4;
            this.paidBtn.Text = "PAID";
            this.paidBtn.UseVisualStyleBackColor = false;
            this.paidBtn.Click += new System.EventHandler(this.paidBtn_Click);
            // 
            // addLoanBtn
            // 
            this.addLoanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.addLoanBtn.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLoanBtn.Location = new System.Drawing.Point(530, 272);
            this.addLoanBtn.Name = "addLoanBtn";
            this.addLoanBtn.Size = new System.Drawing.Size(84, 53);
            this.addLoanBtn.TabIndex = 5;
            this.addLoanBtn.Text = "ADD LOAN";
            this.addLoanBtn.UseVisualStyleBackColor = false;
            this.addLoanBtn.Click += new System.EventHandler(this.addLoanBtn_Click);
            // 
            // loanIDDataGridViewTextBoxColumn
            // 
            this.loanIDDataGridViewTextBoxColumn.DataPropertyName = "LoanID";
            this.loanIDDataGridViewTextBoxColumn.HeaderText = "LoanID";
            this.loanIDDataGridViewTextBoxColumn.Name = "loanIDDataGridViewTextBoxColumn";
            this.loanIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            this.clientIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loanAMTDataGridViewTextBoxColumn
            // 
            this.loanAMTDataGridViewTextBoxColumn.DataPropertyName = "Loan_AMT";
            this.loanAMTDataGridViewTextBoxColumn.HeaderText = "Loan_AMT";
            this.loanAMTDataGridViewTextBoxColumn.Name = "loanAMTDataGridViewTextBoxColumn";
            this.loanAMTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // interestDataGridViewTextBoxColumn
            // 
            this.interestDataGridViewTextBoxColumn.DataPropertyName = "Interest";
            this.interestDataGridViewTextBoxColumn.HeaderText = "Interest";
            this.interestDataGridViewTextBoxColumn.Name = "interestDataGridViewTextBoxColumn";
            this.interestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // termDataGridViewTextBoxColumn
            // 
            this.termDataGridViewTextBoxColumn.DataPropertyName = "Term";
            this.termDataGridViewTextBoxColumn.HeaderText = "Term";
            this.termDataGridViewTextBoxColumn.Name = "termDataGridViewTextBoxColumn";
            this.termDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noOfPaymentDataGridViewTextBoxColumn
            // 
            this.noOfPaymentDataGridViewTextBoxColumn.DataPropertyName = "NoOf_Payment";
            this.noOfPaymentDataGridViewTextBoxColumn.HeaderText = "NoOf_Payment";
            this.noOfPaymentDataGridViewTextBoxColumn.Name = "noOfPaymentDataGridViewTextBoxColumn";
            this.noOfPaymentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deductionDataGridViewTextBoxColumn
            // 
            this.deductionDataGridViewTextBoxColumn.DataPropertyName = "Deduction";
            this.deductionDataGridViewTextBoxColumn.HeaderText = "Deduction";
            this.deductionDataGridViewTextBoxColumn.Name = "deductionDataGridViewTextBoxColumn";
            this.deductionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // interestedAMTDataGridViewTextBoxColumn
            // 
            this.interestedAMTDataGridViewTextBoxColumn.DataPropertyName = "Interested_AMT";
            this.interestedAMTDataGridViewTextBoxColumn.HeaderText = "Interested_AMT";
            this.interestedAMTDataGridViewTextBoxColumn.Name = "interestedAMTDataGridViewTextBoxColumn";
            this.interestedAMTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receivableAMTDataGridViewTextBoxColumn
            // 
            this.receivableAMTDataGridViewTextBoxColumn.DataPropertyName = "Receivable_AMT";
            this.receivableAMTDataGridViewTextBoxColumn.HeaderText = "Receivable_AMT";
            this.receivableAMTDataGridViewTextBoxColumn.Name = "receivableAMTDataGridViewTextBoxColumn";
            this.receivableAMTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPayableDataGridViewTextBoxColumn
            // 
            this.totalPayableDataGridViewTextBoxColumn.DataPropertyName = "Total_Payable";
            this.totalPayableDataGridViewTextBoxColumn.HeaderText = "Total_Payable";
            this.totalPayableDataGridViewTextBoxColumn.Name = "totalPayableDataGridViewTextBoxColumn";
            this.totalPayableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "Due_Date";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "Due_Date";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            this.dueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusPaidDataGridViewTextBoxColumn
            // 
            this.statusPaidDataGridViewTextBoxColumn.DataPropertyName = "Status_Paid";
            this.statusPaidDataGridViewTextBoxColumn.HeaderText = "Status_Paid";
            this.statusPaidDataGridViewTextBoxColumn.Name = "statusPaidDataGridViewTextBoxColumn";
            this.statusPaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataSource = typeof(ClientLoanSystem.Entities.Loan);
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 332);
            this.Controls.Add(this.addLoanBtn);
            this.Controls.Add(this.paidBtn);
            this.Controls.Add(this.loanTable);
            this.Controls.Add(this.currentClientLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1057, 371);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1057, 371);
            this.Name = "LoanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoanForm";
            this.Load += new System.EventHandler(this.LoanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loanTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label currentClientLabel;
        private System.Windows.Forms.DataGridView loanTable;
        private System.Windows.Forms.Button paidBtn;
        private System.Windows.Forms.Button addLoanBtn;
        private System.Windows.Forms.BindingSource loanBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanAMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestedAMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivableAMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPayableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPaidDataGridViewTextBoxColumn;
    }
}