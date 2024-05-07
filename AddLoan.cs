using ClientLoanSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientLoanSystem
{
    internal class AddLoan
    {
        private readonly densingdbEntities _context = new densingdbEntities();
        public AddLoan()
        { }

        public densingdbEntities _con
        {
            get
            {
                return _context;
            }
        }

        private int client_Id;
        protected double loan_amount;
        protected double interest;
        private PaymentTerm term;
        private int no_of_payment;
        private double deduction;
        private DateTime dueDate;

        public AddLoan(int client_Id, double loan_amount, double interest, PaymentTerm term, int no_of_payment, double deduction) : this()
        {
            this.client_Id = client_Id;
            this.loan_amount = loan_amount;
            this.interest = interest;
            this.term = term;
            this.no_of_payment = no_of_payment;
            this.deduction = deduction;
            dueDate = GetDueDate(no_of_payment, DateTime.Now, term);
        }

        private double InterestedAmount
        {
            get => (loan_amount * interest) / 100;
        }
        private double ReceivableAmount
        {
            get => (loan_amount + InterestedAmount);
        }
        private double TotalPayable
        {
            get => (loan_amount + InterestedAmount) - deduction;
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

        private void addLoanData()
        {
            Loan selectedClientLoan = new Loan();

            selectedClientLoan.ClientId = client_Id;
            selectedClientLoan.Loan_AMT = loan_amount;
            selectedClientLoan.Interest = interest;
            selectedClientLoan.Term = term.ToString();
            selectedClientLoan.NoOf_Payment = no_of_payment;
            selectedClientLoan.Deduction = deduction;
            selectedClientLoan.Interested_AMT = InterestedAmount;
            selectedClientLoan.Receivable_AMT = ReceivableAmount;
            selectedClientLoan.Total_Payable = TotalPayable;
            selectedClientLoan.Due_Date = dueDate;
            selectedClientLoan.Status_Paid = StatusPaid.Active.ToString();

            _con.Loans.Add(selectedClientLoan);
            _con.SaveChanges();
        }

        private bool confirm;
        public bool Confirmation
        {
            get => confirm;
            set
            {
                if (value)
                {
                    DialogResult result = MessageBox.Show($"Loan Amount: {loan_amount}\nInterest: {interest}%\nTerm: {term}\nNo. of Payment: {no_of_payment}\nDeduction {deduction}\nInterested Amount: {InterestedAmount}\nReceivable Amount: {ReceivableAmount}\nTotal Payable: {TotalPayable}\nDue Date: {dueDate}", "Loan Confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        addLoanData();
                    }
                }
                else MessageBox.Show("Unable to add loan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                confirm = value;
            }
        }

        public void setPaidORUnpaid(int loanId)
        {
            Loan selectedLoan = _con.Loans.Where(q => q.LoanID == loanId).FirstOrDefault();

            DialogResult result = MessageBox.Show(
                $"Do you want to set {(selectedLoan.Status_Paid == StatusPaid.Paid.ToString() ? "Active" : "Paid")} the loan ID {loanId}",
                "Delete Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                selectedLoan.Status_Paid = (selectedLoan.Status_Paid == StatusPaid.Paid.ToString() ? "Active" : "Paid");
                _con.SaveChanges();
            }
        }

        public void deleteSelectedLoan(int loanId)
        {
            Loan loanToDelete = _con.Loans.Where(q => q.LoanID == loanId).FirstOrDefault();

            _con.Loans.Remove(loanToDelete);
            _con.SaveChanges();
        }
    }
}
