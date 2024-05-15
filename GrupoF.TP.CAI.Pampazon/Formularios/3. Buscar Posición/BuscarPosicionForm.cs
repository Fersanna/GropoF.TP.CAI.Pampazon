using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoF.TP.CAI.Pampazon.Formularios._3._Buscar_Posición
{
    public partial class BuscarPosicionForm : Form
    {
        public BuscarPosicionForm()
        {
            InitializeComponent();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultarBtn_Click(object sender, EventArgs e)
        {

            if (listOrdenesDeSeleccion.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una orden.");
            }
            else
            {
                InventarioForm inventarioForm = new InventarioForm();
                inventarioForm.ShowDialog();
            }
            
        }
    }
}
