using GrupoF.TP.CAI.Pampazon.Formularios._7._Confirmar_Orden_de_Entrega;
using GrupoF.TP.CAI.Pampazon.Formularios._7._Confirmar_Orden_de_Entrega.Clases_auxiliares;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoF.TP.CAI.Pampazon
{
    public partial class ConfirmarOrdenDeEntregaForm : Form
    {
        ConfirmarOrdenDeEntregaModel model;
        public ConfirmarOrdenDeEntregaForm()
        {
            InitializeComponent();
        }

        private void ConfirmarOrdenDeEntregaForm_Load(object sender, EventArgs e)
        {
            model = new ConfirmarOrdenDeEntregaModel();

            CargarOrdenesPreparadas();
        }

        private void CargarOrdenesPreparadas()
        {
            if (model.OrdenesDeEntregaAConfirmar != null)
            {
                foreach (OrdenDePreparacionPreparada ordenes in model.OrdenesDeEntregaAConfirmar)
                {
                    ListViewItem item = new ListViewItem(ordenes.NumeroDeOrden);
                    item.SubItems.Add(ordenes.CodigoCliente);
                    item.SubItems.Add(ordenes.Fecha.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(ordenes.CodigoTransportista);
                    item.SubItems.Add(((int)ordenes.Prioridad).ToString());
                    item.SubItems.Add(ordenes.EstadoOrden.ToString());

                    listOrdenesPreparadas.Items.Add(item);

                    item.Tag = ordenes;
                }
                
            }
        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            if (listOrdenesPreparadas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una orden.");
            }
            else
            {
                
                //Seguir por aca, esto esta pendiente.

                foreach (OrdenDePreparacionPreparada item in model.OrdenesDeEntregaAConfirmar)
                {
                    OrdenDePreparacionPreparada seleccionada = (OrdenDePreparacionPreparada)listOrdenesPreparadas.SelectedItems[0].Tag;
                    seleccionada.EstadoOrden =Entidades.Estados.Estado.Despachada;
                    
                   model.OrdenADespachada = seleccionada;
                  

                }

                OrdenDespachadaForm ordenDespachadaForm = new OrdenDespachadaForm();
                ordenDespachadaForm.model = model;
               
                ordenDespachadaForm.ShowDialog();
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SiguienteBtn_Click(object sender, EventArgs e)
        {
            OrdenDespachadaForm ordenDespachadaForm = new OrdenDespachadaForm();

            ordenDespachadaForm.ShowDialog();
        }
    }
}
