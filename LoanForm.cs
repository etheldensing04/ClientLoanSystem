using ClientLoanSystem.Entities;
using ClientLoanSystem.Forms;
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
    public partial class LoanForm : Form
    {
        private AddLoan db;
        public LoanForm()
        {
            InitializeComponent();
        }

        private int currentClientId;
        public LoanForm(int currentClientId) : this()
        {
            this.currentClientId = currentClientId;
        }

        private void setSelectedClient()
        {
            List<Loan> selectedClientData = db._con.Loans.Where(q => q.ClientId == currentClientId).ToList();
            loanTable.DataSource = selectedClientData;

            currentClientLabel.Text = $"Loan of Client #{currentClientId}";
        }

        private void LoanForm_Load(object sender, EventArgs e)
        {
            db = new AddLoan();
            setSelectedClient();
        }

        private void addLoanBtn_Click(object sender, EventArgs e)
        {
            AddLoanForm newLoan = new AddLoanForm();
            if (newLoan.ShowDialog() == DialogResult.Yes)
            {
                AddLoan getNewLoan = new AddLoan(currentClientId, newLoan.LoanAmt, newLoan.Interest, newLoan.SelectedTerm, newLoan.NoOfPayment, newLoan.Deduction);
                getNewLoan.Confirmation = true;
                setSelectedClient();
            }
        }

        private void paidBtn_Click(object sender, EventArgs e)
        {
            SetStatusForm getStatus = new SetStatusForm();

            if (getStatus.ShowDialog() == DialogResult.OK)
            {
                db.SetStatus(getLoanId, getStatus.GetStatus);
            }

            setSelectedClient();
        }

        private int getLoanId;
        private void loanTable_SelectionChanged(object sender, EventArgs e)
        {
            if (loanTable.SelectedRows.Count == 0)
            {
                return;
            }

            getLoanId = (int)loanTable.SelectedRows[0].Cells[0].Value;
        }

        private void loanTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ScheduleForm viewSchedule = new ScheduleForm();
            viewSchedule.ShowDialog();
        }
    }
}
