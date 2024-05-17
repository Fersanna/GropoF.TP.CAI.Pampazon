using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoF.TP.CAI.Pampazon.Formularios._6._Generar_Documentos
{
    public partial class GenerarRemitosForm : Form
    {
        public GenerarRemitosForm()
        {
            InitializeComponent();
        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            if (listOrdenesDeEntrega.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una orden.");
            }
            else
            {
                RemitosForm remitosForm = new RemitosForm();
                remitosForm.ShowDialog();
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarDatosDePrueba()
        {
            ListViewItem item1 = new ListViewItem("E-000001");
            item1.SubItems.Add("001");
            item1.SubItems.Add("13/05/24");
            item1.SubItems.Add("Transportista 1");
            item1.SubItems.Add("00001-00000001");

            // Agregar elementos al ListView
            listOrdenesDeEntrega.Items.Add(item1);
        }

        private void GenerarRemitosForm_Load(object sender, EventArgs e)
        {
            AgregarDatosDePrueba();
        }
    }
}
