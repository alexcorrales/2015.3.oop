﻿using System;
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
            Login lg = new Login(null, null);

            Console.WriteLine(lg.Identificador);

            Transaccion lg1 = new Retiro(null, null, 0M);

            Console.WriteLine(lg1.Identificador);


            Console.ReadKey(true);
        }
    }
}
