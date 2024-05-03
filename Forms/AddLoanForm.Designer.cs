namespace ClientLoanSystem.Forms
{
    partial class AddLoanForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.loan_val = new System.Windows.Forms.NumericUpDown();
            this.interest_val = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.term_val = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.noofpay_val = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.deduction_val = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loan_val)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interest_val)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noofpay_val)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deduction_val)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Loan Amount";
            // 
            // loan_val
            // 
            this.loan_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loan_val.Location = new System.Drawing.Point(151, 9);
            this.loan_val.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.loan_val.Name = "loan_val";
            this.loan_val.Size = new System.Drawing.Size(170, 26);
            this.loan_val.TabIndex = 11;
            // 
            // interest_val
            // 
            this.interest_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interest_val.Location = new System.Drawing.Point(62, 82);
            this.interest_val.Name = "interest_val";
            this.interest_val.Size = new System.Drawing.Size(173, 26);
            this.interest_val.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Interest";
            // 
            // term_val
            // 
            this.term_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.term_val.FormattingEnabled = true;
            this.term_val.Location = new System.Drawing.Point(62, 145);
            this.term_val.Name = "term_val";
            this.term_val.Size = new System.Drawing.Size(173, 28);
            this.term_val.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Term";
            // 
            // noofpay_val
            // 
            this.noofpay_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noofpay_val.Location = new System.Drawing.Point(62, 213);
            this.noofpay_val.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.noofpay_val.Name = "noofpay_val";
            this.noofpay_val.Size = new System.Drawing.Size(173, 26);
            this.noofpay_val.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "No. of Payment";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // deduction_val
            // 
            this.deduction_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deduction_val.Location = new System.Drawing.Point(62, 280);
            this.deduction_val.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.deduction_val.Name = "deduction_val";
            this.deduction_val.Size = new System.Drawing.Size(173, 26);
            this.deduction_val.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Deduction";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Aqua;
            this.addBtn.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(253, 165);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(80, 45);
            this.addBtn.TabIndex = 20;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // AddLoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 323);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.deduction_val);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.noofpay_val);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.term_val);
            this.Controls.Add(this.interest_val);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loan_val);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(361, 362);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(361, 362);
            this.Name = "AddLoanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddLoanForm";
            this.Load += new System.EventHandler(this.AddLoanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loan_val)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interest_val)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noofpay_val)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deduction_val)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown loan_val;
        private System.Windows.Forms.NumericUpDown interest_val;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox term_val;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown noofpay_val;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown deduction_val;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addBtn;
    }
}