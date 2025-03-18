namespace GestContact
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Creation of views
            FormMenu formMenu = new FormMenu();
            Views.AddContact addContact = new Views.AddContact();
            Views.AllContact allContact = new Views.AllContact();
            Views.OneContact oneContact = new Views.OneContact();

            // Creation of model
            Models.DataContact data = new Models.DataContact();

            // Creation of controller
            Controllers.ControlContact controlContact = new Controllers.ControlContact(data, addContact, formMenu, allContact, oneContact);

            Application.Run(formMenu);
        }
    }
}