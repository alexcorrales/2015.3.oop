
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM {
    /**
     * 
     */

    public class Dinero {

        public enum ETipoMoneda { LEMPIRAS, DOLARES };

        /**
         * 
         */
        public Dinero(ETipoMoneda tipoMoneda, decimal denominacion, int cantidad) {
            this.tipoMoneda = tipoMoneda;
            this.denominacion = denominacion;
            this.cantidad = cantidad;
        }

        /**
         * 
         */
        private ETipoMoneda tipoMoneda;

        public ETipoMoneda TipoMoneda
        {
            get { return tipoMoneda; }
            set { tipoMoneda = value; }
        }

        /**
         * 
         */
        private decimal denominacion;

        public decimal Denominacion
        {
            get { return denominacion; }
            set { denominacion = value; }
        }

        /**
         * 
         */
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        /**
         * @return
         */

        public bool Existencia() {
            // TODO implement here
            return false;
        }

        /**
         * @return
         */
        public decimal Monto() {
            // TODO implement here
            return 0.0M;
        }

    }
}