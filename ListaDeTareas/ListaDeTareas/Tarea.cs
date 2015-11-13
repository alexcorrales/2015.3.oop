using System;

namespace ListaDeTareas
{
    class Tarea
    {
        DateTime fechaInicial;
        DateTime fechaVencimiento;
        string texto;
        bool realizado;

        public Tarea (string texto, DateTime fechaVencimiento)
        {
            this.texto = texto;
            this.fechaVencimiento = fechaVencimiento;

            fechaInicial = DateTime.Now;
            realizado = false;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} ({2})", this.fechaVencimiento.ToShortDateString(), 
                this.texto, this.realizado);
        }
    }
}
