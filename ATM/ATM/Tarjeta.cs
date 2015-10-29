
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Externo {
    /**
     * 
     */
    public class Tarjeta {

        /**
         * 
         */
        public Tarjeta(string bancoEmisor, string numeroTarjeta, string propietario) {
            this.bancoEmisor = bancoEmisor;
            this.numeroTarjeta = numeroTarjeta;
            this.propietario = propietario;
        }

        /**
         * 
         */
        private string bancoEmisor;

        /**
         * 
         */
        private string numeroTarjeta;

        /**
         * 
         */
        private string propietario;


        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.bancoEmisor);
            sb.Append("\n");
            sb.Append(this.numeroTarjeta);
            sb.Append("\n");
            sb.Append(this.propietario);

            return sb.ToString();
        }

    }
}