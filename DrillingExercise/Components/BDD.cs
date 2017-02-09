using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Drilling
{
    public class BDD
    {
        private static MySqlConnection connection = new MySqlConnection("SERVER=localhost; DATABASE=drilling; UID=root; PASSWORD=");

        // Constructeur
        public BDD()
        {

        }


        public static int ExistingUser(string mail)
        {
            try
            {
                // Ouverture de la connexion SQL
                connection.Open();

                //On regarde si il n'y pas déjà un utilisateur avec cet e-mail
                string stm = "SELECT COUNT(*) FROM users WHERE mail='" + mail + "'";
                MySqlCommand cmd = new MySqlCommand(stm, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();

                if (rdr.GetUInt32(0) == 0) //'utilisateur n'existe pas encore
                {
                    rdr.Close();
                    return 0;
                }
                else
                {
                    rdr.Close();
                    return 1;
                }
            }
            catch
            {
                return 2;
            }
            finally
            {
                connection.Close();
            }
        }



        // Méthode pour ajouter un contact
        public static int AddUser(User u)
        {
            try
            {
                // Ouverture de la connexion SQL
                BDD.connection.Open();

                //On regarde si il n'y pas déjà un utilisateur avec cet e-mail
                string stm = "SELECT COUNT(*) FROM users WHERE mail='" + u.Mail + "'";
                MySqlCommand cmd0 = new MySqlCommand(stm, connection);
                MySqlDataReader rdr = cmd0.ExecuteReader();
                rdr.Read();

                if (rdr.GetUInt32(0) == 0)
                {
                    rdr.Close();
                    // Création d'une commande SQL en fonction de l'objet connection
                    MySqlCommand cmd = BDD.connection.CreateCommand();

                    // Requête SQL
                    cmd.CommandText = "INSERT INTO users (name, firstName, mail, password) VALUES (@name, @firstName, @mail, @password)";

                    // utilisation de l'objet contact passé en paramètre
                    cmd.Parameters.AddWithValue("@name", u.Name);
                    cmd.Parameters.AddWithValue("@firstName", u.FirstName);
                    cmd.Parameters.AddWithValue("@mail", u.Mail);
                    cmd.Parameters.AddWithValue("@password", u.Password);

                    // Exécution de la commande SQL
                    cmd.ExecuteNonQuery();

                    return 0;
                }
                else
                {
                    rdr.Close();
                    return 1;
                }

            }
            catch
            {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le contact à été ajouté correctement.
                return 2;
            }
            finally
            {
                // Fermeture de la connexion
                BDD.connection.Close();
            }
        }
    }
}
