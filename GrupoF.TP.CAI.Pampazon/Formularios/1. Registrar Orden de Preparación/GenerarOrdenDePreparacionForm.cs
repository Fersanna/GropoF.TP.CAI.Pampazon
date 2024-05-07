using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using GrupoF.TP.CAI.Pampazon.Formularios._1._Registrar_Orden_de_Preparación;
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

namespace GrupoF.TP.CAI.Pampazon.Formularios
{
    public partial class GenerarOrdenDePreparacionForm : Form
    {
        public BuscarClienteModel model { get; set; }

        public GenerarOrdenDePreparacionForm(BuscarClienteModel model)
        {
            InitializeComponent();


        }

        private void GenerarOrdenDePreparacionForm_Load(object sender, EventArgs e)
        {


            ProductosList.Items.Clear();

            if (model.ClienteSeleccionado != null && model.ClienteSeleccionado.Productos != null)
            {
                foreach (Productos producto in model.ClienteSeleccionado.Productos)
                {
                    ListViewItem item = new ListViewItem(producto.IdProducto); // Usa el IdProducto como el primer texto del ítem.
                    item.SubItems.Add(producto.Descripcion); // Añade descripción como subítem.
                    item.SubItems.Add(producto.Posicion); // Añade posición como subítem.
                    item.SubItems.Add(producto.Cantidad.ToString()); // Añade cantidad como subítem, asegúrate de convertirlo a string si es necesario.

                    ProductosList.Items.Add(item); // Añade el ítem al ListView.

                    item.Tag = producto;
                }
            }
            else
            {
                MessageBox.Show("No hay productos para mostrar o el cliente no está seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void GenerarBtn_Click(object sender, EventArgs e)
        {
            OrdenDePreparacionForm ordenDePreparacionForm = new OrdenDePreparacionForm();
            ordenDePreparacionForm.ShowDialog();
        }

        private void PorductosList_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            if (ProductosList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = ProductosList.SelectedItems[0];
                Productos selectedProducto = (Productos)selectedItem.Tag;

                ListViewItem ordenItem = new ListViewItem(selectedProducto.IdProducto);
                ordenItem.SubItems.Add(selectedProducto.Descripcion);
                ordenItem.SubItems.Add(selectedProducto.Posicion);
                ordenItem.SubItems.Add(selectedProducto.Cantidad.ToString());

                OdenEnPrepList.Items.Add(ordenItem);
            }

            else
            {
                MessageBox.Show("Por favor, seleccione un producto primero.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }


}

