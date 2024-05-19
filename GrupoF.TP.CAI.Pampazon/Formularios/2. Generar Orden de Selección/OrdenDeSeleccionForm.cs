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
        public OrdenDeSeleccionModel model {get; set; } 
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
            listOrdenesPendientesConfirmadas.Items.AddRange(items.ToArray());
        }

        private void OrdenDeSeleccionForm_Load(object sender, EventArgs e)
        {
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
