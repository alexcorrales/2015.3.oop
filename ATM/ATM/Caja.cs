
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM{
    /**
     * 
     */
    public class Caja {

        /**
         * 
         */
        public Caja() {
        }

        /**
         * 
         */
        private Dinero billetes;

        /**
         * 
         */
        private decimal saldoActual;

public decimal SaldoActual
{
  get { return saldoActual; }
  set { saldoActual = value; }
}

        /**
         * 
         */
        private bool billeteSacado;



        /**
         * 
         */
        public void Arqueo() {
            // TODO implement here
        }

        /**
         * @param Billete b
         */
        public void Agregar(void Billete b) {
            // TODO implement here
        }

        /**
         * @param decimal monto
         */
        public void Quitar(void decimal monto) {
            // TODO implement here
        }

    }
}