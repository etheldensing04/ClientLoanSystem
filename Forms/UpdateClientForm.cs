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
    public partial class UpdateClientForm : Form
    {
        private AddClient db;
        private BindingSource _bindingSource;
        private int currentClientId;
        public UpdateClientForm()
        {
            InitializeComponent();
        }

        private int colIdx;
        public UpdateClientForm(int currentClientId, int colIdx, BindingSource _bindingSource) : this()
        {
            this._bindingSource = _bindingSource;
            this.currentClientId = currentClientId;
            this.colIdx = colIdx;
        }

        public object NewVal { get; set; }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            switch (colIdx)
            {
                case 1:
                    NewVal = firstname_val.Text.Trim();
                    break;
                case 2:
                    NewVal = lastname_val.Text.Trim();
                    break;
                case 3:
                    NewVal = residency_val.Text.Trim();
                    break;
                case 4:
                    NewVal = birthday_val.Value;
                    break;
                default:
                    break;
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void UpdateClientForm_Load(object sender, EventArgs e)
        {
            db = new AddClient(_bindingSource);
            Entities.Client selectedClient = db._con.Clients.FirstOrDefault(q => q.Id == currentClientId);
            switch (colIdx)
            {
                case 1:
                    firstname_val.Enabled = true;
                    firstname_val.Text = selectedClient.Firstname;
                    break;
                case 2:
                    lastname_val.Enabled = true;
                    lastname_val.Text = selectedClient.Lastname;
                    break;
                case 3:
                    residency_val.Enabled = true;
                    residency_val.Text = selectedClient.Residency;
                    break;
                case 4:
                    birthday_val.Enabled = true;
                    birthday_val.Value = (DateTime)selectedClient.Birthday;
                    break;
                default:
                    break;
            }
        }
    }
}
