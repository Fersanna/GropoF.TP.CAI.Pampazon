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
            var ordenesSeleccionadas = AlmacenOrdenDeSeleccion.OrdenesDeSeleccionEnt
       .Where(o => o.EstadoOrdenSeleccion == EstadoSeleccionEnum.EstadoSeleccion.Pendiente)
       .ToList();

            var numerosDeOrden = ordenesSeleccionadas
        .SelectMany(o => o.SeleccionDetalle)
        .Select(d => d.NumeroDeOrden)
        .ToList();

            var ordenesDePreparacion = AlmacenOrdenesDePreparacion.OrdenDePreparacionEnts
       .Where(o => numerosDeOrden.Contains(o.NumeroDeOrden))
       .ToList();


            if (ordenesDePreparacion.Any())
            {
                foreach (var ordenDePreparacion in ordenesDePreparacion)
                {
                    foreach (var detalle in ordenDePreparacion.Detalle)
                    {
                       
                        var producto = AlmacenProductos.Productos
                            .FirstOrDefault(p => p.IdProducto == detalle.IdProducto);

                        if (producto != null)
                        {
                            
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
            else
            {
                MessageBox.Show("No hay órdenes de preparación asociadas a las órdenes de selección pendientes.");
            }


        }
    }
}

