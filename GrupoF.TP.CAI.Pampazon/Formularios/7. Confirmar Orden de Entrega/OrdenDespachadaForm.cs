using GrupoF.TP.CAI.Pampazon.Formularios._2._Generar_Orden_de_Selección.Clases_auxiliares;
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
            /*
            foreach (OrdenDePreparacionPreparada ordenesSeleccionada in model.OrdenADespachada)
            {
                if (ordenesSeleccionada.EstadoOrden == Entidades.EstadoPreparacion.Seleccion)
                {
                    ListViewItem item = new ListViewItem(ordenesSeleccionada.NumeroDeOrden);
                    item.SubItems.Add(ordenesSeleccionada.CodigoCliente);
                    item.SubItems.Add(ordenesSeleccionada.Fecha.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(ordenesSeleccionada.CodigoTransportista);
                    item.SubItems.Add(((int)ordenesSeleccionada.Prioridad).ToString());
                    item.SubItems.Add(ordenesSeleccionada.EstadoOrden.ToString());

                    listOrdenesDespachadas.Items.Add(item);
                }
            }
            */
        }

        private void CargarOrdenesDespachadas()
        {
            // Limpiar la lista antes de cargar los datos para evitar duplicados
            listOrdenesDespachadas.Items.Clear();

            if (model.OrdenADespachada != null)
            {
                foreach (OrdenDePreparacionPreparada orden in model.OrdenADespachada)
                {
                    ListViewItem item = new ListViewItem(orden.NumeroDeOrden);
                    item.SubItems.Add(orden.CodigoCliente);
                    item.SubItems.Add(orden.Fecha.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(orden.CodigoTransportista);
                    item.SubItems.Add(((int)orden.Prioridad).ToString());
                    item.SubItems.Add(orden.EstadoOrden.ToString());

                    listOrdenesDespachadas.Items.Add(item);
                }
            }

            if (model.OrdenesDeEntregaAEntregar != null)
            {
                foreach (OrdenDePreparacionDespachada orden in model.OrdenesDeEntregaAEntregar)
                {
                    ListViewItem item = new ListViewItem(orden.NumeroDeOrden);
                    item.SubItems.Add(orden.CodigoCliente);
                    item.SubItems.Add(orden.Fecha.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(orden.CodigoTransportista);
                    item.SubItems.Add(((int)orden.Prioridad).ToString());
                    item.SubItems.Add(orden.EstadoOrden.ToString());

                    listOrdenesDespachadas.Items.Add(item);
                }
            }
        }

    }
}
