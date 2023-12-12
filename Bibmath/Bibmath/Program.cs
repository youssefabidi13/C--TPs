using BibilothequeMath;
using System;

namespace Bibmath
    {
    class Program
    {
        static void Main()
        {
            // Appelez la méthode Add de la classe Addition
            int sum = Addition.Add(5, 3);
            Console.WriteLine($"Addition: 5 + 3 = {sum}");


            // Appelez la méthode Multiply de la classe Multiplication
            int product = Multiplication.Multipl(4, 6);
            Console.WriteLine($"Multiplication: 4 * 6 = {product}");

            // Attendez que l'utilisateur appuie sur une touche avant de fermer la console
            Console.ReadKey();
        }
    }

}
