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

        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            if (listOrdenesEntrega.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una o varias ordenes.");
            }
            else
            {
                OrdenDeEntregaForm ordenDeEntregaForm = new OrdenDeEntregaForm();
                ordenDeEntregaForm.ShowDialog();
            }
        }
    }
}
