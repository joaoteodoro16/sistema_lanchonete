using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace sistema_lanchonete.Model.Dao
{
    internal class Conexao
    {
        const string servidor = "dbsistema.c7d6klkhyywg.us-east-1.rds.amazonaws.com";
        const string user = "root";
        const string senha = "root123456";
        const string porta = "3306";
        const string banco = "bd_sistema_lanchonete";
        MySqlConnection con;
        public void AbrirConexao()
        {
            try
            {
                con = new MySqlConnection($"Server={servidor};Database={banco};Uid={user};Pwd={senha};");
                con.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            MySqlCommand cmd;
            AbrirConexao();
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
            MySqlCommand cmd;
            try
            {
                AbrirConexao();
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

        public DataTable Consulta(string consulta)
        {
            DataTable dt = new DataTable();
            try
            {
                if(consulta == String.Empty)
                {
                    throw new Exception("Consulta invalida!");
                }
                AbrirConexao();
                MySqlCommand cmd = new MySqlCommand(consulta, con);
                dt.Load(cmd.ExecuteReader());
            }catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            return dt;
        }
    }
}
