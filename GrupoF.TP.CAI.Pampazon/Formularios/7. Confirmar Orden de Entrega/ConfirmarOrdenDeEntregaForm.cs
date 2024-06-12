using GrupoF.TP.CAI.Pampazon.Clases_Auxiliares;
using GrupoF.TP.CAI.Pampazon.Formularios._7._Confirmar_Orden_de_Entrega;
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
            model =new ConfirmarOrdenDeEntregaModel();
             
             foreach (OrdenDePreparacion orden in model.OrdenesDeEntregaAConfirmar)
                {
                    ListViewItem item = new ListViewItem(orden.NumeroDeOrden);
                    item.SubItems.Add(orden.CodigoCliente);
                    item.SubItems.Add(orden.Fecha.ToString());
                    item.SubItems.Add(orden.CodigoTransportista);
                    item.SubItems.Add(orden.EstadoOrden.ToString());

                    listOrdenesPreparadas.Items.Add(item);

                    item.Tag = orden;
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

                foreach (OrdenDePreparacion item in model.OrdenesDeEntregaAConfirmar)
                {
                    OrdenDePreparacion seleccionada = (OrdenDePreparacion)listOrdenesPreparadas.SelectedItems[0].Tag;
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
