using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadenas_Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "Hola mundo";
            string cadena2 = "Otra frase";
            string parte = "o";

            if (cadena.Contains("o"))
            {
                Console.WriteLine("La cadena {0}, contiene una '{1}'", cadena, parte);
            }

            if (cadena.Equals(cadena2))
            {
                Console.WriteLine("Las cadenas son iguales");
            }
            else
            {
                Console.WriteLine("Las cadenas son distintas");
            }

            Console.WriteLine("Mayuscula = {0}", cadena.ToUpper());
            Console.WriteLine("Minuscula = {0}", cadena.ToLower());
            Console.WriteLine("Substring(0, 4) = {0}", cadena.Substring(0, 4));

            Console.WriteLine("Sin trim = {0}{1}", "hola     ", "|");
            Console.WriteLine("Con trim = {0}{1}", "hola     ".Trim(), "|");

            ConcatenacionTest();
            
            Console.ReadKey(true); 
        }

        static void ConcatenacionTest()
        {
            const int sLen = 30, Loops = 50000;
            DateTime sTime, eTime;
            string sSource = new String('X', sLen);
            string sDest = "";

            sTime = DateTime.Now;
            for (int i = 0; i < Loops; i++)
            {
                sDest += sSource;
            }

            eTime = DateTime.Now;
            Console.WriteLine("La string tarda " + (eTime - sTime).TotalSeconds + " segundos.");


            // Time StringBuilder.
            sTime = DateTime.Now;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            for (int i = 0; i < Loops; i++)
            {
                sb.Append(sSource);
            }
            sDest = sb.ToString();
            eTime = DateTime.Now;
            Console.WriteLine("El StringBuilder tarda " + (eTime - sTime).TotalSeconds + " segundos."); 
        }
    }
}
