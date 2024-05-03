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
    public partial class AddLoanForm : Form
    {
        private const double MIN_LOAN = 1000;
        public AddLoanForm()
        {
            InitializeComponent();
        }

        public double LoanAmt { get; set; }
        public double Interest { get; set; }
        public PaymentTerm SelectedTerm { get; set; }
        public int NoOfPayment { get; set; }
        public double Deduction { get; set; }
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double loanAmount = (double)loan_val.Value;
                double interest = (double)interest_val.Value;

                PaymentTerm selectedTerm;
                if (!Enum.TryParse<PaymentTerm>(term_val.SelectedValue.ToString(), out selectedTerm))
                {
                    selectedTerm = PaymentTerm.Daily;
                }

                int numberOfPayments = Convert.ToInt32(noofpay_val.Value);
                double deduction = (double)deduction_val.Value;

                if (loanAmount < MIN_LOAN)
                {
                    MessageBox.Show($"Loan amount must be greater than or equal to {MIN_LOAN}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (numberOfPayments <= 0)
                {
                    MessageBox.Show("Number of payments must be greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LoanAmt = loanAmount;
                Interest = interest;
                SelectedTerm = selectedTerm;
                NoOfPayment = numberOfPayments;
                Deduction = deduction;

                DialogResult = DialogResult.Yes;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddLoanForm_Load(object sender, EventArgs e)
        {
            term_val.DataSource = Enum.GetValues(typeof(PaymentTerm));
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
