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
    public partial class BuscarPosicionForm : Form
    {
        public BuscarPosicionForm()
        {
            InitializeComponent();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultarBtn_Click(object sender, EventArgs e)
        {
            if (listOrdenesDeSeleccion.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una orden.");
            }
            else
            {
                InventarioForm inventarioForm = new InventarioForm();
                inventarioForm.ShowDialog();
            }
        }

        private void AgregarDatosDePrueba()
        {
            ListViewItem item1 = new ListViewItem("S-000001");
            item1.SubItems.Add("1");

            ListViewItem item2 = new ListViewItem("S-000002");
            item2.SubItems.Add("2");

            ListViewItem item3 = new ListViewItem("S-000003");
            item3.SubItems.Add("3");

            ListViewItem item4 = new ListViewItem("S-000004");
            item4.SubItems.Add("2");

            // Agregar elementos al ListView
            listOrdenesDeSeleccion.Items.Add(item1);
            listOrdenesDeSeleccion.Items.Add(item2);
            listOrdenesDeSeleccion.Items.Add(item3);
            listOrdenesDeSeleccion.Items.Add(item4);
        }

        private void BuscarPosicionForm_Load(object sender, EventArgs e)
        {
            AgregarDatosDePrueba();
        }
    }
}
