
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
            // TODO implementacion futura, una vez resuelto Retiro
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
            // TODO tarea: El monto del parametro se debe descomponer y sustraer de los billetes
            // disponibles
        }

    }
}