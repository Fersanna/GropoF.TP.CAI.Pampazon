using GrupoF.TP.CAI.Pampazon.Formularios._2._Generar_Orden_de_Selección;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrupoF.TP.CAI.Pampazon
{
    public partial class GenerarOrdenDeSeleccionForm : Form
    {
        public GenerarOrdenDeSeleccionForm()
        {
            InitializeComponent();
        }

        private void GenerarOrdenDeSeleccionForm_Load(object sender, EventArgs e)
        {
            AgregarDatosDePrueba();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            if (listOrdenesPendientes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una o varias ordenes.");
            }
            else
            {
                // Crear una lista para almacenar los elementos seleccionados del ListView
                List<ListViewItem> items = new List<ListViewItem>();

                // Copiar los elementos seleccionados del ListView actual
                foreach (ListViewItem item in listOrdenesPendientes.SelectedItems)
                {
                    ListViewItem newItem = (ListViewItem)item.Clone();
                    items.Add(newItem);
                }

                OrdenDeSeleccionForm ordenDeSeleccionForm = new OrdenDeSeleccionForm();
                ordenDeSeleccionForm.CargarDatos(items);
                ordenDeSeleccionForm.ShowDialog();
            }
        }

        private void AgregarDatosDePrueba()
        {
            ListViewItem item1 = new ListViewItem("P-000001");
            item1.SubItems.Add("001");
            item1.SubItems.Add("13/05/24");
            item1.SubItems.Add("Transportista 1");
            item1.SubItems.Add("Pendiente");

            ListViewItem item2 = new ListViewItem("P-000002");
            item2.SubItems.Add("002");
            item2.SubItems.Add("13/05/24");
            item2.SubItems.Add("Transportista 2");
            item2.SubItems.Add("Pendiente");

            ListViewItem item3 = new ListViewItem("P-000003");
            item3.SubItems.Add("003");
            item3.SubItems.Add("14/05/24");
            item3.SubItems.Add("Transportista 3");
            item3.SubItems.Add("Pendiente");

            ListViewItem item4 = new ListViewItem("P-000004");
            item4.SubItems.Add("002");
            item4.SubItems.Add("15/05/24");
            item4.SubItems.Add("Transportista 4");
            item4.SubItems.Add("Pendiente");

            // Agregar elementos al ListView
            listOrdenesPendientes.Items.Add(item1);
            listOrdenesPendientes.Items.Add(item2);
            listOrdenesPendientes.Items.Add(item3);
            listOrdenesPendientes.Items.Add(item4);
        }
    }
}