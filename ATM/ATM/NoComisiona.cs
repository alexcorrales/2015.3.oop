using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class NoComisiona : IComisionable
    {
        public void Comisionar()
        {
            Console.WriteLine("No comisiona");
        }
    }
}
