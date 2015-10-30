
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM{
    /**
     * 
     */
    public class Conector {

        public enum ETipoRespuesta { OK }
        /**
         * 
         */
        public Conector() {
        }

        /**
         * 
         */
        private ETipoRespuesta respuesta;

        public ETipoRespuesta Respuesta
        {
            get { return respuesta; }
            set { respuesta = value; }
        }



        /**
         * @param Transaccion t
         */
        public void enviarTransaccion(Transaccion t) {
            // TODO implement here
        }

        /**
         * 
         */
        public void recibirRespuesta() {
            // TODO implement here
        }

    }
}