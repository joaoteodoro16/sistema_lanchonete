using sistema_lanchonete.Model.Dao;
using MySql.Data.MySqlClient;
namespace sistema_lanchonete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexao con = new Conexao();
            List<string> lista = new List<string>();
            
            if(con.AbrirConexao().State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Conexao aberta");
                lista = con.Procurar("Select nome from Teste");
                foreach(string item in lista)
                {
                    MessageBox.Show(item);
                }
            }
            else
            {
                MessageBox.Show("Conexao fechada");
            }

        }
    }
}