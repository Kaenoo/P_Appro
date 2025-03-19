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

        public void configNameTitle(string[] infocontact)
        {
            _oneContact.contactID = Convert.ToInt16(infocontact[0]);
            _oneContact.nameTitle = infocontact[1];
            _oneContact.name = infocontact[1];
            _oneContact.phone= infocontact[2];
            _oneContact.email = infocontact[3];
            _oneContact.city = infocontact[4];
        }

        /// <summary>
        /// Permet de changer de vue
        /// </summary>
        /// <param titleName="nameview"></param>
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
                _allContact.UpdatePanel();
                _allContact.Show();
            }
            else if(nameview == "OneContact")
            {
                _oneContact.preConfigFields();
                _oneContact.Show();
            }
        }

        /// <summary>
        /// Retourne les informations d'un contact
        /// </summary>
        /// <param titleName="name"></param>
        public string[] showInfoContact(string name)
        {
            return _dataContact.getContactByName(name);
        }

        /// <summary>
        /// Gère l'ajout d'un contact
        /// </summary>
        /// <param titleName="name"></param>
        /// <param titleName="phone"></param>
        /// <param titleName="email"></param>
        /// <param titleName="city"></param>
        public void addNewContact(string name, string phone, string email, string city)
        {
            _dataContact.addContact(name, phone, email, city);
        }
        
        /// <summary>
        /// Gère la mise à jour d'un contact
        /// </summary>
        /// <param name="idContact"></param>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <param name="city"></param>
        public void updateAContact(int idContact, string name, string phone, string email, string city)
        {
            _dataContact.updateContact(idContact, name, phone, email, city);
        }

        /// <summary>
        /// Gère la récupération de tous les contacts
        /// </summary>
        /// <returns></returns>
        public List<string[]> getContacts()
        {
            return _dataContact.getAllContact();
        }

        /// <summary>
        /// Gère la suppression d'un contact
        /// </summary>
        /// <param name="idContact"></param>
        public void deleteAContact(int idContact)
        {
            _dataContact.deleteContact(idContact);
        }
    }
}
