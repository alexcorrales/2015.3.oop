
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Externo;

namespace ATM{
    /**
     * 
     */
    public class Sesion {

        public enum EEstadoSesion { INICIADO, TERMINADO }

        /**
         * 
         */
        public Sesion(Tarjeta tarjeta, string pin) {
            this.tarjeta = tarjeta;
            this.pin = pin;
        }

        /**
         * 
         */
        private EEstadoSesion estadoActual;

        public EEstadoSesion EstadoActual
        {
            get { return estadoActual; }
            set { estadoActual = value; }
        }

        /**
         * 
         */
        private Tarjeta tarjeta;

        public Tarjeta Tarjeta
        {
            get { return tarjeta; }
            set { tarjeta = value; }
        }

        /**
         * 
         */
        private string pin;

        public string Pin
        {
            get { return pin; }
            set { pin = value; }
        }


        /**
         * 
         */
        public void CrearSesion() {
            // TODO implement here
        }

        /**
         * 
         */
        public void DestruirSesion() {
            // TODO implement here
        }

    }
}