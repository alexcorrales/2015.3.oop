
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace ATM{
    /**
     * 
     */
    public class Caja {

        /**
         * 
         */
        public Caja() {
            billetes = new List<Dinero>();
        }

        /**
         * 
         */
        private List<Dinero> billetes;

        /**
         * 
         */
        private decimal saldoActual;

        public decimal SaldoActual
        {
          get { return saldoActual; }
          set { saldoActual = value; }
        }


        /**
         * 
         */
        public void Arqueo() {
            // TODO implementacion futura, una vez resuelto Retiro
        }

        /**
         * @param Billete b
         */
        public void Agregar(Dinero b) {
            // Primer opcion: Si el elemento a ingresar es igual a uno de la coleccion, se unifica
            for (int i = 0; i < this.billetes.Count; i++)
            {
                if (Dinero.EsSimilar(billetes[i], b))
                {
                    this.billetes[i] = this.billetes[i] + b;
                    return;
                }
            }

            // Segunda opcion: Se inserta en la posicion donde exista un valor inferior
            foreach (Dinero billete in billetes)
            {
                if (b.ValorDenominacion() > billete.ValorDenominacion())
                {
                    int posicion;
                    posicion = billetes.IndexOf(billete);
                    billetes.Insert(posicion, b);
                    return;
                }
            }
            
            billetes.Add(b);
        }

        /**
         * @param decimal monto
         */
        public void Quitar(decimal monto)
        {
            int cantidad;
            decimal valorBillete;
            decimal resultado;
            Hashtable ht = new Hashtable();

            resultado = monto;

            for (int i = 0; i < billetes.Count; i++)
            {
                cantidad = 0;
                valorBillete = billetes[i].ValorDenominacion();

                if (resultado / valorBillete >= 1M)
                {
                    cantidad = (int)(resultado / valorBillete);
                    resultado -= (valorBillete * cantidad);

                    // Determinar si la existencia de billetes corresponde a la solucion
                    if (billetes[i].Cantidad < cantidad)
                    {
                        return;
                    }
                    else
                    {
                        ht.Add(i, cantidad);
                    }
                }
            }

            // Verificar resultado valido
            if (resultado == 0)
            {
                foreach (int i in ht.Keys)
                {
                    cantidad = (int) ht[i];
                    Dinero dinero = new Dinero(billetes[i].TipoMoneda, billetes[i].Denominacion, cantidad);
                    billetes[i] = billetes[i] - dinero;
                }
            }
        }        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Dinero billete in billetes)
            {
                sb.Append(billete + "\n");
            }

            return sb.ToString();
        }
    }
}