
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM{
    /**
     * 
     */
    public class Transaccion {

        /**
         * 
         */
        public Transaccion(string identificador, DateTime fecha) {
                this.identificador = identificador;
                this.fecha = fecha;
                //this.atm = atm;
                //this.sesion = sesion;
        }

        protected string identificador;

        protected DateTime fecha;

        protected int numeroProtegido;

        //private ATM atm;

        //private Sesion sesion;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nIdentificador: ");
            sb.Append(this.identificador);
            sb.Append("\nFecha: ");
            sb.Append(this.fecha.ToShortDateString());

            return sb.ToString();
        }
       

    }
}