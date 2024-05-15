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
        public OrdenDeSeleccionForm()
        {
            InitializeComponent();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerarBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La orden de selección ha sido generada.");
        }
    }
}
