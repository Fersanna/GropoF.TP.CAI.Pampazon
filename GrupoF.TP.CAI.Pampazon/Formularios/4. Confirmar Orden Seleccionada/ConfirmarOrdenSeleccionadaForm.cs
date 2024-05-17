using GrupoF.TP.CAI.Pampazon.Formularios._3._Buscar_Posición;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrupoF.TP.CAI.Pampazon.Formularios._4._Confirmar_Orden_Seleccionada
{
    public partial class ConfirmarOrdenSeleccionadaForm : Form
    {
        public ConfirmarOrdenSeleccionadaForm()
        {
            InitializeComponent();
        }

        private void ConfirmarOrdenSeleccionadaForm_Load(object sender, EventArgs e)
        {
            AgregarDatosDePrueba();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            if (listOrdenesEnSeleccion.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una orden.");
            }
            else
            {
                MessageBox.Show("La orden se ha confirmado con éxito.");

                foreach (ListViewItem item in listOrdenesEnSeleccion.SelectedItems)
                {
                    listOrdenesEnSeleccion.Items.Remove(item);
                }
            }
        }

        private void AgregarDatosDePrueba()
        {
            ListViewItem item1 = new ListViewItem("P-000001");
            item1.SubItems.Add("001");
            item1.SubItems.Add("13/05/24");
            item1.SubItems.Add("Transportista 1");
            item1.SubItems.Add("En selección");

            ListViewItem item2 = new ListViewItem("P-000002");
            item2.SubItems.Add("002");
            item2.SubItems.Add("13/05/24");
            item2.SubItems.Add("Transportista 2");
            item2.SubItems.Add("En selección");

            // Agregar elementos al ListView
            listOrdenesEnSeleccion.Items.Add(item1);
            listOrdenesEnSeleccion.Items.Add(item2);
        }
    }
}
