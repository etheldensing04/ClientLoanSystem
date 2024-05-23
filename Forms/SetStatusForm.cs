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
    public partial class SetStatusForm : Form
    {
        public SetStatusForm()
        {
            InitializeComponent();
        }

        public string GetStatus { get; set; }
        private void SetStatusForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(StatusPaid));
        }

        private void setButton(object sender, EventArgs e)
        {
            GetStatus = comboBox1.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
