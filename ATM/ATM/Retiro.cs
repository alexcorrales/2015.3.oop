
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM{
    /**
     * 
     */
    public class Retiro : Transaccion {

        /**
         * 
         */
        public Retiro(string identificador, DateTime fecha, decimal monto) {
            this.identificador = identificador;
            this.fecha = fecha;
            this.monto = monto;
            this.ModificarComportamientoComision(new Comisiona());
            this.RealizarComision();
        }

        /**
         * 
         */
        private decimal monto;

        /**
         * 
         */
        public void Proceder() {
            // TODO implement here
        }

    }
}