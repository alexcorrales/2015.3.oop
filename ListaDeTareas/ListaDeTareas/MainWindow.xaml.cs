using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListaDeTareas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ListaTareas tareas;

        public MainWindow()
        {
            InitializeComponent();
            tareas = new ListaTareas();    
        }

        public void ActualizarListBox()
        {
            this.listBox1.Items.Clear();

            foreach (Tarea tarea in this.tareas.ToArray())
            {
                this.listBox1.Items.Add(tarea);
            }
        }

        private void agregarBtn_Click(object sender, RoutedEventArgs e)
        {
            DateTime fecha = (DateTime) this.fecha1.SelectedDate;
            Tarea tarea = new Tarea(this.texto1.Text, fecha);
            tareas.AgregarTareas(tarea);

            ActualizarListBox();
        }

        private void eliminarBtn_Click(object sender, RoutedEventArgs e)
        {
            Tarea tarea = (Tarea)this.listBox1.SelectedItem;            
            this.tareas.EliminarTareas(tarea);
            
            ActualizarListBox();
        }
    }
}
