using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
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
            var ordenesSeleccionadas = model.OrdenDePreparacion.Where(o => o.EstadoOrden == Entidades.Estados.Estado.Seleccion).ToList();

            if (ordenesSeleccionadas.Any())
            {
                var dialogResult = MessageBox.Show("¿Confirma las órdenes seleccionadas?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    model.OrdenesConfirmadas = ordenesSeleccionadas;
                    model.RegistrarOrden(model.OrdenesConfirmadas);
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



        private void OrdenDeSeleccionForm_Load(object sender, EventArgs e)
        {
            foreach (OrdenDeSeleccion ordenesSeleccionada in model.OrdenDePreparacion)
            {
                if (ordenesSeleccionada.EstadoOrden == Entidades.Estados.Estado.Seleccion)
                {
                    ListViewItem item = new ListViewItem(ordenesSeleccionada.NumeroDeOrden);
                    item.SubItems.Add(ordenesSeleccionada.CodigoCliente);
                    item.SubItems.Add(ordenesSeleccionada.Fecha.ToString());
                    item.SubItems.Add(ordenesSeleccionada.CodigoTransportista);
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
