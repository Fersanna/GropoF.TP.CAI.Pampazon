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

            foreach (OrdenDePreparacionEnSeleccion ordenesSeleccionada in model.OrdenEnSeleccion)
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

                OrdenDePreparacionEnSeleccion ordenDePreparacion = (OrdenDePreparacionEnSeleccion)listOrdenesEnSeleccion.SelectedItems[0].Tag;

                model.CambiarEstadoEnOrden(ordenDePreparacion);

               

                MessageBox.Show("La orden se ha confirmado con éxito.");
                this.Close();
               
            }
        }

        private void listOrdenesEnSeleccion_MouseClick(object sender, MouseEventArgs e)
        {
             if (listOrdenesEnSeleccion.SelectedItems.Count > 0)
            {
                OrdenDePreparacionEnSeleccion orden = (OrdenDePreparacionEnSeleccion)listOrdenesEnSeleccion.SelectedItems[0].Tag;

                orden.EstadoOrden = Entidades.Estados.Estado.Seleccionada;

                listOrdenesEnSeleccion.SelectedItems[0].SubItems[5].Text = orden.EstadoOrden.ToString();


                if (!model.OrdenEnSeleccion.Contains(orden))
                {
                    model.OrdenEnSeleccion.Remove(orden);
                    model.OrdenesSeleccionadas.Add(orden);
                }
            
        }
    }
} }
