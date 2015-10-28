using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Tarjeta t1 = new Tarjeta("1234 0403 2202 2245", "Banco Las Piedra", "Alma Morales", 12, 2017);
            Console.WriteLine(t1);

            Tarjeta t2 = new TarjetaDebito("1223 3344 3343 4566", "Banco de America", "Jose Cantor", 11, 2020, 500M);
            Console.WriteLine(t2);

            Console.ReadKey(true);
        }
    }
}
