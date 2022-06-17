using sistema_lanchonete.View;
using sistema_lanchonete.Model.Dao;
using System.Data;
using sistema_lanchonete.Model;

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
            Teste();
            FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
            this.Hide();
            frmMenuPrincipal.ShowDialog();
            
        }

        public void Teste()
        {
            Cliente cli = new Cliente();
            ClientesDao dao = new ClientesDao(cli);
            cli.nome = "Joao pedro";
            cli.cpf = "489.013.608-88";
            cli.data_nascimento = DateOnly.Parse("10/09/2001");
            dao.RegisterCli();
            

        }
    }
}