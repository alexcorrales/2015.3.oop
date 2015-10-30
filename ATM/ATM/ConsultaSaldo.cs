
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
        public ConsultaSaldo(DateTime fecha, ATM atm, Sesion sesion)
        {
            base.Fecha = fecha;
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