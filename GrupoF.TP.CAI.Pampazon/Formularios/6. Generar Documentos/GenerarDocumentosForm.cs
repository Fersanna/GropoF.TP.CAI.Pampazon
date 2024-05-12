using GrupoF.TP.CAI.Pampazon.Formularios._6._Generar_Documentos;
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
    public partial class GenerarDocumentosForm : Form
    {
        public GenerarDocumentosForm()
        {
            InitializeComponent();
        }

        private void GenerarDocumentosForm_Load(object sender, EventArgs e)
        {

        }

        private void GenerarBtn_Click(object sender, EventArgs e)
        {
            RemitosForm remitosForm = new RemitosForm();
            remitosForm.ShowDialog();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
