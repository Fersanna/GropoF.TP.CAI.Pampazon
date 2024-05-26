using GrupoF.TP.CAI.Pampazon.Formularios._1._Registrar_Orden_de_Preparación.Clases_Auxiliares;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoF.TP.CAI.Pampazon.Formularios._6._Generar_Documentos
{
    public partial class RemitosForm : Form
    {
        public GenerarRemitosModel model { get; set; }

        public Remito remitos {get; set;} 
        public RemitosForm()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ImprimirBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El remito se ha generado con éxito.");
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
