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
    public partial class AllContact : Form
    {
        ControlContact _controlContact;
        public ControlContact controlContact { get { return _controlContact; } set { _controlContact = value; } }

        public AllContact()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Retourne au menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            _controlContact.changeView("Menu");
        }

        /// <summary>
        /// Affiche les informations des contacts dans le panel
        /// </summary>
        public void UpdatePanel()
        {
            List<string[]> contacts = _controlContact.getContacts();

            // Effacer les anciennes lignes sauf l’en-tête (si besoin)
            tab_lay_panel_contact.Controls.Clear();
            tab_lay_panel_contact.RowStyles.Clear();
            tab_lay_panel_contact.RowCount = contacts.Count;

            for (int i = 0; i < contacts.Count; i++)
            {
                // Ajouter les valeurs dans les colonnes
                Label lblName = new Label() { Text = contacts[i][1], AutoSize = true };
                Label lblPhone = new Label() { Text = contacts[i][2], AutoSize = true };
                Label lblEmail = new Label() { Text = contacts[i][3], AutoSize = true };
                Label lblCity = new Label() { Text = contacts[i][4], AutoSize = true };

                // Ajouter les labels dans le TableLayoutPanel
                tab_lay_panel_contact.Controls.Add(lblName, 0, i);
                tab_lay_panel_contact.Controls.Add(lblPhone, 1, i);
                tab_lay_panel_contact.Controls.Add(lblEmail, 2, i);
                tab_lay_panel_contact.Controls.Add(lblCity, 3, i);
            }
        }
    }
}
