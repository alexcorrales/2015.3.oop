using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lista: una alternativa dinámica a los arreglos
            Console.WriteLine("--- List ---");
            List<string> listaString = new List<string>();
            listaString.Add("hola");
            listaString.Add("mundo");
            listaString.Add("hoy");

            listaString.Remove("hoy");

            foreach (string str in listaString)
            {
                Console.WriteLine("\t" + str);
            }

            Console.WriteLine("Elemento 0: " + listaString[0]);

            // Diccionarios: Colecciones con llave y valor, la llave no puede repetirse.
            Console.WriteLine("\n--- Dictionary ---");
            Dictionary<int, string> diccionario = new Dictionary<int, string>();
            diccionario.Add(1, "hola");
            diccionario.Add(2, "mundo");
            diccionario.Add(3, "jjjj");

            diccionario.Remove(3);

            foreach (string str in diccionario.Values)
            {
                Console.WriteLine("\t" + str);
            }

            // Pila
            Console.WriteLine("\n--- Stack (Pila) ---");
            Stack<string> pila = new Stack<string>();            
            pila.Push("primero");
            pila.Push("segundo");
            pila.Push("tercero");
            pila.Push("cuarto");
            pila.Pop();

            foreach (string str in pila)
            {
                Console.WriteLine("\t" + str);
            }

            // Cola
            Console.WriteLine("\n--- Queue (Cola) ---");
            Queue<string> cola = new Queue<string>();
            cola.Enqueue("primero");
            cola.Enqueue("segundo");
            cola.Enqueue("tercero");
            cola.Enqueue("cuarto");
            cola.Dequeue();

            foreach (string str in cola)
            {
                Console.WriteLine("\t" + str);
            }
            Console.ReadKey(true);
        }
    }
}
