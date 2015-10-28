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
            trx.Comisionar();

            Transaccion trx2 = new Retiro("32i4u324", DateTime.Now, 200M);
            trx2.Comisionar();

            Console.ReadKey(true);
        }
    }
}
