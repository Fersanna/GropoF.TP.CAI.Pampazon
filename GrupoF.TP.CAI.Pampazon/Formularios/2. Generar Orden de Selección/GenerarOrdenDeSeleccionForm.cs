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
                OrdenDeSeleccionForm ordenDeSeleccionForm = new OrdenDeSeleccionForm();
                ordenDeSeleccionForm.ShowDialog();
            }
        }
    }
}