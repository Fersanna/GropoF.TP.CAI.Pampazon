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
                    item.SubItems.Add(producto.Descripcion);
                    item.SubItems.Add(producto.Posicion);
                    item.SubItems.Add(producto.Cantidad.ToString());

                    ProductosList.Items.Add(item);

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

            var error = model.ValidarCantidadProductos();

            if (error != null)
            {
                MessageBox.Show(error);
                return;
            }
            else
            {
                OrdenDePreparacionForm ordenDePreparacionForm = new OrdenDePreparacionForm();
                ordenDePreparacionForm.model = model;
                ordenDePreparacionForm.ShowDialog();

            }


        }

        private void PorductosList_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        public void AgregarBtn_Click(object sender, EventArgs e)
        {
            if (ProductosList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = ProductosList.SelectedItems[0];
                Productos selectedProducto = (Productos)selectedItem.Tag;

                bool productoExiste = false;

                foreach (DataGridViewRow row in EditarOrden_GridView.Rows)
                {
                    if (!row.IsNewRow && row.Cells["IdProducto"].Value.ToString() == selectedProducto.IdProducto)
                    {
                        productoExiste = true;
                        MessageBox.Show("Este producto ya está agregado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
                if (!productoExiste)
                {
                    // Crear una nueva fila en el DataGridView
                    int rowIndex = EditarOrden_GridView.Rows.Add();
                    DataGridViewRow newRow = EditarOrden_GridView.Rows[rowIndex];


                    newRow.Cells["IdProducto"].Value = selectedProducto.IdProducto;
                    newRow.Cells["Descripcion"].Value = selectedProducto.Descripcion;
                    newRow.Cells["Posicion"].Value = selectedProducto.Posicion;
                    newRow.Cells["Cantidad"].Value = selectedProducto.Cantidad;  // Inicialmente usa la cantidad máxima disponible

                    newRow.Tag = selectedProducto;


                    EditarOrden_GridView.BeginEdit(true);

                    if (model.ClienteOrden == null)
                    {
                        model.ClienteOrden = new OrdenDePreparacion();
                        model.ClienteOrden.CodigoCliente = model.ClienteSeleccionado.CodigoCliente;
                        model.ClienteOrden.ProductosOrden = new List<Productos>();
                    }


                    model.ClienteOrden.ProductosOrden.Add(new Productos()
                    {
                        IdProducto = (string)newRow.Cells["IdProducto"].Value,
                        Descripcion = (string)newRow.Cells["Descripcion"].Value,
                        Posicion = (string)newRow.Cells["Posicion"].Value,
                        Cantidad = (int)newRow.Cells["Cantidad"].Value,
                    });

                   // MessageBox.Show("Se han agregado " + model.ClienteOrden.ProductosOrden.Count() + "a la orden"); Para probar que el producto se este agregando correctamente a la orden.
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un producto primero.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void EditarOrden_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditarOrden_GridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv.Rows[e.RowIndex].IsNewRow)
            {
                return;
            }

            if (e.ColumnIndex == 3)
            {
                DataGridViewRow row = EditarOrden_GridView.Rows[e.RowIndex];
                string idProducto = row.Cells["IdProducto"].Value.ToString();

                // Buscar el producto en el modelo y actualizar la cantidad
                Productos producto = model.ClienteOrden.ProductosOrden.FirstOrDefault(p => p.IdProducto == idProducto);
                if (producto != null)
                {
                    if (!int.TryParse(e.FormattedValue.ToString(), out int nuevaCantidad))
                    {
                        MessageBox.Show("La cantidad ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true; // Cancela la edición
                    }
                    if (producto != null)
                    {
                        producto.Cantidad = nuevaCantidad;
                    }
                    if (nuevaCantidad < 0)
                    {
                        MessageBox.Show("La cantidad no puede ser menor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true; // Cancela la edición
                    }

                }
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            EditarOrden_GridView.Rows.Clear();


            if (model.ClienteOrden != null && model.ClienteOrden.ProductosOrden != null)
            {
                model.ClienteOrden.ProductosOrden.Clear();
            }
            this.Close();
        }

        private void GenerarOrdenDePreparacionForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (model.ClienteOrden != null && model.ClienteOrden.ProductosOrden != null)
            {
                model.ClienteOrden.ProductosOrden.Clear();
            }


        }

        private void QuitarBtn_Click(object sender, EventArgs e)
        {
            if (EditarOrden_GridView.SelectedRows.Count > 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow selectedRow = EditarOrden_GridView.SelectedRows[0];

                // Elimina la fila seleccionada del DataGridView
                EditarOrden_GridView.Rows.Remove(selectedRow);

                if (selectedRow.Tag is Productos producto)
                {

                    var error = model.QuitarProductoDelaOrden(producto);

                    if (error != null)
                    {
                        MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        MessageBox.Show("El producto ha sido eliminado");
                    }
                }


            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para quitar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }


}





