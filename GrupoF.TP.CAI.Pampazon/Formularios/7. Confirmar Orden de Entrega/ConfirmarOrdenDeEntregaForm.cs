using GrupoF.TP.CAI.Pampazon.Formularios._4._Confirmar_Orden_Seleccionada;
using GrupoF.TP.CAI.Pampazon.Formularios._7._Confirmar_Orden_de_Entrega;
using GrupoF.TP.CAI.Pampazon.Formularios._7._Confirmar_Orden_de_Entrega.Clases_auxiliares;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoF.TP.CAI.Pampazon
{
    public partial class ConfirmarOrdenDeEntregaForm : Form
    {
        ConfirmarOrdenDeEntregaModel model;
        public ConfirmarOrdenDeEntregaForm()
        {
            InitializeComponent();
        }

        private void ConfirmarOrdenDeEntregaForm_Load(object sender, EventArgs e)
        {
            model = new ConfirmarOrdenDeEntregaModel();

            CargarOrdenesPreparadas();
        }

        private void CargarOrdenesPreparadas()
        {
            if (model.OrdenesDeEntregaAConfirmar != null)
            {
                foreach (OrdenDePreparacionPreparada ordenes in model.OrdenesDeEntregaAConfirmar)
                {
                    ListViewItem item = new ListViewItem(ordenes.NumeroDeOrden);
                    item.SubItems.Add(ordenes.CodigoCliente);
                    item.SubItems.Add(ordenes.Fecha.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(ordenes.CodigoTransportista);
                    item.SubItems.Add(((int)ordenes.Prioridad).ToString());
                    item.SubItems.Add(ordenes.EstadoOrden.ToString());

                    listOrdenesPreparadas.Items.Add(item);

                    item.Tag = ordenes;
                }

            }
        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            if (listOrdenesPreparadas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una orden.");
            }
            else
            {

                // Obtener la orden seleccionada
                OrdenDePreparacionPreparada ordenDePreparacion = (OrdenDePreparacionPreparada)listOrdenesPreparadas.SelectedItems[0].Tag;

                // Cambiar el estado de la orden en el modelo
                model.CambiarEstadoEnOrden(ordenDePreparacion);

                // Remover la orden de la lista visual
                listOrdenesPreparadas.Items.RemoveAt(listOrdenesPreparadas.SelectedIndices[0]);

                DialogResult result = MessageBox.Show("¿Está seguro de que la orden seleccionada ha sido entregada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("La orden se ha actualizado a estado Despachada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Crear instancia del siguiente formulario
                    OrdenDespachadaForm ordenDespachadaForm = new OrdenDespachadaForm();

                    // Asignar el modelo actualizado al siguiente formulario
                    ordenDespachadaForm.model = model;

                    // Mostrar el siguiente formulario
                    ordenDespachadaForm.ShowDialog();
                }
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SiguienteBtn_Click(object sender, EventArgs e)
        {
            OrdenDespachadaForm ordenDespachadaForm = new OrdenDespachadaForm();
            ordenDespachadaForm.model = model;

            ordenDespachadaForm.ShowDialog();
        }

        private void listOrdenesPreparadas_MouseClick(object sender, MouseEventArgs e)
        {
            if (listOrdenesPreparadas.SelectedItems.Count > 0)
            {
                OrdenDePreparacionPreparada orden = (OrdenDePreparacionPreparada)listOrdenesPreparadas.SelectedItems[0].Tag;

                bool existeSeleccionada = false;

                foreach (ListViewItem item in listOrdenesPreparadas.Items)
                {
                    OrdenDePreparacionPreparada ordenEnLista = (OrdenDePreparacionPreparada)item.Tag;
                    if (ordenEnLista.EstadoOrden == Entidades.EstadoPreparacion.Despachada)
                    {
                        existeSeleccionada = true;
                        break;
                    }
                }

                if (existeSeleccionada)
                {
                    MessageBox.Show("Ya existe una orden en estado 'Despachada'. No se puede seleccionar otra orden hasta que la actual se complete.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                orden.EstadoOrden = Entidades.EstadoPreparacion.Despachada;

                listOrdenesPreparadas.SelectedItems[0].SubItems[5].Text = orden.EstadoOrden.ToString();


                if (!model.OrdenesDeEntregaAConfirmar.Contains(orden))
                {
                    model.OrdenesDeEntregaAConfirmar.Remove(orden);
                    model.OrdenADespachada.Add(orden);
                }

            }
        }
    }
}
