using ClientLoanSystem.Entities;
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
    public partial class ScheduleForm : Form
    {
        private readonly Schedule sched;
        private int a, b;
        public ScheduleForm(int a, int b)
        {
            InitializeComponent();
            this.a = a;
            this.b = b;
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            using (densingdbEntities _con = new densingdbEntities())
            {
                scheduleBindingSource1.DataSource = _con.Schedules.Where(_ => _.LoanID == a && _.ClientId == b).ToList();
            }
        }
    }
}
