using Exercice2;
using System;

namespace Exercice2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectronicPhone child = new ElectronicPhone("Digital");
            child.Ring();
        }
    }
}