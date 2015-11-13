
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM
{
    /**
     * 
     */
    public class Login : Transaccion
    {

        /**
         * 
         */
        public Login(ATM atm, Sesion sesion)
        {
            base.Fecha = DateTime.Now;
            base.Atm = atm;
            base.Sesion = sesion;

            base.getSecuencia();
            
            // Definimos un comportamiento menos dinamico pero correcto
            base.Comision = 0M;
            base.EsImprimible = false;
        }

        /**
         * 
         */
        public override void Proceder()
        {
            // TODO implement here
        }

    }
}