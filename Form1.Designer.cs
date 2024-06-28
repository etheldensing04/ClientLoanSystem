
namespace ClientLoanSystem
{
    partial class Form1
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
            this.Panel1 = new Guna.UI.WinForms.GunaPanel();
            this.homeBtn = new System.Windows.Forms.Button();
            this.memberBtn = new System.Windows.Forms.Button();
            this.paymentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Location = new System.Drawing.Point(147, 12);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(581, 364);
            this.Panel1.TabIndex = 3;
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.homeBtn.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.Location = new System.Drawing.Point(12, 81);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(129, 40);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.Text = "HOME";
            this.homeBtn.UseVisualStyleBackColor = false;
            // 
            // memberBtn
            // 
            this.memberBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.memberBtn.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberBtn.Location = new System.Drawing.Point(12, 161);
            this.memberBtn.Name = "memberBtn";
            this.memberBtn.Size = new System.Drawing.Size(129, 40);
            this.memberBtn.TabIndex = 4;
            this.memberBtn.Text = "MEMBER";
            this.memberBtn.UseVisualStyleBackColor = false;
            this.memberBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // paymentBtn
            // 
            this.paymentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.paymentBtn.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentBtn.Location = new System.Drawing.Point(12, 238);
            this.paymentBtn.Name = "paymentBtn";
            this.paymentBtn.Size = new System.Drawing.Size(129, 40);
            this.paymentBtn.TabIndex = 5;
            this.paymentBtn.Text = "PAYMENT";
            this.paymentBtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(743, 388);
            this.Controls.Add(this.paymentBtn);
            this.Controls.Add(this.memberBtn);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.Panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }


        #endregion
        private Guna.UI.WinForms.GunaPanel Panel1;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button memberBtn;
        private System.Windows.Forms.Button paymentBtn;
    }
}