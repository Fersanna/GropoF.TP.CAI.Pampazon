using GrupoF.TP.CAI.Pampazon.Almacenes;
using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using GrupoF.TP.CAI.Pampazon.Entidades;
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
        public ConfirmarOrdenDeSeleccionModel Model;

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
            var ordenesSeleccionada = Model.OrdenDeSeleccionElegida;
            var numerosDeOrden = ordenesSeleccionada.SeleccionDetalle; //ID's de las ordenes de preparación.

            var ordenesDePreparacion = AlmacenOrdenesDePreparacion.OrdenDePreparacionEnts
                                            .Where(o => numerosDeOrden.Contains(o.NumeroDeOrden))
                                            .ToList();

            if (!ordenesDePreparacion.Any()) //Esto es un FI
            {
                throw new ApplicationException($"La orden de seleccion {ordenesSeleccionada.IdOrdenDeSeleccion} no tiene ordenes de preparacion asociadas.");
            }

            foreach (var ordenDePreparacion in ordenesDePreparacion)
            {
                foreach (var detalle in ordenDePreparacion.Detalle)
                {
                    var producto = AlmacenProductos.Productos
                                                   .Single(p => p.IdProducto == detalle.IdProducto);

                    ListViewItem item = new ListViewItem(producto.IdProducto);
                    item.SubItems.Add(producto.Descripcion);
                    item.SubItems.Add(producto.Posicion);
                    item.SubItems.Add(detalle.Cantidad.ToString());
                    item.SubItems.Add(ordenDePreparacion.CodigoCliente);
                    listInventario.Items.Add(item);

                    item.Tag = producto;
                }
            }
        }
    }
}

