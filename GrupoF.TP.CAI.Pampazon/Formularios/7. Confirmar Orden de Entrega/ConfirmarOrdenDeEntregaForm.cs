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
        public ConfirmarOrdenDeEntregaForm()
        {
            InitializeComponent();
        }

        private void ConfirmarOrdenDeEntregaForm_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            if (listOrdenesPreparadas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una orden.");
            }
            else
            {
                OrdenDespachadaForm ordenDespachadaForm = new OrdenDespachadaForm();
                ordenDespachadaForm.ShowDialog();
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
