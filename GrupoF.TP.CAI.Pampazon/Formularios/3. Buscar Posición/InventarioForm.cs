using GrupoF.TP.CAI.Pampazon.Formularios._3._Buscar_Posición.Clases_Auxiliares;
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

namespace GrupoF.TP.CAI.Pampazon.Formularios._3._Buscar_Posición
{
    public partial class InventarioForm : Form
    {
        ConfirmarOrdenDeSeleccionModel model;

        public InventarioForm()
        {
            InitializeComponent();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se han eliminado los productos del inventario con éxito.");
        }

        private void InventarioForm_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            
            /*
            
            if (model.Productos != null)

            {
                
                
                foreach (ProductosARestar productosARestar in model.Productos)
                {
                    if (productosARestar == Entidades.ProductoEnt)
                    {

                        {
                            ListViewItem item = new ListViewItem(productosARestar.IdProducto);
                            // string detallesUnidos = string.Join(" - ", ordenesSeleccionada.OrdenesSeleccionadas);
                            item.SubItems.Add(productosARestar.IdProducto);
                            item.SubItems.Add(productosARestar.Descripcion);
                            item.SubItems.Add(productosARestar.Posicion);
                            item.SubItems.Add(productosARestar.Cantidad.ToString());
                            item.SubItems.Add(productosARestar.CodigoCliente);


                            listInventario.Items.Add(item);

                            item.Tag = productosARestar;
                        }
                    }
                }
            }

            */
        }
    }
}
