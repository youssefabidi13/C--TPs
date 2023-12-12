using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class ClassB
    {
        ClassA ObjA;
        int[] Table = new int[50000];

        public ClassB()
        {
            RefCirculaire.compteur++;
            ObjA = new ClassA();
        }
    }
}
