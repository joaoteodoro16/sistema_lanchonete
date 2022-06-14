using sistema_lanchonete.View;

namespace sistema_lanchonete
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
            this.Hide();
            frmMenuPrincipal.ShowDialog();
            
        }
    }
}