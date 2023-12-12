using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class RefCirculaire
    {
        public static int compteur = 0;
        static void Main(string[] args)
        {
            ClassA classA = new ClassA();
            Console.WriteLine(RefCirculaire.compteur);
        }
    }
}
