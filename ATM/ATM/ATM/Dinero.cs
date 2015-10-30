
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

        public enum EDenominacion { CIEN, QUINIENTOS };

        /**
         * 
         */
        public Dinero(ETipoMoneda tipoMoneda, EDenominacion denominacion, int cantidad) {
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
        private EDenominacion denominacion;

        public EDenominacion Denominacion
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
            if (cantidad > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /**
         * @return
         */
        public decimal Monto() {
            switch (this.denominacion)
            {
                case EDenominacion.CIEN:
                    return 100M * this.cantidad;
                case EDenominacion.QUINIENTOS:
                    return 500M * this.cantidad;
                default: 
                    return 0M;
            }
        }

        public bool Quitar(ETipoMoneda tipoMoneda, EDenominacion denominacion, int cantidad)
        {
            if (this.tipoMoneda == tipoMoneda && this.denominacion == denominacion 
                && this.cantidad >= cantidad)
            {
                this.cantidad -= cantidad;
                return true;
            }

            return false;
        }

        public bool Agregar(ETipoMoneda tipoMoneda, EDenominacion denominacion, int cantidad)
        {
            if (this.tipoMoneda == tipoMoneda && this.denominacion == denominacion)
            {
                this.cantidad += cantidad;
                return true;
            }

            return false;
        }

    }
}