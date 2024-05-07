using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using GrupoF.TP.CAI.Pampazon.Formularios;
using GrupoF.TP.CAI.Pampazon.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoF.TP.CAI.Pampazon
{
    public partial class BuscarClienteForm : Form
    {
        BuscarClienteModel model;
        public BuscarClienteForm()
        {
            InitializeComponent();
        }

        private void BuscarClienteForm_Load(object sender, EventArgs e)
        {
            model = new BuscarClienteModel();

            ClientesList.Items.Clear();

            foreach (var cliente in model.Clientes)
            {
                ListViewItem item = new ListViewItem();

                item.Text += cliente.CodigoCliente.ToString();
                item.SubItems.Add(cliente.RazonSocial.ToString());
                item.SubItems.Add(cliente.Cuit.ToString());
                item.SubItems.Add(cliente.Domicilio.ToString());

                ClientesList.Items.Add(item);

                item.Tag = cliente;
            }
        }

        private void SeleccionarBtn_Click(object sender, EventArgs e)
        {
            if (ClientesList.SelectedItems.Count > 0)
            {
                model.ClienteSeleccionado = (Clientes)ClientesList.SelectedItems[0].Tag;

                var generarOrdenDePreparacionForm = new GenerarOrdenDePreparacionForm(model);
                generarOrdenDePreparacionForm.model = model;
                generarOrdenDePreparacionForm.ShowDialog();
            }

        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Cuit_Box_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Cuit_Box.Text))
            {
                  return;
            }
            if (!Regex.IsMatch(Cuit_Box.Text, @"^\d{2}-\d{8}-\d{1}$"))
            {
                MessageBox.Show("Formato de CUIT inválido.");
                e.Cancel = false;
            }
        }
    }
}
