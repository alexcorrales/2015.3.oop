
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace ATM{
    /**
     * 
     */
    public class Caja {

        /**
         * 
         */
        public Caja() {
            billetes = new List<Dinero>();
        }

        /**
         * 
         */
        private List<Dinero> billetes;

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
        public void Arqueo() {
            // TODO implement here
        }

        /**
         * @param Billete b
         */
        public void Agregar(Dinero b) {
            billetes.Add(b);
        }

        /**
         * @param decimal monto
         */
        public void Quitar(decimal monto) {
            // TODO implement here
        }

    }
}