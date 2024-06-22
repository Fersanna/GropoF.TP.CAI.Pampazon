using GrupoF.TP.CAI.Pampazon.Formularios._7._Confirmar_Orden_de_Entrega.Clases_auxiliares;
using GrupoF.TP.CAI.Pampazon.Formularios._7._Confirmar_Orden_de_Entrega.Clases_Auxiliares_7;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoF.TP.CAI.Pampazon.Formularios._7._Confirmar_Orden_de_Entrega
{
    public partial class OrdenDespachadaForm : Form
    {
        public ConfirmarOrdenDeEntregaModel model { get; set; }
        public OrdenDespachadaForm()
        {
            InitializeComponent();
        }

            

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrdenDespachadaForm_Load(object sender, EventArgs e)
        {
            
            CargarOrdenesDespachadas();

            if (model != null && model.OrdenADespachada != null)
            {
                ListViewItem item = new ListViewItem(model.OrdenADespachada.NumeroDeOrden);
                item.SubItems.Add(model.OrdenADespachada.CodigoCliente);
                item.SubItems.Add(model.OrdenADespachada.Fecha.ToString("dd/MM/yyyy"));
                item.SubItems.Add(model.OrdenADespachada.CodigoTransportista);
                item.SubItems.Add(((int)model.OrdenADespachada.Prioridad).ToString());
                item.SubItems.Add(model.OrdenADespachada.EstadoOrden.ToString());

                listOrdenesDespachadas.Items.Add(item);

                item.Tag = model.OrdenADespachada;
            }

        }

        private void CargarOrdenesDespachadas()
        {
            if (model.OrdenesDeEntregaAEntregar != null)
            {
                foreach (OrdenDePreparacionDespachada ordenes in model.OrdenesDeEntregaAEntregar)
                {
                    ListViewItem item = new ListViewItem(ordenes.NumeroDeOrden);
                    item.SubItems.Add(ordenes.CodigoCliente);
                    item.SubItems.Add(ordenes.Fecha.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(ordenes.CodigoTransportista);
                    item.SubItems.Add(((int)ordenes.Prioridad).ToString());
                    item.SubItems.Add(ordenes.EstadoOrden.ToString());

                    listOrdenesDespachadas.Items.Add(item);

                    item.Tag = ordenes;
                }

            }
        }

    }
}
