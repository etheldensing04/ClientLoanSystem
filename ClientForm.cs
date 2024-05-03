using ClientLoanSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientLoanSystem
{
    public partial class ClientForm : Form
    {
        private AddClient db;
        public ClientForm()
        {
            InitializeComponent();
        }


        private void viewLoanBtn_Click(object sender, EventArgs e)
        {
           LoanForm openLoan = new LoanForm(1);
            openLoan.ShowDialog();
        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            AddClientForm newClient = new AddClientForm();

            if (newClient.ShowDialog() == DialogResult.OK)
            {
                string fname = newClient.Firstname;
                string lname = newClient.Lastname;
                string residency = newClient.Residency;
                DateTime birthday = newClient.Birthday;

                db.addClient(fname, lname, residency, birthday);
            }
        }


        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (getSelectedCol > 0)
            {
                UpdateClientForm editClient = new UpdateClientForm(getSelectedId, getSelectedCol, clientBindingSource);
                if (editClient.ShowDialog() == DialogResult.OK)
                {
                    db.updateClient(getSelectedId, getSelectedCol - 1, editClient.NewVal);
                }
            }
        }


        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Imoha na ba ning e delete? {getSelectedId}", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                db.deleteClient(getSelectedId);
            }
        }


        private void ClientForm_Load(object sender, EventArgs e)
        {
            db = new AddClient(clientBindingSource);
            clientBindingSource.DataSource = db._con.Clients.ToList();
        }


        private int getSelectedId;
        private void clientTable_SelectionChanged(object sender, EventArgs e)
        {
            if (clientTable.SelectedRows.Count == 0)
            {
                return;
            }

            getSelectedId = (int)clientTable.SelectedRows[0].Cells[0].Value;
        }


        private int getSelectedCol;
        private void clientTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (clientTable.SelectedCells.Count > 0)
            {
                getSelectedCol = e.ColumnIndex;
            }
        }


        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            db.searchClient(searchTextBox.Text.Trim());
        }
    }
}
