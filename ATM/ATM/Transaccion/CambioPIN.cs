
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
        public CambioPIN(ATM atm, Sesion sesion, string nuevoPIN) {
            base.Fecha = DateTime.Now;
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