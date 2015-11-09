
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM{
    /**
     * 
     */
    public class ATM {

        /**
         * 
         */
        public ATM(string nombre, string direccion, Caja caja) {
            this.nombre = nombre;
            this.direccion = direccion;

            // Objetos que componen al ATM se construyen dentro de si mismo
            // En caso de agregacion los objetos se construyen fuera de la estructura
            cajaInterna = new Caja();
            lectora = new LectoraTarjeta();
            impresora = new Impresora();
            conector = new Conector();
        }

        /**
         * 
         */
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        /**
         * 
         */
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /**
         * 
         */
        private Caja cajaInterna;

        public Caja CajaInterna
        {
            get { return cajaInterna; }
            set { cajaInterna = value; }
        }

        /**
         * 
         */
        private LectoraTarjeta lectora;

        public LectoraTarjeta Lectora
        {
            get { return lectora; }
            set { lectora = value; }
        }

        /**
         * 
         */
        private Impresora impresora;

        public Impresora Impresora
        {
            get { return impresora; }
            set { impresora = value; }
        }

        /**
         * 
         */
        private Conector conector;

        public Conector Conector
        {
            get { return conector; }
            set { conector = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Trabajando()
        {
            Externo.Tarjeta tarjeta1 = new Externo.Tarjeta("Banco Super", "1234 4567 8901 2345", "Alberto Garcia");
            //Sesion sesion = new Sesion();
            
            //lectora.LeerTarjeta(tarjeta1);
        }
    }
}