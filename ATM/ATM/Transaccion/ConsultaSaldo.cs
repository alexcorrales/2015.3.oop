
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM{
    /**
     * 
     */
    public class ConsultaSaldo : Transaccion {

        /**
         * 
         */
        public ConsultaSaldo(ATM atm, Sesion sesion)
        {
            base.Fecha = DateTime.Now;
            base.Atm = atm;
            base.Sesion = sesion;

            base.getSecuencia();

            base.Comision = 15M;
            base.EsImprimible = true;
        }

        /**
         * 
         */
        public override void Proceder() {
            // TODO implement here
        }

    }
}