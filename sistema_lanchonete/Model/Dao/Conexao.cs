using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sistema_lanchonete.Model.Dao
{
    internal class Conexao
    {
        const string servidor = "dbsistema.c7d6klkhyywg.us-east-1.rds.amazonaws.com";
        const string user = "root";
        const string senha = "root123456";
        const string porta = "3306";
        const string banco = "bd_sistema_lanchonete";
        public MySqlConnection AbrirConexao()
        {

            try
            {
                MySqlConnection con = new MySqlConnection($"Server={servidor};Database={banco};Uid={user};Pwd={senha};");
                con.Open();
                return con;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void FecharConexao(MySqlConnection con)
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public List<string> Procurar(string comando)
        {
            MySqlDataReader leitor;
            MySqlConnection con;
            MySqlCommand cmd;
            con = AbrirConexao();
            List<string> resp = new List<string>();
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = comando;
                leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    resp.Add(leitor.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FecharConexao(con);
            }
            return resp;
        }

        public void ExecSql(string comando)
        {
            MySqlConnection con;
            MySqlCommand cmd;
            try
            {
                con = AbrirConexao();
                cmd = con.CreateCommand();
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();
                this.FecharConexao(con);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
