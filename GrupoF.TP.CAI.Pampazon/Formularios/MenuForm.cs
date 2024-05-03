using GrupoF.TP.CAI.Pampazon.Formularios._3._Buscar_Posici�n;
using GrupoF.TP.CAI.Pampazon.Formularios._4._Confirmar_Orden_Seleccionada;
using System.Configuration;

namespace GrupoF.TP.CAI.Pampazon
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void OrdenPreparacionClick(object sender, EventArgs e)
        {
            OrdenDePrepForm ordenDePrepForm = new OrdenDePrepForm();
            ordenDePrepForm.ShowDialog();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void GenerarOrdenDeSeleccionBtn_Click(object sender, EventArgs e)
        {
            GenerarOrdenDeSeleccionForm generarOrdenDeSeleccion = new GenerarOrdenDeSeleccionForm();
            generarOrdenDeSeleccion.ShowDialog();
        }

        private void BuscarPosicionBtn_Click(object sender, EventArgs e)
        {
            BuscarPosicionForm buscarPosicionForm = new BuscarPosicionForm();
            buscarPosicionForm.ShowDialog();
        }

        private void ConfirmarOrdenSeleccionadaBtn_Click(object sender, EventArgs e)
        {
            ConfirmarOrdenSeleccionadaForm confirmarOrdenSeleccionadaForm = new ConfirmarOrdenSeleccionadaForm();
            confirmarOrdenSeleccionadaForm.ShowDialog();
        }

        private void GenerarOrdenDeEntregaBtn_Click(object sender, EventArgs e)
        {
            GenerarOrdenDeEntregaForm generarOrdenDeEntrega = new GenerarOrdenDeEntregaForm();
            generarOrdenDeEntrega.ShowDialog();
        }

        private void GenerarDocumentosBtn_Click(object sender, EventArgs e)
        {
            GenerarDocumentosForm generarDocumentosForm = new GenerarDocumentosForm();
            generarDocumentosForm.ShowDialog();
        }

        private void ConfirmarOrdenDeEntregaBtn_Click(object sender, EventArgs e)
        {
            ConfirmarOrdenDeEntregaForm confirmarOrdenDeEntregaForm = new ConfirmarOrdenDeEntregaForm();
            confirmarOrdenDeEntregaForm.ShowDialog();
        }


    }
}
