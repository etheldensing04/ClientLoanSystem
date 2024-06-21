using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientLoanSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Form activeform = null;
        private void openChildForm(Form childform)
        {
            if (activeform != null)
                activeform.Close();

            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            Panel1.Controls.Add(childform);
            Panel1.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {

        }

        private void memberBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new ClientForm()); 
        }
    }
}
