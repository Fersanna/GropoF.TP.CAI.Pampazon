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
    public partial class OrdenDePrepForm : Form
    {
        public OrdenDePrepForm()
        {
            InitializeComponent();
        }

        private void OrdenDePrepForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelarOrdenPrepBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SeleccionarBtn_Click(object sender, EventArgs e)
        {
            GenerarOrdenPrepForm generarOrdenPrep = new GenerarOrdenPrepForm();
            generarOrdenPrep.ShowDialog();
        }
    }
}
