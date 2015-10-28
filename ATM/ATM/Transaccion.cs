
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM{
    /**
     * 
     */
    public abstract class Transaccion {

        /**
         * 
         */
        protected string identificador;

        protected DateTime fecha;

        protected int numeroProtegido;

        //private ATM atm;

        //private Sesion sesion;

        private IComisionable comisionComportamiento;

        public void RealizarComision()
        {
            comisionComportamiento.Comisionar();
        }

        public void ModificarComportamientoComision(IComisionable comportamiento)
        {
            comisionComportamiento = comportamiento;
        }


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