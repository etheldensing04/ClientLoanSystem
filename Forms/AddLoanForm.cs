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
    public partial class AddLoanForm : Form
    {
        private const double MIN_LOAN = 1000;
        private readonly int CurrentCLientID;
        public AddLoanForm(int CurrentCLientID)
        {
            InitializeComponent();
            this.CurrentCLientID = CurrentCLientID;
        }

        public double LoanAmt { get; set; }
        public double Interest { get; set; }
        public PaymentTerm SelectedTerm { get; set; }
        public int NoOfPayment { get; set; }
        public double Deduction { get; set; }
        private void addBtn_Click(object sender, EventArgs e)
        {
            using (densingdbEntities _con = new densingdbEntities())
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

                    double interestedamount = (loanAmount * interest) / 100;

                    Loan loan = new Loan()
                    {
                        Loan_AMT = loanAmount,
                        Interest = interest,
                        Term = selectedTerm.ToString(),
                        NoOf_Payment = numberOfPayments,
                        Deduction = deduction,
                        Interested_AMT = interestedamount,
                        Receivable_AMT = (loanAmount + interestedamount) - deduction,
                        Total_Payable = interestedamount,
                        Due_Date = GetDueDate(numberOfPayments,DateTime.Now, SelectedTerm),
                        Status_Paid = "Ongoing"
                    };

                    _con.Loans.Add(loan);
                    _con.SaveChanges();
                    int loan_id = loan.LoanID;

                    DateTime release = DateTime.Now;

                    List<Schedule> schedules = new List<Schedule>();

                    for(int i = 0; i < numberOfPayments; i++)
                    {
                        Schedule temp = new Schedule();

                        switch (SelectedTerm)
                        {
                            case PaymentTerm.Daily:
                                release.AddDays(1);
                                break;
                            case PaymentTerm.Weekly:
                                release.AddDays(7);
                                break;
                            case PaymentTerm.Monthly:
                                release.AddMonths(1);
                                break;
                            case PaymentTerm.Yearly:
                                release.AddYears(1);
                                break;
                        }

                        temp.LoanID = loan_id;
                        temp.ClientId = CurrentCLientID;
                        temp.Collectables = (decimal) interestedamount / numberOfPayments;
                        temp.Date = release;
                        temp.Status = "Ongoing";

                        schedules.Add(temp);
                    }

                    _con.Schedules.AddRange(schedules);
                    _con.SaveChanges();

                    DialogResult = DialogResult.Yes;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
               
        }

        private DateTime GetDueDate(int numberOfPayments, DateTime loanStartDate, PaymentTerm frequency)
        {
            int daysBetweenPayments = 0;
            switch (frequency)
            {
                case PaymentTerm.Daily:
                    daysBetweenPayments = 1;
                    break;
                case PaymentTerm.Weekly:
                    daysBetweenPayments = 7;
                    break;
                case PaymentTerm.Monthly:
                    daysBetweenPayments = 30;
                    break;
                case PaymentTerm.Yearly:
                    daysBetweenPayments = 365;
                    break;
            }
            DateTime dueDate = loanStartDate.AddDays(1);
            dueDate = dueDate.AddDays(daysBetweenPayments * (numberOfPayments - 1));
            return dueDate;
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
