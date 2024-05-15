using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoF.TP.CAI.Pampazon.Formularios._5._Generar_Orden_de_Entrega
{
    public partial class OrdenDeEntregaForm : Form
    {
        public OrdenDeEntregaForm()
        {
            InitializeComponent();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerarBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La orden de entrega ha sido generada.");
        }
    }
}
