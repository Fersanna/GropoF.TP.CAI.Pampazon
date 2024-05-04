using GrupoF.TP.CAI.Pampazon.Formularios._1._Registrar_Orden_de_Preparación;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoF.TP.CAI.Pampazon.Formularios
{
    public partial class GenerarOrdenDePreparacionForm : Form
    {
        public GenerarOrdenDePreparacionForm()
        {
            InitializeComponent();
        }

        private void GenerarOrdenDePreparacionForm_Load(object sender, EventArgs e)
        {

        }

        private void GenerarBtn_Click(object sender, EventArgs e)
        {
            OrdenDePreparacionForm ordenDePreparacionForm = new OrdenDePreparacionForm();
            ordenDePreparacionForm.ShowDialog();
        }
    }
}
