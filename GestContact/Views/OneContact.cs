using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestContact.Controllers;

namespace GestContact.Views
{
    public partial class OneContact : Form
    {
        ControlContact _controlContact;
        public ControlContact controlContact { get { return _controlContact; } set { _controlContact = value; } }

        private int _contactID;
        private string _nameTitle;
        private string _name;
        private string _phone;
        private string _city;
        private string _email;

        public int contactID { get { return _contactID; } set { _contactID = value; } }
        public string nameTitle { get { return _nameTitle; } set { _nameTitle = value; } }
        public string name { get { return _name; } set { _name = value; } }
        public string phone { get { return _phone; } set { _phone = value; } }
        public string city { get { return _city; } set { _city = value; } }
        public string email { get { return _email; } set { _email = value; } }

        public OneContact()
        {
            InitializeComponent();
        }

        public void preConfigFields()
        {
            lbl_TitleName.Text = _nameTitle;
            txt_Name.Text = _name;
            txt_Phone.Text = _phone;
            txt_Email.Text = _email;
            txt_City.Text = _city;
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            _controlContact.changeView("Menu");
        }

        /// <summary>
        /// Sauvegarde les modifications effectuées sur un contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            _controlContact.updateAContact(_contactID, txt_Name.Text, txt_Phone.Text, txt_Email.Text, txt_City.Text);
        }

        /// <summary>
        /// Si un textbox change, le bouton de sauvegarde s'active
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label4_TextChanged(object sender, EventArgs e)
        {
            if(txt_City.Text == _city && txt_Email.Text == _email && txt_Name.Text == _name && txt_Phone.Text == _phone)
            {
                btn_Save.Enabled = false;
            }
            else
            {
                btn_Save.Enabled = true;
            }
        }

        /// <summary>
        /// Supprime un contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void img_delete_Click(object sender, EventArgs e)
        {
            _controlContact.deleteAContact(_contactID);
        }
    }
}
