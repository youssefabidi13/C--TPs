using System;

namespace Exercice1 // Note: actual namespace depends on the project name.
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