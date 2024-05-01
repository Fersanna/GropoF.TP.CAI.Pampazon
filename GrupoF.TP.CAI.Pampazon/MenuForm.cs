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
            
        }

        private void OrdenEntrega_Click(object sender, EventArgs e)
        {

        }
    }
}
