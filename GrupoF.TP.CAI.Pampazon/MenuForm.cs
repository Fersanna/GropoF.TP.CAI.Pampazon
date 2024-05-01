namespace GropoF.TP.CAI.Pampazon
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
    }
}
