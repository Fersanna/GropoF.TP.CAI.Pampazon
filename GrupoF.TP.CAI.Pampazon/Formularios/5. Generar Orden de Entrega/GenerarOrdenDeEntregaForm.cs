using GrupoF.TP.CAI.Pampazon.Formularios._2._Generar_Orden_de_Selección;
using GrupoF.TP.CAI.Pampazon.Formularios._5._Generar_Orden_de_Entrega;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoF.TP.CAI.Pampazon
{
    public partial class GenerarOrdenDeEntregaForm : Form
    {
        public GenerarOrdenDeEntregaForm()
        {
            InitializeComponent();
        }

        private void GenerarOrdenDeEntregaForm_Load(object sender, EventArgs e)
        {
            AgregarDatosDePrueba();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            if (listOrdenesSeleccionadas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una o varias ordenes.");
            }
            else
            {
                // Crear una lista para almacenar los elementos seleccionados del ListView
                List<ListViewItem> items = new List<ListViewItem>();

                // Copiar los elementos seleccionados del ListView actual
                foreach (ListViewItem item in listOrdenesSeleccionadas.SelectedItems)
                {
                    ListViewItem newItem = (ListViewItem)item.Clone();
                    items.Add(newItem);
                }

                OrdenDeEntregaForm ordenDeEntregaForm = new OrdenDeEntregaForm();
                ordenDeEntregaForm.CargarDatos(items);
                ordenDeEntregaForm.ShowDialog();
            }
        }

        private void AgregarDatosDePrueba()
        {
            ListViewItem item1 = new ListViewItem("P-000001");
            item1.SubItems.Add("001");
            item1.SubItems.Add("13/05/24");
            item1.SubItems.Add("Transportista 1");
            item1.SubItems.Add("Seleccionada");

            ListViewItem item2 = new ListViewItem("P-000002");
            item2.SubItems.Add("002");
            item2.SubItems.Add("13/05/24");
            item2.SubItems.Add("Transportista 2");
            item2.SubItems.Add("Seleccionada");

            ListViewItem item3 = new ListViewItem("P-000003");
            item3.SubItems.Add("003");
            item3.SubItems.Add("14/05/24");
            item3.SubItems.Add("Transportista 3");
            item3.SubItems.Add("Seleccionada");

            ListViewItem item4 = new ListViewItem("P-000004");
            item4.SubItems.Add("002");
            item4.SubItems.Add("15/05/24");
            item4.SubItems.Add("Transportista 4");
            item4.SubItems.Add("Seleccionada");

            // Agregar elementos al ListView
            listOrdenesSeleccionadas.Items.Add(item1);
            listOrdenesSeleccionadas.Items.Add(item2);
            listOrdenesSeleccionadas.Items.Add(item3);
            listOrdenesSeleccionadas.Items.Add(item4);
        }
    }
}
