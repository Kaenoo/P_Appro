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

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            _controlContact.changeView("Menu");
        }
    }
}
