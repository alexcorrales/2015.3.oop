
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM{
    /**
     * 
     */
    public class LectoraTarjeta {

        /**
         * 
         */
        public LectoraTarjeta() {
        }

        /**
         * 
         */
        private bool tarjetaIngresada;
    
        public bool TarjetaIngresada
        {
          get { return tarjetaIngresada; }
          set { tarjetaIngresada = value; }
        }


        /**
         * @param Tarjeta t 
         * @param int Pin
         */
        public void LeerTarjeta(Externo.Tarjeta t, Sesion sesion) {
            this.TarjetaIngresada = true;
        
            sesion.Tarjeta = t;
        }

        /**
         * 
         */
        public void RetirarTarjeta() {
            this.TarjetaIngresada = false;
        }

    }
}