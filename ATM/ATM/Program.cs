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
            Transaccion trx = new Login("12129u12", DateTime.Now);

            Console.WriteLine(trx);

            Console.ReadKey(true);
        }
    }
}
