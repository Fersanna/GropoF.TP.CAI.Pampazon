using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using GrupoF.TP.CAI.Pampazon.Entidades;
using GrupoF.TP.CAI.Pampazon.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GrupoF.TP.CAI.Pampazon.Clases_Auxiliares.OrdenDePreparacion;
using static GrupoF.TP.CAI.Pampazon.Entidades.Prioridades;

namespace GrupoF.TP.CAI.Pampazon.Formularios._1._Registrar_Orden_de_Preparación
{
    public partial class OrdenDePreparacionForm : Form
    {
        public OrdenDePreparacionForm()
        {
            InitializeComponent();
        }

        public BuscarClienteModel model { get; internal set; }
        public GenerarOrdenDePreparacionForm FormularioGenerarOrden { get; set; }

        public BuscarClienteForm BuscarClienteForm { get; set; }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrdenDePreparacionForm_Load(object sender, EventArgs e)
        {
            if (model.ClienteSeleccionado != null)
            {
                model.ClienteOrden.CodigoCliente = model.ClienteSeleccionado.RazonSocial;
                ClienteNombreTextBox.Text = model.ClienteOrden.CodigoCliente.ToString();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un cliente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            TranspBox.Text ="";
            model.ClienteOrden.Fecha = FechaPicker.Value;
            model.ClienteOrden.EstadoOrden = Estados.Estado.Pendiente;
            CodigoClienteTextBox.Text = model.ClienteOrden.NumeroDeOrden;

            // Obtiene los valores del enum como un array de int
            var valoresNumericos = Enum.GetValues(typeof(Prioridad)).Cast<int>().ToList();

            // Establece la lista de valores numéricos como el DataSource del ComboBox
            PrioridadComboBox.DataSource = valoresNumericos;

            ProductosOrdenList.Items.Clear();

            foreach (var productos in model.ClienteOrden.ProductosOrden)
            {
                ListViewItem item = new ListViewItem(productos.IdProducto);

                item.SubItems.Add(productos.Descripcion);
                item.SubItems.Add(productos.Posicion);
                item.SubItems.Add(productos.Cantidad.ToString());

                ProductosOrdenList.Items.Add(item);

                item.Tag = productos;

            }


        }

        private void ClienteNombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductosOrdenList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmarPrepBtn_Click(object sender, EventArgs e)
        {
            // Obtener la fecha seleccionada en el DateTimePicker
            DateTime fechaSeleccionada = FechaPicker.Value.Date;

            // Obtener la fecha actual sin la parte de la hora
            DateTime fechaActual = DateTime.Now.Date;

            // Comparar la fecha seleccionada con la fecha actual
            if (fechaSeleccionada < fechaActual)
            {
                MessageBox.Show("Fecha inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(TranspBox.Text))
            {
                MessageBox.Show("Debe agregar un transportista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PrioridadComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Debe agregar una Prioridad (1, 2 o 3)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Subir a ordenes confirmadas, validar y volver a menu principal
            var nuevaOrden = model.ClienteOrden;
            {

                nuevaOrden.CodigoCliente = model.ClienteSeleccionado.CodigoCliente;
                nuevaOrden.CodigoTransportista = TranspBox.Text;
                nuevaOrden.Fecha = FechaPicker.Value;
                nuevaOrden.EstadoOrden = Estados.Estado.Pendiente;
                nuevaOrden.Prioridad = (Prioridad)(int)PrioridadComboBox.SelectedItem;
                nuevaOrden.ProductosOrden = new();
            };

            foreach (ListViewItem item in ProductosOrdenList.Items)
            {
                var producto = item.Tag as Productos;
                if (producto != null)
                {
                    nuevaOrden.ProductosOrden.Add(producto);
                }

                model.ClienteOrden = nuevaOrden;
            }

            model.GenerarNuevaOrdenDePreparacion();


            // Cerrar el formulario o limpiar los campos si es necesario
            this.Close();
            FormularioGenerarOrden.CerrarGenerarOrdenDePreparacionForm();
            BuscarClienteForm.CerrarClientes();

        }
    }
}
