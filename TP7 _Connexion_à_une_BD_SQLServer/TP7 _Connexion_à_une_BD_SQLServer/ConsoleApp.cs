using System;
using System.Data.SqlClient;

namespace TP7__Connexion_à_une_BD_SQLServer
{
    public static class ConsoleApp
    {
        public static void DisplayResultsClients(SqlDataReader reader)
        {
            if (reader != null)
            {
                while (reader.Read())
                {
                    Console.WriteLine("Clients: {0} {1} {2} {3} {4}",
                        reader["NumClient"], reader["NomClient"],
                        reader["PrenomClient"], reader["AdresseClient"],
                        reader["NumTelClient"]);
                }
            }
        }

        public static void DisplayResultsCommandes(SqlDataReader reader)
        {
            if (reader != null)
            {
                while (reader.Read())
                {
                    Console.WriteLine("Commandes: {0} {1} {2} {3}",
                        reader["NumComd"], reader["NumClient"],
                        reader["DateComd"], reader["EtatComd"]);
                }
            }
        }
    }
}
