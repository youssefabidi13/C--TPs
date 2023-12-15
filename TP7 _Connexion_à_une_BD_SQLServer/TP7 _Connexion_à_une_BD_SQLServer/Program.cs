using System;
using System.Data.SqlClient;
using TP7__Connexion_à_une_BD_SQLServer;

namespace TP7__Connexion_à_une_BD_SQLServer
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=MyTestDB;Integrated Security=True";

            try
            {
                // Créer la connexion SqlConnection
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Connexion établie avec succès");

                    while (true)
                    {
                        // Display menu options
                        Console.WriteLine("\nMenu:");
                        Console.WriteLine("1. Ajouter un client");
                        Console.WriteLine("2. Mettre à jour un client");
                        Console.WriteLine("3. Supprimer un client");
                        Console.WriteLine("4. Ajouter une commande");
                        Console.WriteLine("5. Mettre à jour une commande");
                        Console.WriteLine("6. Supprimer une commande");
                        Console.WriteLine("7. Lister les clients");
                        Console.WriteLine("8. Lister les commandes");
                        Console.WriteLine("0. Quitter");
                        Console.Write("Choisissez une option (0-6): ");

                        // Get user choice
                        string choice = Console.ReadLine();

                        switch (choice)
                        {
                            case "1":
                                Console.WriteLine("\nAjouter un client:");
                                Console.Write("Nom: ");
                                string nom = Console.ReadLine();
                                Console.Write("Prenom: ");
                                string prenom = Console.ReadLine();
                                Console.Write("Adresse: ");
                                string adresse = Console.ReadLine();
                                Console.Write("Numéro de téléphone: ");
                                string numTel = Console.ReadLine();
                                QueryExecutor.ExecuteInsertClient(conn, nom, prenom, adresse, numTel);
                                break;

                            case "2":
                                Console.WriteLine("\nMettre à jour un client:");
                                Console.Write("Numéro du client à mettre à jour: ");
                                int numClientToUpdate = int.Parse(Console.ReadLine());
                                Console.Write("Nouveau nom: ");
                                string newNom = Console.ReadLine();
                                Console.Write("Nouvelle adresse: ");
                                string newAdresse = Console.ReadLine();
                                QueryExecutor.ExecuteUpdateClient(conn, numClientToUpdate, newNom, newAdresse);
                                break;

                            case "3":
                                Console.WriteLine("\nSupprimer un client:");
                                Console.Write("Numéro du client à supprimer: ");
                                int numClientToDelete = int.Parse(Console.ReadLine());
                                QueryExecutor.ExecuteDeleteClient(conn, numClientToDelete);
                                break;

                            case "4":
                                Console.WriteLine("\nAjouter une commande:");
                                Console.Write("Numéro du client pour la commande: ");
                                int numClientForCommande = int.Parse(Console.ReadLine());
                                Console.Write("Date de la commande (au format YYYY-MM-DD): ");
                                DateTime dateComd = DateTime.Parse(Console.ReadLine());
                                Console.Write("État de la commande: ");
                                int etatComd = int.Parse(Console.ReadLine());
                                QueryExecutor.ExecuteInsertCommande(conn, numClientForCommande, dateComd, etatComd);
                                break;

                            case "5":
                                Console.WriteLine("\nMettre à jour une commande:");
                                Console.Write("Numéro de la commande à mettre à jour: ");
                                int numComdToUpdate = int.Parse(Console.ReadLine());
                                Console.Write("Nouvelle date de la commande (au format YYYY-MM-DD): ");
                                DateTime newDateComd = DateTime.Parse(Console.ReadLine());
                                Console.Write("Nouvel état de la commande: ");
                                int newEtatComd = int.Parse(Console.ReadLine());
                                QueryExecutor.ExecuteUpdateCommande(conn, numComdToUpdate, newDateComd, newEtatComd);
                                break;

                            case "6":
                                Console.WriteLine("\nSupprimer une commande:");
                                Console.Write("Numéro de la commande à supprimer: ");
                                int numComdToDelete = int.Parse(Console.ReadLine());
                                QueryExecutor.ExecuteDeleteCommande(conn, numComdToDelete);
                                break;

                            case "7":  // Add a new case for listing clients
                                Console.WriteLine("\nListe des clients:");
                                QueryExecutor.ExecuteAndDisplayQuery(conn, "SELECT * FROM Clients");
                                break;

                            case "8":  // Add a new case for listing commandes
                                Console.WriteLine("\nListe des commandes:");
                                QueryExecutor.ExecuteAndDisplayCommandesQuery(conn, "SELECT * FROM Commandes");
                                break;

                            case "0":
                                // Quit the program
                                return;

                            default:
                                Console.WriteLine("Option non valide. Veuillez choisir une option valide.");
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connexion échouée: {0}", ex.Message);
            }

            Console.Read();
        }
    }
}
