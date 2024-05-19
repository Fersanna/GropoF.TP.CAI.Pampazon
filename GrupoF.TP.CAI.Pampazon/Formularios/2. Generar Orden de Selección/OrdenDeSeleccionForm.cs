using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoF.TP.CAI.Pampazon.Formularios._2._Generar_Orden_de_Selección
{
    public partial class OrdenDeSeleccionForm : Form
    {
        public OrdenDeSeleccionModel model { get; set; }
        public OrdenDeSeleccionForm()
        {
            InitializeComponent();
        }

        private void GenerarBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PrioridadBox.Text))
            {
                MessageBox.Show("Complete el campo de prioridad (1, 2 o 3).");
            }
            else
            {
                // Verifica si el contenido del TextBox es válido (1, 2 o 3)
                if (PrioridadBox.Text == "1" || PrioridadBox.Text == "2" || PrioridadBox.Text == "3")
                {
                    // Aquí puedes colocar el código para generar algo
                    MessageBox.Show("La orden de selección ha sido generada con éxito. Prioridad " + PrioridadBox.Text);
                }
                else
                {
                    MessageBox.Show("Ingrese un valor válido para la prioridad (1, 2 o 3).");
                }
            }
        }

        public void CargarDatos(List<ListViewItem> items)
        {
            ListOrdenesSeleccionConfirmadas.Items.AddRange(items.ToArray());
        }

        private void OrdenDeSeleccionForm_Load(object sender, EventArgs e)
        {
             foreach (OrdenDePreparacion ordenesSeleccionada in model.OrdenDePreparacion)
            {
                        if (ordenesSeleccionada.EstadoOrden == "Seleccionada")
                {
                            ListViewItem item = new ListViewItem(ordenesSeleccionada.NumeroDeOrden);
                            item.SubItems.Add(ordenesSeleccionada.CodigoCliente);
                            item.SubItems.Add(ordenesSeleccionada.Fecha.ToString());
                            item.SubItems.Add(ordenesSeleccionada.CodigoTransportista);
                            item.SubItems.Add(ordenesSeleccionada.EstadoOrden);

                            ListOrdenesSeleccionConfirmadas.Items.Add(item);
                        }
                    }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
