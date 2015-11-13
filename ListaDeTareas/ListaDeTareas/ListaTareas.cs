using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeTareas
{
    class ListaTareas
    {
        private List<Tarea> listaTareas;

        public ListaTareas()
        {
            this.listaTareas = new List<Tarea>();
        }

        public void AgregarTareas(Tarea t)
        {
            this.listaTareas.Add(t);
        }

        public void EliminarTareas(Tarea t)
        {
            this.listaTareas.Remove(t);
        }

       
        public Tarea[] ToArray()
        {
            return this.listaTareas.ToArray();
        }
    }
}
