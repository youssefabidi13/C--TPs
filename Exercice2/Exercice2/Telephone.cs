using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    internal class Telephone
    {
        protected String phonetype;

        public virtual void Ring()
        {
            Console.WriteLine("Ringing the " + this.phonetype);
        }

    }
}
