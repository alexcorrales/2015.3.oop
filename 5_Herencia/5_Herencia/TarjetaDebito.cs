using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Herencia
{
    class TarjetaDebito : Tarjeta
    {
        public TarjetaDebito(string numeroTarjeta, string bancoEmisor, string cliente, int mesVencimiento, int añoVencimiento,
            decimal montoSobregiro)
            : base(numeroTarjeta, bancoEmisor, cliente, mesVencimiento, añoVencimiento)
        {
            this.montoSobregiro = montoSobregiro;
        }

        decimal montoSobregiro;

        public decimal MontoSobregiro
        {
            get { return montoSobregiro; }
            set { montoSobregiro = value; }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder(base.ToString());
            str.Append("\nMonto sobregiro: ");
            str.Append(montoSobregiro);

            return str.ToString();
        }

    }
}
