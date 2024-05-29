using GrupoF.TP.CAI.Pampazon.Formularios._7._Confirmar_Orden_de_Entrega;
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
    public partial class ConfirmarOrdenDeEntregaForm : Form
    {
        ConfirmarOrdenDeEntregaModel model;
        public ConfirmarOrdenDeEntregaForm()
        {
            InitializeComponent();
        }

        private void ConfirmarOrdenDeEntregaForm_Load(object sender, EventArgs e)
        {
            model =new ConfirmarOrdenDeEntregaModel();
            AgregarDatosDePrueba();
        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            if (listOrdenesPreparadas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una orden.");
            }
            else
            {
                // Crear una lista para almacenar los elementos seleccionados del ListView
                List<ListViewItem> items = new List<ListViewItem>();

                // Copiar los elementos seleccionados del ListView actual
                foreach (ListViewItem item in listOrdenesPreparadas.SelectedItems)
                {
                    ListViewItem newItem = (ListViewItem)item.Clone();
                    newItem.SubItems[newItem.SubItems.Count - 1].Text = "Despachada"; // Actualizar la última subcolumna a "Despachada"
                    items.Add(newItem);
                }

                OrdenDespachadaForm ordenDespachadaForm = new OrdenDespachadaForm();
                ordenDespachadaForm.model = model;
                ordenDespachadaForm.CargarDatos(items);
                ordenDespachadaForm.ShowDialog();
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
            listOrdenesPreparadas.Items.Add(item1);
            listOrdenesPreparadas.Items.Add(item2);
            listOrdenesPreparadas.Items.Add(item3);
            listOrdenesPreparadas.Items.Add(item4);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SiguienteBtn_Click(object sender, EventArgs e)
        {
            OrdenDespachadaForm ordenDespachadaForm = new OrdenDespachadaForm();
            ordenDespachadaForm.ShowDialog();
        }
    }
}
