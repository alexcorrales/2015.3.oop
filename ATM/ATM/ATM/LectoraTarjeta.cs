
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
        public void LeerTarjeta(Externo.Tarjeta t, int Pin) {
            this.TarjetaIngresada = true;

            // TODO: Enviar a Sesion los valores de tarjeta y pin
        }

        /**
         * 
         */
        public void RetirarTarjeta() {
            this.TarjetaIngresada = false;
        }

    }
}