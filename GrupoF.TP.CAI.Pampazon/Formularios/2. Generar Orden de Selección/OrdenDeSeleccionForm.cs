using GrupoF.TP.CAI.Pampazon.Formularios._2._Generar_Orden_de_Selección.Clases_auxiliares;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoF.TP.CAI.Pampazon.Formularios._2._Generar_Orden_de_Selección
{
    public partial class OrdenDeSeleccionForm : Form
    {

        public OrdenDeSeleccionModel model { get; set; }
        public OrdenDeSeleccionForm()
        {
            InitializeComponent();
        }




        private void GenerarBtn_Click(object sender, EventArgs e)
        {
            var ordenesSeleccionadas = model.OrdenDePreparacionSeleccionadas.Where(o => o.EstadoOrden == Entidades.EstadoPreparacion.Seleccion).ToList();

            if (ordenesSeleccionadas.Any())
            {
                var dialogResult = MessageBox.Show("¿Desea generar una orden de selección con las ordenes elegidas?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    model.RegistrarOrden(ordenesSeleccionadas);
                    ListOrdenesSeleccionConfirmadas.Items.Clear();
                    MessageBox.Show("La orden de selección fue generada con éxito..", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No hay órdenes seleccionadas para confirmar.");
            }


        }



        private void OrdenDeSeleccionForm_Load(object sender, EventArgs e)
        {
            ListOrdenesSeleccionConfirmadas.Items.Clear();

            foreach (OrdenDePreparacionPendiente ordenesSeleccionada in model.OrdenDePreparacionSeleccionadas)
            {
                if (ordenesSeleccionada.EstadoOrden == Entidades.EstadoPreparacion.Seleccion)
                {
                    ListViewItem item = new ListViewItem(ordenesSeleccionada.NumeroDeOrden);
                    item.SubItems.Add(ordenesSeleccionada.CodigoCliente);
                    item.SubItems.Add(ordenesSeleccionada.Fecha.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(ordenesSeleccionada.CodigoTransportista);
                    item.SubItems.Add(((int)ordenesSeleccionada.Prioridad).ToString());
                    item.SubItems.Add(ordenesSeleccionada.EstadoOrden.ToString());

                    ListOrdenesSeleccionConfirmadas.Items.Add(item);
                }
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
