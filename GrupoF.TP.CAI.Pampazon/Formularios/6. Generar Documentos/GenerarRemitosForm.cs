using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoF.TP.CAI.Pampazon.Formularios._6._Generar_Documentos
{
    public partial class GenerarRemitosForm : Form
    {
        GenerarRemitosModel model;
        public GenerarRemitosForm()
        {
            InitializeComponent();
            model = new GenerarRemitosModel();
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

  

        private void GenerarRemitosForm_Load(object sender, EventArgs e)
        {
              if (model == null || model.OrdenesDeEntrega == null)
            {
                MessageBox.Show("El modelo o las órdenes seleccionadas no están inicializados.");
                return;
            }

            foreach (OrdenDePreparacion ordenesConfirmadas in model.OrdenesDeEntrega)
            {
                if (ordenesConfirmadas.EstadoOrden == "Confirmada")
                {
                    ListViewItem item = new ListViewItem(ordenesConfirmadas.NumeroDeOrden);
                    item.SubItems.Add(ordenesConfirmadas.CodigoCliente);
                    item.SubItems.Add(ordenesConfirmadas.Fecha.ToString());
                    item.SubItems.Add(ordenesConfirmadas.CodigoTransportista);
                    item.SubItems.Add(ordenesConfirmadas.EstadoOrden);

                    listOrdenesDeEntrega.Items.Add(item);
                }
            }
        }
    }
}
