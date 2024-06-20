using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using GrupoF.TP.CAI.Pampazon.Formularios._1._Registrar_Orden_de_Preparación;
using GrupoF.TP.CAI.Pampazon.Formularios._3._Buscar_Posición;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrupoF.TP.CAI.Pampazon.Formularios._4._Confirmar_Orden_Seleccionada
{
    public partial class ConfirmarOrdenSeleccionadaForm : Form
    {
        ConfirmarOrdenSeleccionadaFormModel model;
        public ConfirmarOrdenSeleccionadaForm()
        {
            InitializeComponent();
        }

        private void ConfirmarOrdenSeleccionadaForm_Load(object sender, EventArgs e)
        {
            model = new ConfirmarOrdenSeleccionadaFormModel();

            foreach (OrdenDeSeleccionada ordenesSeleccionada in model.OrdenEnSeleccion)
            {

                {
                    ListViewItem item = new ListViewItem(ordenesSeleccionada.NumeroDeOrden);
                    // string detallesUnidos = string.Join(" - ", ordenesSeleccionada.OrdenesSeleccionadas);
                    item.SubItems.Add(ordenesSeleccionada.CodigoCliente);
                    item.SubItems.Add(ordenesSeleccionada.Fecha.ToString());
                    item.SubItems.Add(ordenesSeleccionada.CodigoTransportista);
                    item.SubItems.Add(((int)ordenesSeleccionada.Prioridad).ToString());
                    item.SubItems.Add(ordenesSeleccionada.EstadoOrden.ToString());

                    listOrdenesEnSeleccion.Items.Add(item);

                    item.Tag = ordenesSeleccionada;
                }
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            if (listOrdenesEnSeleccion.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una orden.");
                return;
            }
            else
            {

                OrdenDeSeleccionada ordenDePreparacion = (OrdenDeSeleccionada)listOrdenesEnSeleccion.SelectedItems[0].Tag;

                model.CambiarEstadoEnOrden(ordenDePreparacion);

                //Este era el codigo para borrar al confirmar, sacar de la lista - Lo cambie por mostrar otro estado
                foreach (ListViewItem item in listOrdenesEnSeleccion.SelectedItems)
                {
                    listOrdenesEnSeleccion.Items.Remove(item);
                }

                MessageBox.Show("La orden se ha confirmado con éxito.");
                
                /*
                if (listOrdenesEnSeleccion.SelectedItems.Count > 0)
                {
                    OrdenDeSeleccionada orden = (OrdenDeSeleccionada)listOrdenesEnSeleccion.SelectedItems[0].Tag;

                    orden.EstadoOrden = Entidades.Estados.Estado.Seleccionada;

                    listOrdenesEnSeleccion.SelectedItems[0].SubItems[5].Text = orden.EstadoOrden.ToString();

                }
                */
            }
        }

        private void listOrdenesEnSeleccion_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
