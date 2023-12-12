using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    internal class ElectronicPhone: Telephone
    {
        public ElectronicPhone(String phoneType)
        {
            phonetype = phoneType;
        }
        public override void Ring()
        {
            Console.WriteLine("Custom ringing message for the " + this.phonetype);
        }
    }
}
