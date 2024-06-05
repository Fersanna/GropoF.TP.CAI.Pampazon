using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
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

namespace GrupoF.TP.CAI.Pampazon.Formularios._1._Registrar_Orden_de_Preparación
{
    public partial class OrdenDePreparacionForm : Form
    {
        public OrdenDePreparacionForm()
        {
            InitializeComponent();
        }

        public BuscarClienteModel model { get; internal set; }

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
            model.ClienteOrden.CodigoTransportista = TransportistaBox.Text;
            model.ClienteOrden.Fecha = FechaPicker.Value;
            model.ClienteOrden.EstadoOrden = "Disponible";
            CodigoClienteTextBox.Text = model.ClienteOrden.NumeroDeOrden;


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
            //Subir a ordenes confirmadas, validar y volver a menu principal
            var nuevaOrden = new OrdenDePreparacion
            {
                CodigoCliente = model.ClienteSeleccionado.CodigoCliente,
                CodigoTransportista = TransportistaBox.Text,
                Fecha = FechaPicker.Value,
                EstadoOrden = "Disponible",
                ProductosOrden = new List<Productos>()
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

            MessageBox.Show("La orden fue cargada con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cerrar el formulario o limpiar los campos si es necesario
            this.Close();
        }
    }
}
