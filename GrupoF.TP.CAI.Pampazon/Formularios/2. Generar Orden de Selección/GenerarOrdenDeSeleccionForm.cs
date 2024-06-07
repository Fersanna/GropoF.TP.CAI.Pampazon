using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using GrupoF.TP.CAI.Pampazon.Formularios._2._Generar_Orden_de_Selección;
using GrupoF.TP.CAI.Pampazon.Formularios._2._Generar_Orden_de_Selección.Clases_auxiliares;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrupoF.TP.CAI.Pampazon
{
    public partial class GenerarOrdenDeSeleccionForm : Form
    {
        OrdenDeSeleccionModel model;
        public GenerarOrdenDeSeleccionForm()
        {
            InitializeComponent();
        }

        private void GenerarOrdenDeSeleccionForm_Load(object sender, EventArgs e)
        {
            model = new OrdenDeSeleccionModel();

            CargarOrdenesDePreparacion();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {

            if (!model.OrdenDePreparacion.Any(o => o.EstadoOrden == "En selección"))
            {
                MessageBox.Show("Debe seleccionar una o varias ordenes.");
                return;
            }

            OrdenDeSeleccionForm ordenDeSeleccionForm = new OrdenDeSeleccionForm
            {
                model = model
            };
            ordenDeSeleccionForm.ShowDialog();

            CargarOrdenesDePreparacion();

            this.Close();
        }

        private void CargarOrdenesDePreparacion()
        {
            listOrdenesPendientes.Items.Clear();

            if (model.OrdenDePreparacion != null)

            {
                foreach (OrdenDeSeleccion ordenes in model.OrdenDePreparacion)
                {
                    ListViewItem item = new ListViewItem(ordenes.NumeroDeOrden);
                    item.SubItems.Add(ordenes.CodigoCliente);
                    item.SubItems.Add(ordenes.Fecha.ToString());
                    item.SubItems.Add(ordenes.CodigoTransportista);
                    item.SubItems.Add(ordenes.EstadoOrden);

                    listOrdenesPendientes.Items.Add(item);

                    item.Tag = ordenes;
                }
            }

        }

        private void listOrdenesPendientes_MouseClick(object sender, MouseEventArgs e)
        {
            if (listOrdenesPendientes.SelectedItems.Count > 0)
            {
                OrdenDeSeleccion ordenSeleccionada = (OrdenDeSeleccion)listOrdenesPendientes.SelectedItems[0].Tag as OrdenDeSeleccion;


                var error = model.ValidarOrden(ordenSeleccionada);

                if (error != null)
                {
                    MessageBox.Show(error);
                    CargarOrdenesDePreparacion();
                    return;
                }

                ordenSeleccionada.EstadoOrden = "En selección";

                CargarOrdenesDePreparacion();
            }
            MessageBox.Show("La orden fue seleccionada");


        }

        private void FiltrarBtn_Click(object sender, EventArgs e)
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
        private void ActualizarListaOrdenesFiltradas(List<OrdenDeSeleccion> ordenesFiltradas)
        {
            listOrdenesPendientes.Items.Clear();

            foreach (var orden in ordenesFiltradas)
            {
                ListViewItem item = new ListViewItem(orden.NumeroDeOrden);
                item.SubItems.Add(orden.CodigoCliente);
                item.SubItems.Add(orden.Fecha.ToString());
                item.SubItems.Add(orden.CodigoTransportista);
                item.SubItems.Add(orden.EstadoOrden);

                listOrdenesPendientes.Items.Add(item);
            }
        }
    }
}
