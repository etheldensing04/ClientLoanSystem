using ClientLoanSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientLoanSystem
{
    internal class AddClient
    {
        private readonly densingdbEntities _context;
        private BindingSource _bindingSource;
        public AddClient()
        { }

        public densingdbEntities _con
        {
            get
            {
                return _context;
            }
        }

        public AddClient(BindingSource _bindingSource) : this()
        {
            _context = new densingdbEntities();
            this._bindingSource = _bindingSource;
        }

        public void addClient(string firstname, string lastname, string residency, DateTime date)
        {
            Entities.Client addClient = new Entities.Client();

            addClient.Firstname = firstname;
            addClient.Lastname = lastname;
            addClient.Residency = residency;
            addClient.Birthday = date;

            _context.Clients.Add(addClient);
            _context.SaveChanges();

            _bindingSource.DataSource = _context.Clients.ToList();
        }
        public void updateClient(int _id, int colIndex, object newVal)
        {

            Entities.Client selectedClient = _context.Clients.FirstOrDefault(q => q.Id == _id);

            switch (colIndex)
            {
                case 0:
                    selectedClient.Firstname = (string)newVal;
                    break;
                case 1:
                    selectedClient.Lastname = (string)newVal;
                    break;
                case 2:
                    selectedClient.Residency = (string)newVal;
                    break;
                case 3:
                    selectedClient.Birthday = (DateTime)newVal;
                    break;
                default:
                    break;
            }

            _context.SaveChanges();
            _bindingSource.DataSource = _context.Clients.ToList();
        }

        public void deleteClient(int _id)
        {
            Entities.Client itemToDelete = _context.Clients.Where(q => q.Id == _id).FirstOrDefault();

            _context.Clients.Remove(itemToDelete);
            _context.SaveChanges();

            _bindingSource.DataSource = _context.Clients.ToList();
        }

        public void searchClient(string text)
        {
            try
            {
                int id;
                bool isId = int.TryParse(text, out id);
                DateTime birthDate;
                bool isBirthDate = DateTime.TryParse(text, out birthDate);

                var result = _context.Clients
                    .Where(c => (isId && c.Id == id) ||
                                c.Firstname.Contains(text) ||
                                c.Lastname.Contains(text) ||
                                c.Residency.Contains(text) ||
                                isBirthDate && c.Birthday == birthDate)
                    .Select(c => new
                    {
                        c.Id,
                        c.Firstname,
                        c.Lastname,
                        c.Residency,
                        c.Birthday
                    })
                    .ToList();

                _bindingSource.DataSource = result;
            }
            catch (Exception ex) { }
        }
    }
}
