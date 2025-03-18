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
        private AllContact _allContact;
        private OneContact _oneContact;


        public ControlContact(DataContact data, AddContact addContact, FormMenu menu, AllContact allContact, OneContact oneContact)
        {
            _dataContact = data;
            _addContact = addContact;
            _formMenu = menu;
            _allContact = allContact;
            _oneContact = oneContact;

            _dataContact.controlContact = this;
            _addContact.controlContact = this;
            _formMenu.controlContact = this;
            _allContact.controlContact = this;
            _oneContact.controlContact = this;
        }

        public void configNameTitle(string name)
        {
            _oneContact.nameTitle = name;
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
            else if(nameview == "allContact")
            {
                _allContact.Show();
            }
            else if(nameview == "OneContact")
            { 
                _oneContact.Show();
            }
        }

        /// <summary>
        /// Retourne les informations d'un contact
        /// </summary>
        /// <param name="name"></param>
        public string[] showInfoContact(string name)
        {
            return _dataContact.getContactByName(name);
        }

        /// <summary>
        /// Gère l'ajout d'un contact
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <param name="city"></param>
        public void addNewContact(string name, string phone, string email, string city)
        {
            _dataContact.addContact(name, phone, email, city);
        }
    }
}
