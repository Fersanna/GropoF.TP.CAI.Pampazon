using GrupoF.TP.CAI.Pampazon.Formularios._5._Generar_Orden_de_Entrega;
using GrupoF.TP.CAI.Pampazon.Formularios._5._Generar_Orden_de_Entrega.Clases_Auxiliares;
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
    public partial class GenerarOrdenDeEntregaForm : Form
    {
        OrdenDeEntregaModel model;
        public GenerarOrdenDeEntregaForm()
        {
            InitializeComponent();
            model = new OrdenDeEntregaModel();
        }

        private void GenerarOrdenDeEntregaForm_Load(object sender, EventArgs e)
        {
            CargarOrdenesSeleccionadas();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            if (!model.OrdenesPreparadas.Any(o => o.EstadoOrden == Entidades.Estados.Estado.Preparada))
            {
                MessageBox.Show("Debe seleccionar una o varias ordenes.");
                return;
            }

            if (model.OrdenesSeleccionadas
                     .GroupBy(c => c.CodigoCliente)
                     .Count() > 2)
            {
                MessageBox.Show("Todas las ordenes seleccionadas deben pertenecera a un mismo cliente");
            }

            OrdenDeEntregaForm ordenDeEntregaForm = new OrdenDeEntregaForm();
            ordenDeEntregaForm.model = this.model;
            ordenDeEntregaForm.ShowDialog();


            CargarOrdenesSeleccionadas();
            this.Close();
        }




        private void CargarOrdenesSeleccionadas()
        {
            listOrdenesPreparacion.Items.Clear();

            foreach (OrdenDePreparacionSeleccionada ordenes in model.OrdenesSeleccionadas)
            {
                ListViewItem item = new ListViewItem(ordenes.NumeroDeOrden);
                item.SubItems.Add(ordenes.CodigoCliente);
                item.SubItems.Add(ordenes.Fecha.ToString("dd/MM/yyyy"));
                item.SubItems.Add(ordenes.CodigoTransportista);
                item.SubItems.Add(((int)ordenes.Prioridad).ToString());
                item.SubItems.Add(ordenes.EstadoOrden.ToString());

                listOrdenesPreparacion.Items.Add(item);

                item.Tag = ordenes;
            }

        }

        private void listOrdenesPreparacion_MouseClick(object sender, MouseEventArgs e)
        {
            if (listOrdenesPreparacion.SelectedItems.Count > 0)
            {
                OrdenDePreparacionSeleccionada ordenSeleccionada = (OrdenDePreparacionSeleccionada)listOrdenesPreparacion.SelectedItems[0].Tag;


                var error = model.ValidarOrden(ordenSeleccionada);

                if (error != null)
                {
                    MessageBox.Show(error);
                    CargarOrdenesSeleccionadas();
                    return;
                }

                ordenSeleccionada.EstadoOrden = Entidades.Estados.Estado.Preparada;

                listOrdenesPreparacion.SelectedItems[0].SubItems[5].Text = ordenSeleccionada.EstadoOrden.ToString();

                if (!model.OrdenesPreparadas.Contains(ordenSeleccionada))
                {
                    model.OrdenesSeleccionadas.Remove(ordenSeleccionada);
                    model.OrdenesPreparadas.Add(ordenSeleccionada);
                }

            }
            MessageBox.Show("La orden fue seleccionada");
        }



        private void ActualizarListaOrdenesFiltradas(List<OrdenDePreparacionSeleccionada> ordenesFiltradas)
        {
            listOrdenesPreparacion.Items.Clear();

            foreach (var orden in ordenesFiltradas)
            {
                ListViewItem item = new ListViewItem(orden.NumeroDeOrden);
                item.SubItems.Add(orden.CodigoCliente);
                item.SubItems.Add(orden.Fecha.ToString("dd/MM/yyyy"));
                item.SubItems.Add(orden.CodigoTransportista);
                item.SubItems.Add(((int)orden.Prioridad).ToString());
                item.SubItems.Add(orden.EstadoOrden.ToString());

                listOrdenesPreparacion.Items.Add(item);
            }
        }

        private void FiltrarBtn_Click_1(object sender, EventArgs e)
        {
            model.Cliente = ClienteTextBox.Text;
            model.FechaDesde = DesdeTimePicker.Value;
            model.FechaHasta = HastadateTimePicker.Value;
            model.Transportista = TransportistaTextBox.Text;
            model.NumeroOrden = NumeroOrdenTextBox.Text;


            var error = model.ValidarFiltro();

            if (error != null)
            {
                MessageBox.Show(error);
                return;
            }

            var ordenesFiltradas = model.FiltrarOrdenes();

            if (ordenesFiltradas == null)
            {
                return;
            }


            ActualizarListaOrdenesFiltradas(ordenesFiltradas);
        }

        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            PrioridadTextBox.Text = "";
            NumeroOrdenTextBox.Text = "";
            TransportistaTextBox.Text = "";
            ClienteTextBox.Text = "";
            HastadateTimePicker.Value = HastadateTimePicker.MinDate;
            DesdeTimePicker.Value = DesdeTimePicker.MinDate;
        }
    }
}
