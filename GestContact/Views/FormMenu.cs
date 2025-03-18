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
    }
}