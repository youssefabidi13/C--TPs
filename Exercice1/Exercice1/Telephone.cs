using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    internal class Telephone
    {
        protected String phonetype;

        public void Ring()
        {
            Console.WriteLine("Ringing the " + this.phonetype);
        }
    }
}
