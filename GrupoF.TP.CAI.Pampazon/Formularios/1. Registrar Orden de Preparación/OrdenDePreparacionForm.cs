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
            ProductosOrdenList.Items.Clear();

            foreach (var productos in model.ClienteOrden.ProductosOrden)
            {
                ListViewItem item = new ListViewItem(productos.IdProducto);

                item.SubItems.Add(productos.Descripcion); // Añade descripción como subítem.
                item.SubItems.Add(productos.Posicion); // Añade posición como subítem.
                item.SubItems.Add(productos.Cantidad.ToString()); // Añade cantidad como subítem, 

                 ProductosOrdenList.Items.Add(item); // Añade el ítem al ListView.

                 item.Tag = productos;

            }



        }
    }
}
