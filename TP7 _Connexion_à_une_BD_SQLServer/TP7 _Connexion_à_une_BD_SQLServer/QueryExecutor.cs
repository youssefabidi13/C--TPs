using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7__Connexion_à_une_BD_SQLServer
{
    public static class QueryExecutor
    {
        public static void ExecuteAndDisplayQuery(SqlConnection conn, string sqlQuery)
        {
            try
            {
                using (SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn))
                {
                    using (SqlDataReader reader = sqlCmd.ExecuteReader())
                    {
                        ConsoleApp.DisplayResultsClients(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'exécution de la requête: {0}", ex.Message);
            }
        }

        public static void ExecuteAndDisplayCommandesQuery(SqlConnection conn, string sqlQuery)
        {
            try
            {
                using (SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn))
                {
                    using (SqlDataReader reader = sqlCmd.ExecuteReader())
                    {
                        ConsoleApp.DisplayResultsCommandes(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'exécution de la requête: {0}", ex.Message);
            }
        }
        public static void ExecuteInsertClient(SqlConnection conn, string nom, string prenom, string adresse, string numTel)
        {
            try
            {
                string sqlQuery = $"INSERT INTO Clients (NomClient, PrenomClient, AdresseClient, NumTelClient) VALUES ('{nom}', '{prenom}', '{adresse}', '{numTel}')";

                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, conn))
                {
                    sqlCommand.ExecuteNonQuery();
                }

                Console.WriteLine("Client ajouté avec succès.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'ajout du client : {0}", ex.Message);
            }
        }

        public static void ExecuteUpdateClient(SqlConnection conn, int numClient, string newNom, string newAdresse)
        {
            try
            {
                string sqlQuery = $"UPDATE Clients SET NomClient = '{newNom}', AdresseClient = '{newAdresse}' WHERE NumClient = {numClient}";

                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, conn))
                {
                    sqlCommand.ExecuteNonQuery();
                }

                Console.WriteLine("Client mis à jour avec succès.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la mise à jour du client : {0}", ex.Message);
            }
        }

        public static void ExecuteDeleteClient(SqlConnection conn, int numClient)
        {
            try
            {
                string sqlQuery = $"DELETE FROM Clients WHERE NumClient = {numClient}";

                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, conn))
                {
                    sqlCommand.ExecuteNonQuery();
                }

                Console.WriteLine("Client supprimé avec succès.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la suppression du client : {0}", ex.Message);
            }
        }

        public static void ExecuteInsertCommande(SqlConnection conn, int numClient, DateTime dateComd, int etatComd)
        {
            try
            {
                string sqlQuery = $"INSERT INTO Commandes (NumClient, DateComd, EtatComd) VALUES ({numClient}, '{dateComd.ToString("yyyy-MM-dd")}', {etatComd})";

                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, conn))
                {
                    sqlCommand.ExecuteNonQuery();
                }

                Console.WriteLine("Commande ajoutée avec succès.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'ajout de la commande : {0}", ex.Message);
            }
        }
        public static void ExecuteUpdateCommande(SqlConnection conn, int numComd, DateTime newDateComd, int newEtatComd)
        {
            try
            {
                string sqlQuery = $"UPDATE Commandes SET DateComd = '{newDateComd.ToString("yyyy-MM-dd")}', EtatComd = {newEtatComd} WHERE NumComd = {numComd}";

                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, conn))
                {
                    sqlCommand.ExecuteNonQuery();
                }

                Console.WriteLine("Commande mise à jour avec succès.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la mise à jour de la commande : {0}", ex.Message);
            }
        }

        public static void ExecuteDeleteCommande(SqlConnection conn, int numComd)
        {
            try
            {
                string sqlQuery = $"DELETE FROM Commandes WHERE NumComd = {numComd}";

                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, conn))
                {
                    sqlCommand.ExecuteNonQuery();
                }

                Console.WriteLine("Commande supprimée avec succès.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la suppression de la commande : {0}", ex.Message);
            }
        }
    }
}

