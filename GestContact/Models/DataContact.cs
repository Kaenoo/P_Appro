using System;
using System.Windows.Forms;
using GestContact.Controllers;
using MySql.Data.MySqlClient;

namespace GestContact.Models
{
    public class DataContact
    {
        private string myConnectionString = "datasource=localhost;port=6033;username=root;password=root;database=db_gestContact;";
        private MySqlConnection myConnection;

        private ControlContact _controlContact;
        public ControlContact controlContact { get; set; }

        private string name;
        private string email;
        private string phone;
        private string city;

        public DataContact()
        {
            myConnection = new MySqlConnection(myConnectionString);
        }


/*        public void TestConnection()
        {
            try
            {
                myConnection.Open();
                MessageBox.Show("Connexion réussie !");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Échec de la connexion : {ex.Message}");
            }
            finally
            {
                myConnection.Close();
            }
        }*/

        /// <summary>
        /// Récupère les informations d'un client
        /// </summary>
        /// <param name="idContact"></param>
        public void GetContactById(int idContact)
        {
            try
            {
                myConnection.Open();
                MySqlCommand myCommand = new MySqlCommand(@"SELECT * FROM t_contact WHERE idContact = @idContact;", myConnection);
                myCommand.Parameters.AddWithValue("@idContact", idContact);

                using (MySqlDataReader myReader = myCommand.ExecuteReader())
                {
                    if (myReader.Read()) // Lire la première ligne trouvée
                    {
                        int id = myReader.GetInt32("idContact");
                        name = myReader.GetString("Name");
                        email = myReader.GetString("Phone");
                        phone = myReader.GetString("Email");
                        city = myReader.GetString("City");

                        MessageBox.Show($"Client trouvé : {name}, {email}, {phone}, {city}");
                    }
                    else
                    {
                        MessageBox.Show("Aucun client trouvé avec cet ID.");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur MySQL : {ex.Message}");
            }
            finally
            {
                myConnection.Close();
            }
        }

        /// <summary>
        /// Récupère les informations d'un contact avec son nom
        /// </summary>
        /// <param name="name"></param>
        public string[] getContactByName(string name)
        {
            try
            {
                myConnection.Open();
                MySqlCommand myCommand = new MySqlCommand(@"SELECT * FROM t_contact WHERE Name LIKE @Name;", myConnection);
                myCommand.Parameters.AddWithValue("@Name", "%" + name + "%");

                using (MySqlDataReader myReader = myCommand.ExecuteReader())
                {
                    if (myReader.Read()) // Lire la première ligne trouvée
                    {
                        int id = myReader.GetInt32("idContact");
                        name = myReader.GetString("Name");
                        string email = myReader.GetString("Phone");
                        string phone = myReader.GetString("Email");
                        string city = myReader.GetString("City");

                        return new string[] { id.ToString(), name, email, phone, city };

                        //MessageBox.Show($"Client trouvé : {name}, {email}, {phone}, {city}");
                    }
                    else
                    {
                        MessageBox.Show("Aucun client trouvé avec ce nom.");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur MySQL : {ex.Message}");
            }
            finally
            {
                myConnection.Close();
            }

            return null;
        }


        /// <summary>
        /// Ajouter un contact
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <param name="city"></param>
        public void addContact(string name, string phone, string email, string city)
        {
            try
            {
                myConnection.Open();
                MySqlCommand myCommand = new MySqlCommand(@"
            INSERT INTO t_contact (Name, Phone, Email, City) 
            VALUES (@name, @phone, @email, @city);", myConnection);

                myCommand.Parameters.AddWithValue("@name", name);
                myCommand.Parameters.AddWithValue("@phone", phone);
                myCommand.Parameters.AddWithValue("@email", email);
                myCommand.Parameters.AddWithValue("@city", city);

                int rowsAffected = myCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Contact ajouté avec succès !");
                }
                else
                {
                    MessageBox.Show("Échec de l'ajout du contact.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur MySQL : {ex.Message}");
            }
            finally
            {
                myConnection.Close();
            }
        }

        /// <summary>
        /// Supprime un contact
        /// </summary>
        /// <param name="idContact"></param>
        public void deleteContact(int idContact)
        {
            try
            {
                myConnection.Open();
                MySqlCommand myCommand = new MySqlCommand(@"DELETE FROM `t_contact` WHERE `idContact` = @idContact;", myConnection);

                myCommand.Parameters.AddWithValue("@idContact", idContact);

                int rowsAffected = myCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Contact supprimé avec succès !");
                }
                else
                {
                    MessageBox.Show("Échec de la suppression du contact.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur MySQL : {ex.Message}");
            }
            finally
            {
                myConnection.Close();
            }
        }

        /// <summary>
        /// Met à jour un contact
        /// </summary>
        /// <param name="idContact"></param>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <param name="city"></param>
        public void updateContact(int idContact,string name, string phone, string email, string city)
        {
            try
            {
                myConnection.Open();
                MySqlCommand myCommand = new MySqlCommand(@"UPDATE `t_contact` SET `Name`= @name,
                                `Phone`= @phone,`Email`= @email,`City`= @city WHERE `idContact` = @idContact;", myConnection);

                myCommand.Parameters.AddWithValue("@idContact", idContact);
                myCommand.Parameters.AddWithValue("@name", name);
                myCommand.Parameters.AddWithValue("@phone", phone);
                myCommand.Parameters.AddWithValue("@email", email);
                myCommand.Parameters.AddWithValue("@city", city);

                int rowsAffected = myCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Contact mis à jour avec succès !");
                }
                else
                {
                    MessageBox.Show("Échec de mise à jour du contact.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur MySQL : {ex.Message}");
            }
            finally
            {
                myConnection.Close();
            }
        }

        /// <summary>
        /// Récupère tous les contacts
        /// </summary>
        /// <returns></returns>
        public List<string[]> getAllContact()
        {
            List<string[]> contacts = new List<string[]>();

            try
            {
                myConnection.Open();
                MySqlCommand myCommand = new MySqlCommand(@"SELECT * FROM `t_contact`;", myConnection);

                using (MySqlDataReader myReader = myCommand.ExecuteReader())
                {
                    while (myReader.Read()) // Lire toutes les lignes
                    {
                        int id = myReader.GetInt32("idContact");
                        string name = myReader.GetString("Name");
                        string phone = myReader.GetString("Phone");
                        string email = myReader.GetString("Email");
                        string city = myReader.GetString("City");

                        contacts.Add(new string[] { id.ToString(), name, phone, email, city });
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur MySQL : {ex.Message}");
            }
            finally
            {
                myConnection.Close();
            }

            return contacts;
        }
    }
}