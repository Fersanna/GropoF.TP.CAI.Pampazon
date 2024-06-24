using GrupoF.TP.CAI.Pampazon.Formularios._5._Generar_Orden_de_Entrega.Clases_Auxiliares;
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
            var ordenesPreparadas = model.OrdenesPreparadas.Where(o => o.EstadoOrden == Entidades.EstadoPreparacion.Preparada).ToList();

            if (ordenesPreparadas.Any() == true)
            {
                var dialogResult = MessageBox.Show("¿Desea generar una orden de entrega con las ordenes elegidas?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    model.RegistrarOrden(ordenesPreparadas);

                    MessageBox.Show("La orden de entrega fue generada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
            if (model == null || model.OrdenesPreparadas == null)
            {
                MessageBox.Show("El modelo o las órdenes seleccionadas no están inicializados.");
                return;
            }

            foreach (OrdenDePreparacionSeleccionada ordenesConfirmadas in model.OrdenesPreparadas)
            {
                if (ordenesConfirmadas.EstadoOrden == Entidades.EstadoPreparacion.Preparada)
                {
                    ListViewItem item = new ListViewItem(ordenesConfirmadas.NumeroDeOrden);
                    item.SubItems.Add(ordenesConfirmadas.CodigoCliente);
                    item.SubItems.Add(ordenesConfirmadas.Fecha.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(ordenesConfirmadas.CodigoTransportista);
                    item.SubItems.Add(((int)ordenesConfirmadas.Prioridad).ToString());
                    item.SubItems.Add(ordenesConfirmadas.EstadoOrden.ToString());

                    listOrdenesSeleccionadasConfirmadas.Items.Add(item);
                }
            }
        }
    }
}
