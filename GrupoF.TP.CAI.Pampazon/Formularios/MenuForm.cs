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

        private void OrdenSeleccionClick(object sender, EventArgs e)
        {
            OrdenDeSelec ordenDeSeleccion = new OrdenDeSelec();
            ordenDeSeleccion.ShowDialog();
        }

        private void OrdenEntrega_Click(object sender, EventArgs e)
        {
            OrdenDeEntregForm ordenDeEntrega = new OrdenDeEntregForm();
            ordenDeEntrega.ShowDialog();
        }

        private void GenerarDocBtn_Click(object sender, EventArgs e)
        {
            GenerarDocForm generarDocForm = new GenerarDocForm();
            generarDocForm.ShowDialog();
        }

        private void ConfirmarOrdeBtn_Click(object sender, EventArgs e)
        {
            ConfirmarOrdForm confirmarOrdForm = new ConfirmarOrdForm();
            confirmarOrdForm.ShowDialog();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
