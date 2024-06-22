using GrupoF.TP.CAI.Pampazon.Formularios._3._Buscar_Posición.Clases_Auxiliares;
using GrupoF.TP.CAI.Pampazon.Formularios._6._Generar_Documentos.Clases_Auxiliares_6;
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
                model.OrdenSeleccionada = (OrdenDeEntregaPendiente) listOrdenesDeEntrega.SelectedItems[0].Tag;
                RemitosForm remitosForm = new RemitosForm();
                remitosForm.model = this.model;
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

            foreach (OrdenDeEntregaPendiente ordenesConfirmadas in model.OrdenesDeEntrega)
            {
                if (ordenesConfirmadas.EstadoOrdenEntrega == Entidades.EstadoEntregaEnum.EstadoEntrega.Pendiente)
                {
                    ListViewItem item = new ListViewItem(ordenesConfirmadas.IdOrdenDeEntrega);
                    item.SubItems.Add(ordenesConfirmadas.CodigoCliente);
                    item.SubItems.Add(ordenesConfirmadas.Fecha.ToString());
                    item.SubItems.Add(ordenesConfirmadas.CodigoTransportista);
                    item.SubItems.Add(ordenesConfirmadas.EstadoOrdenEntrega.ToString());

                    listOrdenesDeEntrega.Items.Add(item);

                    item.Tag = ordenesConfirmadas;
                }
            }
        }
    }
}
