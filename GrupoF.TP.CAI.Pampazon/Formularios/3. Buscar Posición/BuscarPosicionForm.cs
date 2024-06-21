using GrupoF.TP.CAI.Pampazon.Formularios._2._Generar_Orden_de_Selección.Clases_auxiliares;
using GrupoF.TP.CAI.Pampazon.Formularios._3._Buscar_Posición.Clases_Auxiliares;
using GrupoF.TP.CAI.Pampazon.Formularios._4._Confirmar_Orden_Seleccionada;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoF.TP.CAI.Pampazon.Formularios._3._Buscar_Posición
{

    public partial class BuscarPosicionForm : Form
    {
        ConfirmarOrdenDeSeleccionModel model;
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
                model.OrdenDeSeleccionElegida = listOrdenesDeSeleccion.SelectedItems[0].Text;
                InventarioForm inventarioForm = new InventarioForm();
                inventarioForm.ShowDialog();
            }
        }


        private void cargarOrdenesDeSeleccion()

        {
            if (model.OrdenesSeleccionPendientes != null)

            {
                foreach (OrdenDeSeleccionPendiente ordenesSeleccion in model.OrdenesSeleccionPendientes)
                {
                    if (ordenesSeleccion.EstadoOrdenSeleccion == Entidades.EstadoSeleccionEnum.EstadoSeleccion.Pendiente)
                    {

                        {
                            ListViewItem item = new ListViewItem(ordenesSeleccion.IdOrdenDeSeleccion);
                            // string detallesUnidos = string.Join(" - ", ordenesSeleccionada.OrdenesSeleccionadas);

                            item.SubItems.Add(ordenesSeleccion.EstadoOrdenSeleccion.ToString());
                            listOrdenesDeSeleccion.Items.Add(item);
                            item.Tag = ordenesSeleccion;

                        }
                    }
                }
            }
        }

        private void BuscarPosicionForm_Load(object sender, EventArgs e)

        {
            model = new ConfirmarOrdenDeSeleccionModel();

            cargarOrdenesDeSeleccion();
        }
    }
}