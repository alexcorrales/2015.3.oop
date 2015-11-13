
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM{
    /**
     * 
     */
    public class Retiro : Transaccion {

        /**
         * 
         */
        public Retiro(ATM atm, Sesion sesion, decimal monto)
        {
            base.Fecha = DateTime.Now;
            base.Atm = atm;
            base.Sesion = sesion;

            base.getSecuencia();

            this.monto = monto;

            base.Comision = 15M;
            base.EsImprimible = true;
        }

        /**
         * 
         */
        private decimal monto;

        /**
         * 
         */
        public override void Proceder() {
            // TODO implement here
        }

    }
}