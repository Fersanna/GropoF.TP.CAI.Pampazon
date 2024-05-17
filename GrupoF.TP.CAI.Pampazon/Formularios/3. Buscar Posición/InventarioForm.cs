using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoF.TP.CAI.Pampazon.Formularios._3._Buscar_Posición
{
    public partial class InventarioForm : Form
    {
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
            AgregarDatosDePrueba();
        }

        private void AgregarDatosDePrueba()
        {
            ListViewItem item1 = new ListViewItem("A1");
            item1.SubItems.Add("Producto 1");
            item1.SubItems.Add("X-Y-Z");
            item1.SubItems.Add("5");
            item1.SubItems.Add("001");

            ListViewItem item2 = new ListViewItem("A2");
            item2.SubItems.Add("Producto 2");
            item2.SubItems.Add("X-Y-Z");
            item2.SubItems.Add("7");
            item2.SubItems.Add("002");

            // Agregar elementos al ListView
            listInventario.Items.Add(item1);
            listInventario.Items.Add(item2);
        }
    }
}
