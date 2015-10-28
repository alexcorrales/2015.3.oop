
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
        public Transaccion() {
        }

        /**
         * 
         */
        protected string identificador;

        /**
         * 
         */
        protected DateTime fecha;


        /**
         * 
         */
        public Conector envia;


        /**
         * 
         */
        private ATM atm;

    }
}