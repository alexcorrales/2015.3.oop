
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM{
    /**
     * 
     */
    public class CambioPIN : Transaccion {

        /**
         * 
         */
        public CambioPIN(DateTime fecha, ATM atm, Sesion sesion, string nuevoPIN) {
            base.Fecha = fecha;
            base.Atm = atm;
            base.Sesion = sesion;

            base.getSecuencia();
            this.nuevoPIN = nuevoPIN;

            base.Comision = 0M;
            base.EsImprimible = false;
        }

        private string nuevoPIN;

        /**
         * 
         */
        public override void Proceder() {
            // TODO implement here
        }

    }
}