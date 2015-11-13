using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Herencia
{

    // La herencia solamente necesita dos puntos (:) para generarse
    class TarjetaCredito : Tarjeta
    {

        // En el constructur colocamos además de los parametros propios de la subclase, los de la super clase
        // utilizamos "base" para alimentar al constructor de la super clase
        public TarjetaCredito(string numeroTarjeta, string bancoEmisor, string cliente, int mesVencimiento, int añoVencimiento,
            decimal limiteCredito, int diaCorte, int diaPago)
            : base(numeroTarjeta, bancoEmisor, cliente, mesVencimiento, añoVencimiento)
        {
            this.limiteCredito = limiteCredito;
            this.diaCorte = diaCorte;
            this.diaPago = diaPago;
        }

        private decimal limiteCredito;

        public decimal LimiteCredito
        {
            get { return limiteCredito; }
            set { limiteCredito = value; }
        }

        private int diaCorte;

        public int DiaCorte
        {
            get { return diaCorte; }
            set { diaCorte = value; }
        }

        private int diaPago;

        public int DiaPago
        {
            get { return diaPago; }
            set { diaPago = value; }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder(base.ToString());
            str.Append("Limite credito: ");
            str.Append(limiteCredito);
            str.Append("\nDia corte: ");
            str.Append(diaCorte);
            str.Append("\nDia pago: ");
            str.Append(diaPago);

            return str.ToString();
        }
    }
}
