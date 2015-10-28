
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM
{
    /**
     * 
     */
    public class Login : Transaccion
    {

        /**
         * 
         */
        public Login(string identificador, DateTime fecha)
        {
            base.identificador = identificador;
            base.fecha = fecha;
        }

        /**
         * 
         */
        public void Entrar()
        {
            // TODO implement here
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append("\nEsto es un login");

            return sb.ToString();
        }

        public override void Comisionar()
        {
            Console.WriteLine("Login: No se implementa");
        }

    }
}