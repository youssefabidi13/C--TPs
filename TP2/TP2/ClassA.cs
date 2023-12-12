using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class ClassA
    {
        ClassB ObjB;
        int[] Table = new int[50000];

        public ClassA()
        {
            RefCirculaire.compteur++;
            ObjB = new ClassB();
        }
    }
}
