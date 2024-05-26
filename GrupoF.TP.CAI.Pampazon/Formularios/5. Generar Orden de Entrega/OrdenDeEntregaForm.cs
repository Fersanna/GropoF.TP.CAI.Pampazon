using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoF.TP.CAI.Pampazon.Formularios._5._Generar_Orden_de_Entrega
{
    public partial class OrdenDeEntregaForm : Form
    {
        public OrdenDeEntregaModel model { get; set; }
        public OrdenDeEntregaForm()
        {
            InitializeComponent();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerarBtn_Click(object sender, EventArgs e)
        {
            var ordenesConfirmadas = model.OrdenesSeleccionadas.Where(o => o.EstadoOrden == "Confirmada").ToList();

            if (ordenesConfirmadas.Any() == true)
            {
                var dialogResult = MessageBox.Show("¿Confirma las órdenes seleccionadas?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    model.OrdenesSeleccionadas = ordenesConfirmadas;
                    MessageBox.Show("Órdenes seleccionadas y confirmadas.");


                    this.Close();

                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    MessageBox.Show("Operación cancelada.");
                }

            }
            else
            {
                MessageBox.Show("No hay ordenes seleccionadas para confirmar.");
            }
        }

        private void OrdenDeEntregaForm_Load(object sender, EventArgs e)
        {
            if (model == null || model.OrdenesSeleccionadas == null)
            {
                MessageBox.Show("El modelo o las órdenes seleccionadas no están inicializados.");
                return;
            }

            foreach (OrdenDePreparacion ordenesConfirmadas in model.OrdenesSeleccionadas)
            {
                if (ordenesConfirmadas.EstadoOrden == "Confirmada")
                {
                    ListViewItem item = new ListViewItem(ordenesConfirmadas.NumeroDeOrden);
                    item.SubItems.Add(ordenesConfirmadas.CodigoCliente);
                    item.SubItems.Add(ordenesConfirmadas.Fecha.ToString());
                    item.SubItems.Add(ordenesConfirmadas.CodigoTransportista);
                    item.SubItems.Add(ordenesConfirmadas.EstadoOrden);

                    listOrdenesSeleccionadasConfirmadas.Items.Add(item);
                }
            }
        }
    }
}
