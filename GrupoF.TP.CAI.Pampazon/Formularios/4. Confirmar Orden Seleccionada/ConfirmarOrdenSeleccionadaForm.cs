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
                    item.SubItems.Add(ordenesSeleccionada.Fecha.ToString("dd/MM/yyyy"));
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
                MessageBox.Show("Debe seleccionar al menos una orden.");
                return;
            }


            else
            {

                OrdenDePreparacionEnSeleccion ordenDePreparacion = (OrdenDePreparacionEnSeleccion)listOrdenesEnSeleccion.SelectedItems[0].Tag;

                model.CambiarEstadoEnOrden(ordenDePreparacion);


                DialogResult result = MessageBox.Show("¿Está seguro de que las ordenes seleccionadas han sido recibidas?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Las ordenes se han actualizado a estado Seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
        }

        private void listOrdenesEnSeleccion_MouseClick(object sender, MouseEventArgs e)
        {
            if (listOrdenesEnSeleccion.SelectedItems.Count > 0)
            {
                OrdenDePreparacionEnSeleccion orden = (OrdenDePreparacionEnSeleccion)listOrdenesEnSeleccion.SelectedItems[0].Tag;

                bool existeSeleccionada = false;

                foreach (ListViewItem item in listOrdenesEnSeleccion.Items)
                {
                    OrdenDePreparacionEnSeleccion ordenEnLista = (OrdenDePreparacionEnSeleccion)item.Tag;
                    if (ordenEnLista.EstadoOrden == Entidades.EstadoPreparacion.Seleccionada)
                    {
                        existeSeleccionada = true;
                        break;
                    }
                }

                if (existeSeleccionada)
                {
                    MessageBox.Show("Ya existe una orden en estado 'Seleccionada'. No se puede seleccionar otra orden hasta que la actual se complete.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                orden.EstadoOrden = Entidades.EstadoPreparacion.Seleccionada;

                listOrdenesEnSeleccion.SelectedItems[0].SubItems[5].Text = orden.EstadoOrden.ToString();


                if (!model.OrdenEnSeleccion.Contains(orden))
                {
                    model.OrdenEnSeleccion.Remove(orden);
                    model.OrdenesSeleccionadas.Add(orden);
                }

            }
        }
    }
}
