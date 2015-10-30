
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM{
    /**
     * 
     */
    public abstract class Transaccion {

        // Static: Atributo de la clase y no el objeto.
        private static int secuencia;

        public void getSecuencia()
        {
            this.identificador = this.fecha.ToString("yyyyMMdd") + (++secuencia).ToString();
        }

        private string identificador;

        public string Identificador
        {
            get { return identificador; }
            private set { identificador = value; }  // dejarlo de solo lectura
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private ATM atm;

        public ATM Atm
        {
            get { return atm; }
            set { atm = value; }
        }

        private Sesion sesion;

        public Sesion Sesion
        {
            get { return sesion; }
            set { sesion = value; }
        }

        private decimal comision;

        public decimal Comision
        {
            get { return comision; }
            set { comision = value; }
        }

        private bool esImprimible;

        public bool EsImprimible
        {
            get { return esImprimible; }
            set { esImprimible = value; }
        }

        public abstract void Proceder();
    }
}