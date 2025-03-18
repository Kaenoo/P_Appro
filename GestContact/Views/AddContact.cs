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
using System.Text.RegularExpressions;

namespace GestContact.Views
{
    public partial class AddContact : Form
    {
        ControlContact _controlContact;
        public ControlContact controlContact { get { return _controlContact; } set { _controlContact = value; } }


        private string regexPattern = @"^[A-Za-z' -]{2,50}$";
        private string regexPatternEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        private string regexPatternTel = @"^[0-9]{3} [0-9]{3} [0-9]{2} [0-9]{2}$";


        public AddContact()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Enlève le texte présent dans chacun des labels
        /// </summary>
        public void clearLabel()
        {
            txt_Name.Text = "";
            txt_Phone.Text = "";
            txt_Email.Text = "";
            txt_City.Text = "";
        }

        /// <summary>
        /// Annuler pour revenir au menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Undo_Click(object sender, EventArgs e)
        {
            this.Hide();
            _controlContact.changeView("Menu");
            clearLabel();
        }

        /// <summary>
        /// Sauvegarder un contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
           if(Regex.IsMatch(txt_Name.Text, regexPattern) && Regex.IsMatch(txt_Phone.Text, regexPatternTel) && Regex.IsMatch(txt_Email.Text, regexPatternEmail) && Regex.IsMatch(txt_City.Text, regexPattern)){
                _controlContact.addNewContact(txt_Name.Text, txt_Phone.Text, txt_Email.Text, txt_City.Text);
                //MessageBox.Show("Le contact a bien été enregistré !");
                this.Hide();
                _controlContact.changeView("Menu");
                clearLabel();
            }
            else
            {
                MessageBox.Show("Respectez les pattern précisés !");
            }

        }

    }
}
