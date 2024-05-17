using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
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
        OrdenDeSeleccionModel model;
        public GenerarOrdenDeSeleccionForm()
        {
            InitializeComponent();
        }

        private void GenerarOrdenDeSeleccionForm_Load(object sender, EventArgs e)
        {
            model = new OrdenDeSeleccionModel();

            CargarOrdenesDePreparacion();
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
               // ordenDeSeleccionForm.CargarDatos(items);
                ordenDeSeleccionForm.ShowDialog();
            }
        }

        private void CargarOrdenesDePreparacion()
        {
            listOrdenesPendientes.Items.Clear();

            foreach (OrdenDePreparacion ordenes in model.OrdenDePreparacion)
            {
                ListViewItem item = new ListViewItem(ordenes.NumeroDeOrden);
                item.SubItems.Add(ordenes.CodigoCliente);
                item.SubItems.Add(ordenes.Fecha.ToString());
                item.SubItems.Add(ordenes.CodigoTransportista);
                item.SubItems.Add(ordenes.EstadoOrden);

                listOrdenesPendientes.Items.Add(item);

                item.Tag=ordenes;
            }
            
        }
    }
}