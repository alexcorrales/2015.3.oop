﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TiposDeDatos
{
    class Program
    {
        enum Dias {Domingo=1, Lunes, Martes, Miercoles, Jueves, Viernes, Sabado};

        static void Main(string[] args)
        {
            // Tipos de datos unsigned
            Console.WriteLine("Entero sin signo minimo: " + uint.MinValue + ", maximo: " + uint.MaxValue);

            // Tener cuidado de utilizar tipos unsigned
            uint NoNegativo = 0;
            NoNegativo--;

            Console.WriteLine("Valor anterior al cero (supuestamente): " + NoNegativo);

            // Diferentes tamaños para tipos de datos
            Console.WriteLine("Entero 16 bits minimo: " + Int16.MinValue + ", maximo: " + Int16.MaxValue);
            Console.WriteLine("Entero 32 bits minimo: " + Int32.MinValue + ", maximo: " + Int32.MaxValue);
            Console.WriteLine("Entero 64 bits minimo: " + Int64.MinValue + ", maximo: " + Int64.MaxValue);

            // Nuevos tipos: decimal
            decimal dec = 3.52343m;    // para diferenciar de un double si agrega el sufijo m
            Console.WriteLine("El valor es: {0:C}", dec);

            // Tipos objeto: 
            
            // Fecha
            DateTime fecha = DateTime.Now;//new DateTime(2015, 10, 5, 7, 16, 45);
            //fecha = fecha.AddYears(-1);
            Console.WriteLine(fecha);          

            // Uso de un enum
            Console.WriteLine(Dias.Domingo);   
            Dias dia = Dias.Jueves;
            if (dia == Dias.Domingo)
            {
                Console.WriteLine("Es domingo");
            }
            else
            {
                Console.WriteLine("No es domingo");
            }

            var unaVariable = "Hola";
            unaVariable.

            Console.WriteLine(unaVariable);

            Console.ReadKey(true);
        }
    }
}
