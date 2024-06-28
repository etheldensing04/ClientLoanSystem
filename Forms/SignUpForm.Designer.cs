
namespace ClientLoanSystem.Forms
{
    partial class SignUpForm
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
            this.residency_val = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastname_val = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstname_val = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // residency_val
            // 
            this.residency_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.residency_val.Location = new System.Drawing.Point(109, 142);
            this.residency_val.Name = "residency_val";
            this.residency_val.Size = new System.Drawing.Size(188, 26);
            this.residency_val.TabIndex = 11;
            this.residency_val.TextChanged += new System.EventHandler(this.residency_val_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Username";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lastname_val
            // 
            this.lastname_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname_val.Location = new System.Drawing.Point(109, 89);
            this.lastname_val.Name = "lastname_val";
            this.lastname_val.Size = new System.Drawing.Size(188, 26);
            this.lastname_val.TabIndex = 9;
            this.lastname_val.TextChanged += new System.EventHandler(this.lastname_val_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lastname";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // firstname_val
            // 
            this.firstname_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname_val.Location = new System.Drawing.Point(109, 29);
            this.firstname_val.Name = "firstname_val";
            this.firstname_val.Size = new System.Drawing.Size(188, 26);
            this.firstname_val.TabIndex = 7;
            this.firstname_val.TextChanged += new System.EventHandler(this.firstname_val_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Firstname";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(109, 193);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 26);
            this.textBox1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(147, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "SIGN UP";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 285);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.residency_val);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastname_val);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstname_val);
            this.Controls.Add(this.label1);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox residency_val;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastname_val;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstname_val;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}