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
        public DateTime FechaRemito { get; set; }
        public string NumeroDeRemito { get; set; }

        public string RazonSocialCliente { get; set; }

        public string DomicilioCliente { get; set; }

        public string CuitCliente { get; set; }

        public RemitosForm()
        {
            InitializeComponent();

        }




        private void ImprimirBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El remito se ha generado con éxito.");
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemitosForm_Load(object sender, EventArgs e)
        {
            RazonSocialTexBox.Text = model.OrdenSeleccionada.CodigoCliente;
           
        }
    }
}
