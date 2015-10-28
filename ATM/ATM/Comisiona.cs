using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Comisiona : IComisionable
    {
        public void Comisionar()
        {
            Console.WriteLine("Comisiona");
        }
    }
}
