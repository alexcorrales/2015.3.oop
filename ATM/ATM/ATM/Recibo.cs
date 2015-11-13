
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM{
    /**
     * 
     */
    public class Recibo {

        /**
         * 
         */
        public Recibo() {
        }

        /**
         * 
         */
        private DateTime fechaImpresion;

        public DateTime FechaImpresion
        {
            get { return fechaImpresion; }
            set { fechaImpresion = value; }
        }

        /**
         * 
         */
        private List<string> detalles;

        public List<string> Detalles
        {
            get { return detalles; }
            set { detalles = value; }
        }


        /**
         * @param Transaccion t
         */
        public List<string> GetDetalles(Transaccion t) {
            List<string> detalles = new List<string>();

            detalles.Add("Referencia: " + t.Identificador);
            detalles.Add("Fecha: " + t.Fecha.ToShortDateString());
            detalles.Add("");
            detalles.Add("Tarjeta: " + t.Sesion.Tarjeta.ToStringSecreto());

            // TODO: Funcion incompleta, falta detalles de la transaccion en si
            return detalles;
        }

    }
}