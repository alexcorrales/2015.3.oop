using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Herencia
{
    class Tarjeta
    {
        public Tarjeta(string numeroTarjeta, string bancoEmisor, string cliente, int mesVencimiento, int añoVencimiento)
        {
            this.numeroTarjeta = numeroTarjeta;
            this.bancoEmisor = bancoEmisor;
            this.cliente = cliente;
            this.mesVencimiento = mesVencimiento;
            this.añoVencimiento = añoVencimiento;
        }

        private string numeroTarjeta;

        public string NumeroTarjeta
        {
            get { return numeroTarjeta; }
            set { numeroTarjeta = value; }
        }

        private string cliente;

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        private string bancoEmisor;

        public string BancoEmisor
        {
            get { return bancoEmisor; }
            set { bancoEmisor = value; }
        }

        private int mesVencimiento;

        public int MesVencimiento
        {
            get { return mesVencimiento; }
            set { mesVencimiento = value; }
        }

        private int añoVencimiento;

        public int AñoVencimiento
        {
            get { return añoVencimiento; }
            set { añoVencimiento = value; }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder("\n------------");
            str.Append("\nPropietario: ");
            str.Append(this.cliente);
            str.Append("\nBanco: ");
            str.Append(this.bancoEmisor);
            str.Append("\nNumero: ");
            str.Append(this.numeroTarjeta);
            str.Append("\nVence: ");
            str.Append(this.mesVencimiento);
            str.Append("/");
            str.Append(this.añoVencimiento);

            return str.ToString();
        }
    }
}
