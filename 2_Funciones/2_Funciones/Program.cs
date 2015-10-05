using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multiples parametros
            Console.WriteLine("1 + 2 = {0}", Suma(1, 2));
            Console.WriteLine("1 + 2 + 3 = {0}", Suma(1, 2, 3));

            int valor = 10;
            // Paso por valor (el comun en JAVA)
            Console.WriteLine("Paso por valor antes = {0}", valor);
            Cuadrado_Valor(valor);
            Console.WriteLine("Paso por valor despues = {0}", valor);

            // Paso por refencia (Agregado en C#)
            Console.WriteLine("Paso por referencia antes = {0}", valor);
            Cuadrado_Referencia(ref valor);
            Console.WriteLine("Paso por referencia despues = {0}", valor);

            Console.ReadKey(true);
        }
        
        static int Suma(params int[] parametros)
        {
            int total;

            total = 0;

            foreach (int numero in parametros) {
                total += numero;
            }

            return total;
        }

        static void Cuadrado_Valor(int numero)
        {
            numero = numero * numero;
        }

        static void Cuadrado_Referencia(ref int numero)
        {
            numero = numero * numero;
        }
    }
}
