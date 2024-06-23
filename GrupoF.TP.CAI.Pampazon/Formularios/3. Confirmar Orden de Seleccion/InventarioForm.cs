using GrupoF.TP.CAI.Pampazon.Almacenes;
using GrupoF.TP.CAI.Pampazon.Entidades;
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
            var error = Model.Confirmar();
            if (error == null)
            {
                MessageBox.Show("Se han eliminado los productos del inventario con éxito.");
                this.Close();
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void InventarioForm_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            /* ANDRES
            var ordenesSeleccionada = Model.OrdenDeSeleccionElegida;
            var numerosDeOrden = ordenesSeleccionada.SeleccionDetalle; //ID's de las ordenes de preparación.

            var ordenesDePreparacion = AlmacenOrdenesDePreparacion.OrdenDePreparacionEnts
                                            .Where(o => numerosDeOrden.Contains(o.NumeroDeOrden))
                                            .ToList();

            if (!ordenesDePreparacion.Any()) 
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
            */

            var ordenesSeleccionada = Model.OrdenDeSeleccionElegida;
            if (ordenesSeleccionada == null)
            {
                throw new ApplicationException("No se ha seleccionado ninguna orden.");
            }

            var numerosDeOrden = ordenesSeleccionada.SeleccionDetalle; // ID's de las ordenes de preparación.
            if (numerosDeOrden == null || !numerosDeOrden.Any())
            {
                throw new ApplicationException($"La orden de selección {ordenesSeleccionada.IdOrdenDeSeleccion} no tiene detalles de selección.");
            }

            var ordenesDePreparacion = AlmacenOrdenesDePreparacion.OrdenDePreparacionEnts
                                            .Where(o => numerosDeOrden.Contains(o.NumeroDeOrden))
                                            .ToList();

            if (!ordenesDePreparacion.Any())
            {
                throw new ApplicationException($"La orden de selección {ordenesSeleccionada.IdOrdenDeSeleccion} no tiene órdenes de preparación asociadas.");
            }

            // Pre-cargar los productos en un diccionario para evitar múltiples consultas a la base de datos
            var idsProductos = ordenesDePreparacion.SelectMany(o => o.Detalle.Select(d => d.IdProducto)).Distinct();
            var productos = AlmacenProductos.Productos
                                             .Where(p => idsProductos.Contains(p.IdProducto))
                                             .ToDictionary(p => p.IdProducto);

            // Diccionario para almacenar las cantidades acumuladas por producto y la última posición y código cliente encontrados
            var cantidadesAcumuladas = new Dictionary<string, (int Cantidad, string Posicion, string CodigoCliente)>();

            foreach (var ordenDePreparacion in ordenesDePreparacion)
            {
                foreach (var detalle in ordenDePreparacion.Detalle)
                {
                    if (!productos.TryGetValue(detalle.IdProducto, out var producto))
                    {
                        // Manejar el caso en el que el producto no se encuentra
                        continue;
                    }

                    // Utilizar IdProducto como string ya que las claves del diccionario de productos son de tipo string
                    string idProducto = detalle.IdProducto;

                    // Acumular las cantidades, posición y código cliente
                    if (cantidadesAcumuladas.ContainsKey(idProducto))
                    {
                        var acumulado = cantidadesAcumuladas[idProducto];
                        cantidadesAcumuladas[idProducto] = (acumulado.Cantidad + detalle.Cantidad, producto.Posicion, ordenDePreparacion.CodigoCliente);
                    }
                    else
                    {
                        cantidadesAcumuladas[idProducto] = (detalle.Cantidad, producto.Posicion, ordenDePreparacion.CodigoCliente);
                    }
                }
            }

            // Agregar los productos y sus cantidades acumuladas a la lista
            foreach (var kvp in cantidadesAcumuladas)
            {
                string key = kvp.Key; // Asegurarse de que key es string
                if (productos.TryGetValue(key, out var producto))
                {
                    var (cantidad, posicion, codigoCliente) = kvp.Value;

                    ListViewItem item = new ListViewItem(new[] {
                producto.IdProducto.ToString(),
                producto.Descripcion,
                posicion,
                cantidad.ToString(),
                codigoCliente
            });
                    item.Tag = producto;
                    listInventario.Items.Add(item);
                }
            }
        }
    }
}

