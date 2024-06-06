using GrupoF.TP.CAI.Pampazon.Formularios._1._Registrar_Orden_de_Preparación;
using GrupoF.TP.CAI.Pampazon.Formularios._3._Buscar_Posición;
using GrupoF.TP.CAI.Pampazon.Formularios._4._Confirmar_Orden_Seleccionada;
using GrupoF.TP.CAI.Pampazon.Formularios._6._Generar_Documentos;
using System.Configuration;

namespace GrupoF.TP.CAI.Pampazon
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void RegistrarOrdenDePreparacion_Click(object sender, EventArgs e)
        {
            BuscarClienteForm buscarClienteForm = new BuscarClienteForm();
             
            buscarClienteForm.ShowDialog();
        }

        private void GenerarOrdenDeSeleccionBtn_Click(object sender, EventArgs e)
        {
            GenerarOrdenDeSeleccionForm generarOrdenDeSeleccionForm = new GenerarOrdenDeSeleccionForm();
            generarOrdenDeSeleccionForm.ShowDialog();
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
            GenerarOrdenDeEntregaForm generarOrdenDeEntregaForm = new GenerarOrdenDeEntregaForm();
            generarOrdenDeEntregaForm.ShowDialog();
        }

        private void GenerarDocumentosBtn_Click(object sender, EventArgs e)
        {
            GenerarRemitosForm generarRemitosForm = new GenerarRemitosForm();
            generarRemitosForm.ShowDialog();
        }

        private void ConfirmarOrdenDeEntregaBtn_Click(object sender, EventArgs e)
        {
            ConfirmarOrdenDeEntregaForm confirmarOrdenDeEntregaForm = new ConfirmarOrdenDeEntregaForm();
            confirmarOrdenDeEntregaForm.ShowDialog();
        }
    }
}
