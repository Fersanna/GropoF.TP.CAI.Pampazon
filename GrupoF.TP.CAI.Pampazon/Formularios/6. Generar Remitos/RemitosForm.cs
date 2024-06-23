using GrupoF.TP.CAI.Pampazon.Almacenes;
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

namespace GrupoF.TP.CAI.Pampazon.Formularios._6._Generar_Documentos
{
    public partial class RemitosForm : Form
    {
        public GenerarRemitosModel model { get; set; }


        public RemitosForm()
        {
            InitializeComponent();

        }




        private void ImprimirBtn_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("¿Desea generar un remito?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                //Cambiar estado de la orden y Guardar el remito generado en Json.
                model.CambiarEstadoOrdenSeleccionada();
                model.GuardarRemito();

                MessageBox.Show("El remito se ha generado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemitosForm_Load(object sender, EventArgs e)
        {


            var ordenSeleccionada = model.OrdenSeleccionada;
            var IdCliente = ordenSeleccionada.CodigoCliente;

            var clienteSeleccionado = AlmacenClientes.Clientes
                                         .FirstOrDefault(clienteEnt => clienteEnt.CodigoCliente == IdCliente);

            RazonSocialTexBox.Text = clienteSeleccionado.RazonSocial;
            DomicilioTextBox.Text = clienteSeleccionado.Domicilio;
            Cuit_Box.Text = clienteSeleccionado.Cuit;

            CargarProductos();

            /*
            RazonSocialTexBox.Text = model.OrdenSeleccionada.CodigoCliente;
           
            
            foreach(Productos producto in model.OrdenSeleccionada.ProductosOrden)
            {
                  ListViewItem item = new ListViewItem(producto.IdProducto);
                    item.SubItems.Add(producto.Descripcion);
                    item.SubItems.Add(producto.Cantidad.ToString());
                 

                    ProductosList.Items.Add(item);

                    item.Tag = producto;
            }
            */
        }

        private void CargarProductos()
        {
            /* ANDRES
            var ordenesSeleccionada = model.OrdenSeleccionada;
            var numerosDeOrden = ordenesSeleccionada.EntregaDetalle; //ID's de las ordenes de preparación.

            var ordenesDePreparacion = AlmacenOrdenesDePreparacion.OrdenDePreparacionEnts
                                            .Where(o => numerosDeOrden.Contains(o.NumeroDeOrden))
                                            .ToList();

            if (!ordenesDePreparacion.Any()) //Esto es un FI
            {
                throw new ApplicationException($"La orden de seleccion {ordenesSeleccionada.IdOrdenDeEntrega} no tiene ordenes de preparacion asociadas.");
            }

            foreach (var ordenDePreparacion in ordenesDePreparacion)
            {
                foreach (var detalle in ordenDePreparacion.Detalle)
                {
                    var producto = AlmacenProductos.Productos
                                                   .Single(p => p.IdProducto == detalle.IdProducto);

                    ListViewItem item = new ListViewItem(producto.IdProducto);
                    item.SubItems.Add(producto.Descripcion);
                    item.SubItems.Add(detalle.Cantidad.ToString());
                    ProductosList.Items.Add(item);

                    item.Tag = producto;
                }
            }
            */
            
            var ordenesSeleccionada = model.OrdenSeleccionada;
            if (ordenesSeleccionada == null)
            {
                throw new ApplicationException("No se ha seleccionado ninguna orden.");
            }

            var numerosDeOrden = ordenesSeleccionada.EntregaDetalle; // ID's de las ordenes de preparación.
            if (numerosDeOrden == null || !numerosDeOrden.Any())
            {
                throw new ApplicationException($"La orden de selección {ordenesSeleccionada.IdOrdenDeEntrega} no tiene detalles de entrega.");
            }

            var ordenesDePreparacion = AlmacenOrdenesDePreparacion.OrdenDePreparacionEnts
                                            .Where(o => numerosDeOrden.Contains(o.NumeroDeOrden))
                                            .ToList();

            if (!ordenesDePreparacion.Any()) // Esto es un FI
            {
                throw new ApplicationException($"La orden de selección {ordenesSeleccionada.IdOrdenDeEntrega} no tiene órdenes de preparación asociadas.");
            }

            // Pre-cargar los productos en un diccionario para evitar múltiples consultas a la base de datos
            var idsProductos = ordenesDePreparacion.SelectMany(o => o.Detalle.Select(d => d.IdProducto)).Distinct();
            var productos = AlmacenProductos.Productos
                                            .Where(p => idsProductos.Contains(p.IdProducto))
                                            .ToDictionary(p => p.IdProducto);

            // Diccionario para agrupar y sumar las cantidades de productos
            var productosAgrupados = new Dictionary<string, (string Descripcion, int Cantidad)>();

            foreach (var ordenDePreparacion in ordenesDePreparacion)
            {
                foreach (var detalle in ordenDePreparacion.Detalle)
                {
                    if (!productos.TryGetValue(detalle.IdProducto, out var producto))
                    {
                        // Manejar el caso en el que el producto no se encuentra
                        continue;
                    }

                    if (productosAgrupados.ContainsKey(detalle.IdProducto))
                    {
                        // Sumar la cantidad si el producto ya está en el diccionario
                        productosAgrupados[detalle.IdProducto] = (
                            productosAgrupados[detalle.IdProducto].Descripcion,
                            productosAgrupados[detalle.IdProducto].Cantidad + detalle.Cantidad
                        );
                    }
                    else
                    {
                        // Agregar nuevo producto al diccionario
                        productosAgrupados[detalle.IdProducto] = (producto.Descripcion, detalle.Cantidad);
                    }
                }
            }

            // Agregar los productos agrupados a la lista visual
            foreach (var productoAgrupado in productosAgrupados)
            {
                ListViewItem item = new ListViewItem(new[] {
            productoAgrupado.Key,  // Asumiendo que Key es del tipo string
            productoAgrupado.Value.Descripcion,
            productoAgrupado.Value.Cantidad.ToString()
        });
                item.Tag = productos[productoAgrupado.Key];
                ProductosList.Items.Add(item);
            }
        }
    }
}
