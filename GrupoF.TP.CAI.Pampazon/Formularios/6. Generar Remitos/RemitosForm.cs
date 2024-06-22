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
        public DateTime FechaRemito { get; set; }
        public string NumeroDeRemito { get; set; }

        public string RazonSocialCliente { get; set; }

        public string DomicilioCliente { get; set; }

        public string CuitCliente { get; set; }

        public RemitosForm()
        {
            InitializeComponent();

        }




        private void ImprimirBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El remito se ha generado con éxito.");
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemitosForm_Load(object sender, EventArgs e)
        {
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
        }
    }
}
