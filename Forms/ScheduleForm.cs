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
        private int _loanID, _clientID;
        public ScheduleForm(int _loanID, int _clientID)
        {
            InitializeComponent();
            this._loanID = _loanID;
            this._clientID = _clientID;
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            Text = $"Loan #{_loanID} : #{_clientID}";

            using (densingdbEntities _con = new densingdbEntities())
            {
                List<Schedule> _source = _con.Schedules.Where(_ => _.LoanID == _loanID && _.ClientId == _clientID).ToList();
                scheduleBindingSource.DataSource = _source;
            }
        }
    }
}
