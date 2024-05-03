using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientLoanSystem.Forms
{
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Residency { get; set; }
        public DateTime Birthday { get; set; }
        private void addBtn_Click(object sender, EventArgs e)
        {
            Firstname = firstname_val.Text.Trim();
            Lastname = lastname_val.Text.Trim();
            Residency = residency_val.Text.Trim();
            Birthday = birthday_val.Value;

            if (!string.IsNullOrWhiteSpace(Firstname) &&
                !string.IsNullOrWhiteSpace(Lastname) &&
                !string.IsNullOrWhiteSpace(Residency))
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill out all fields with valid values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
