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
            model.ClienteOrden.CodigoCliente = model.ClienteSeleccionado.CodigoCliente.ToString();
            ClienteNombreTextBox.Text = model.ClienteOrden.CodigoCliente.ToString();
            CodigoClienteTextBox.Text = "P-000001";

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
    }
}
