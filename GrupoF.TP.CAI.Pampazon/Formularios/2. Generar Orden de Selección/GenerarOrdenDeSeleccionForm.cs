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

namespace GrupoF.TP.CAI.Pampazon
{
    public partial class GenerarOrdenDeSeleccionForm : Form
    {
        public GenerarOrdenDeSeleccionForm()
        {
            InitializeComponent();
        }

        private void GenerarBtn_Click(object sender, EventArgs e)
        {
            OrdenDeSeleccionForm ordenDeSeleccionForm = new OrdenDeSeleccionForm();
            ordenDeSeleccionForm.ShowDialog();
        }

        private void GenerarOrdenDeSeleccionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
