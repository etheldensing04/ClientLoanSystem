
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel1 = new Guna.UI.WinForms.GunaPanel();
            this.homeBtn = new Guna.UI.WinForms.GunaButton();
            this.memberBtn = new Guna.UI.WinForms.GunaButton();
            this.paymentBtn = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Location = new System.Drawing.Point(153, 12);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(589, 364);
            this.Panel1.TabIndex = 0;
            // 
            // homeBtn
            // 
            this.homeBtn.AnimationHoverSpeed = 0.07F;
            this.homeBtn.AnimationSpeed = 0.03F;
            this.homeBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.homeBtn.BorderColor = System.Drawing.Color.Black;
            this.homeBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.homeBtn.FocusedColor = System.Drawing.Color.Empty;
            this.homeBtn.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.homeBtn.Location = new System.Drawing.Point(12, 95);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.homeBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.homeBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.homeBtn.OnHoverImage = null;
            this.homeBtn.OnPressedColor = System.Drawing.Color.Black;
            this.homeBtn.Size = new System.Drawing.Size(135, 42);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.Text = "HOME";
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // memberBtn
            // 
            this.memberBtn.AnimationHoverSpeed = 0.07F;
            this.memberBtn.AnimationSpeed = 0.03F;
            this.memberBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.memberBtn.BorderColor = System.Drawing.Color.Black;
            this.memberBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.memberBtn.FocusedColor = System.Drawing.Color.Empty;
            this.memberBtn.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberBtn.ForeColor = System.Drawing.Color.White;
            this.memberBtn.Image = ((System.Drawing.Image)(resources.GetObject("memberBtn.Image")));
            this.memberBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.memberBtn.Location = new System.Drawing.Point(12, 143);
            this.memberBtn.Name = "memberBtn";
            this.memberBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.memberBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.memberBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.memberBtn.OnHoverImage = null;
            this.memberBtn.OnPressedColor = System.Drawing.Color.Black;
            this.memberBtn.Size = new System.Drawing.Size(135, 42);
            this.memberBtn.TabIndex = 1;
            this.memberBtn.Text = "MEMBER";
            this.memberBtn.Click += new System.EventHandler(this.memberBtn_Click);
            // 
            // paymentBtn
            // 
            this.paymentBtn.AnimationHoverSpeed = 0.07F;
            this.paymentBtn.AnimationSpeed = 0.03F;
            this.paymentBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.paymentBtn.BorderColor = System.Drawing.Color.Black;
            this.paymentBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.paymentBtn.FocusedColor = System.Drawing.Color.Empty;
            this.paymentBtn.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentBtn.ForeColor = System.Drawing.Color.White;
            this.paymentBtn.Image = ((System.Drawing.Image)(resources.GetObject("paymentBtn.Image")));
            this.paymentBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.paymentBtn.Location = new System.Drawing.Point(12, 191);
            this.paymentBtn.Name = "paymentBtn";
            this.paymentBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.paymentBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.paymentBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.paymentBtn.OnHoverImage = null;
            this.paymentBtn.OnPressedColor = System.Drawing.Color.Black;
            this.paymentBtn.Size = new System.Drawing.Size(135, 42);
            this.paymentBtn.TabIndex = 2;
            this.paymentBtn.Text = "PAYMENT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 388);
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
        private Guna.UI.WinForms.GunaButton homeBtn;
        private Guna.UI.WinForms.GunaButton memberBtn;
        private Guna.UI.WinForms.GunaButton paymentBtn;
    }
}