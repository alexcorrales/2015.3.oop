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
            Dinero c1 = new Dinero(Dinero.ETipoMoneda.LEMPIRAS, 
                Dinero.EDenominacion.CIEN, 2);
            Dinero c2 = new Dinero(Dinero.ETipoMoneda.LEMPIRAS, 
                Dinero.EDenominacion.QUINIENTOS, 3);
            Dinero c3 = new Dinero(Dinero.ETipoMoneda.LEMPIRAS, 
                Dinero.EDenominacion.CIEN, 1);

            Caja caja = new Caja();
            caja.Agregar(c1);
            caja.Agregar(c2);
            caja.Agregar(c3);

            Console.WriteLine(caja);

            Console.WriteLine("Retiro de L 150.00");
            caja.Quitar(150);

            Console.WriteLine(caja);

            Console.ReadKey(true);
        }
    }
}
