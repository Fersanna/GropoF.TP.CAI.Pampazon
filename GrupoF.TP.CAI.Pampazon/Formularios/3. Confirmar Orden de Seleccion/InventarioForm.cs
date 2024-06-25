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
            
            var dialogResult = MessageBox.Show("¿Desea restar de stock todos los productos detallados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("La orden de selección ha sido Cumplida.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Model.Confirmar();
            }
            this.Close();
        }

        private void InventarioForm_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            foreach (var kvp in Model.CantidadesAcumuladas())
            {
                var item = new ListViewItem(new string[] {
                                                kvp.idproducto,
                                                kvp.DescripcionProducto,
                                                kvp.Posicion,
                                                kvp.Cantidad.ToString(),
                                                kvp.CodigoCliente });

                item.Tag = kvp.idproducto;
                listInventario.Items.Add(item);
            }
        }
    }
}

