using GrupoF.TP.CAI.Pampazon.Formularios;
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
    public partial class BuscarClienteForm : Form
    {
        public BuscarClienteForm()
        {
            InitializeComponent();
        }

        private void BuscarClienteForm_Load(object sender, EventArgs e)
        {

        }

        private void SeleccionarBtn_Click(object sender, EventArgs e)
        {
            GenerarOrdenDePreparacionForm generarOrdenDePreparacionForm = new GenerarOrdenDePreparacionForm();
            generarOrdenDePreparacionForm.ShowDialog();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
