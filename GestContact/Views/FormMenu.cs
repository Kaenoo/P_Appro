using GestContact.Controllers;
namespace GestContact
{
    public partial class FormMenu : Form
    {
        ControlContact _controlContact;

        public ControlContact controlContact { get { return _controlContact; } set { _controlContact = value; } }

        public FormMenu()
        {
            InitializeComponent();
        }

        // Add a contact
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            _controlContact.changeView("addContact");
        }

        private void img_Search_Click(object sender, EventArgs e)
        {

            if (txt_Search.Text.Length > 0)
            {
                string[] infoContact = _controlContact.showInfoContact(txt_Search.Text);
                
                if(infoContact != null)
                {
                    this.Hide();
                    _controlContact.configNameTitle(infoContact[1]);
                    _controlContact.changeView("OneContact");
                }
               
            }
            else
            {
                MessageBox.Show("Entrez le nom d'un contact !");
            }
        }

        private void txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            // Si le bouton ENTER est press�, v�rifie la longueur du texte et cherche un contact en cons�quence
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_Search.Text.Length > 0)
                {
                    // Retourne un tableau null ou avec les donnn�es du contact
                    string[] infoContact = _controlContact.showInfoContact(txt_Search.Text);

                    if (infoContact != null)
                    {
                        this.Hide();
                        _controlContact.configNameTitle(infoContact[1]);
                        _controlContact.changeView("OneContact");
                    }
                }
                else
                {
                    MessageBox.Show("Entrez le nom d'un contact !");
                }
            }
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            this.Hide();
            _controlContact.changeView("allContact");
        }
    }
}