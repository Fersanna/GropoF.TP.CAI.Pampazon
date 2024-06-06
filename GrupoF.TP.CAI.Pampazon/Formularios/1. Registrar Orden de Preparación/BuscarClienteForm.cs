using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using GrupoF.TP.CAI.Pampazon.Formularios;
using GrupoF.TP.CAI.Pampazon.Formularios._5._Generar_Orden_de_Entrega;
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
                generarOrdenDePreparacionForm.ClientesForm =this;
                generarOrdenDePreparacionForm.model = model;               
                generarOrdenDePreparacionForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente");
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
                MessageBox.Show("Debe ingresar un numero de CUIT");
                e.Cancel = true;
                return;
            }
            if (!Regex.IsMatch(Cuit_Box.Text, @"^\d{2}-\d{8}-\d{1}$"))
            {
                MessageBox.Show("Formato de CUIT inválido.");
                e.Cancel = false;
                return;
            }

            e.Cancel = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClientesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {

          

            if (string.IsNullOrWhiteSpace(Cuit_Box.Text))
            {
                MessageBox.Show("Debe ingresar un número de CUIT");
                return;
            }

            
              model.Cuit = Cuit_Box.Text;

            var clienteBuscado = model.Clientes.FirstOrDefault(p => p.Cuit == model.Cuit);

            

            if (clienteBuscado == null)
            {
                MessageBox.Show("El cliente no ha sido encontrado");
                return;
            }

            ClientesList.Items.Clear();

            ListViewItem item = new ListViewItem();

            item.Text += clienteBuscado.CodigoCliente.ToString();
            item.SubItems.Add(clienteBuscado.RazonSocial.ToString());
            item.SubItems.Add(clienteBuscado.Cuit.ToString());
            item.SubItems.Add(clienteBuscado.Domicilio.ToString());

            ClientesList.Items.Add(item);

            item.Tag = clienteBuscado;


        }

        internal void CerrarClientes()
        {
          this.Close();
        }
    }
}
