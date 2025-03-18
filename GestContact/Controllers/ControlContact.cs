using GestContact.Models;
using GestContact.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestContact.Controllers
{
    
    public class ControlContact
    {
        private DataContact _dataContact;
        private AddContact _addContact;
        private FormMenu _formMenu;


        public ControlContact(DataContact data, AddContact addContact, FormMenu menu)
        {
            _dataContact = data;
            _addContact = addContact;
            _formMenu = menu;

            _dataContact.controlContact = this;
            _addContact.controlContact = this;
            _formMenu.controlContact = this;


        }

        /// <summary>
        /// Permet de changer de vue
        /// </summary>
        /// <param name="nameview"></param>
        public void changeView(string nameview)
        {
            if(nameview == "Menu")
            {
                _formMenu.Show();
            }
            else if(nameview == "addContact")
            {
                _addContact.Show();
            }
        }

        public void showInfoContact(int id)
        {
            _dataContact.GetClientById(id);
        }

        public void addNewContact(string name, string phone, string email, string city)
        {
            _dataContact.addContact(name, phone, email, city);
        }
    }
}
