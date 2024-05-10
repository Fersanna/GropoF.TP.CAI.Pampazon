using GrupoF.TP.CAI.Pampazon.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoF.TP.CAI.Pampazon.Formularios._1._Registrar_Orden_de_Preparación
{
    public partial class OrdenDePreparacionForm : Form
    {
        public OrdenDePreparacionForm()
        {
            InitializeComponent();
        }

        public BuscarClienteModel model { get; internal set; }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrdenDePreparacionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
