using sistema_lanchonete.View;
using sistema_lanchonete.Model.Dao;
using System.Data;

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