using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Transaccion trx = new Retiro("232324", DateTime.Now, 500M);

            Console.ReadKey(true);
        }
    }
}
