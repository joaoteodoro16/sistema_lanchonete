using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistema_lanchonete.Model;
using System.Data;
using sistema_lanchonete.Util;

namespace sistema_lanchonete.Model.Dao
{
    internal class ClientesDao
    {
        private Cliente cliente;
        Conexao con = new Conexao();

        public ClientesDao(Cliente cliente)
        {
            this.cliente = cliente;
        }

        public void RegisterCli()
        {
            string ssql = "";
            try
            { 
                if(cliente == null)
                {
                    throw new Exception("Dados invalidos!");
                }
                VerificarTab();
                if (VerificarExiste())
                {
                    ssql = $"UPDATE TB_CLIENTES SET CLI_NOME = '{cliente.nome}'," +
                        $"CLI_DATA_NASCIMENTO = '{cliente.data_nascimento}'," +
                        $"CLI_CPF = '{cliente.cpf}'," +
                        $"CLI_RG = '{cliente.rg}'," +
                        $"CLI_SEXO = '{cliente.sexo}'," +
                        $"CLI_CIDADE = '{cliente.cidade}'," +
                        $"CLI_ESTADO = '{cliente.estado}'," +
                        $"CLI_BAIRRO = '{cliente.bairro}'," +
                        $"CLI_LOGRADOURO = '{cliente.logradouro}'," +
                        $"CLI_NUMERO = '{cliente.numero_casa}'," +
                        $"CLI_EMAIL = '{cliente.email}'," +
                        $"CLI_CELULAR = '{cliente.celular}'," +
                        $"CLI_CEP = '{cliente.cep}'" +
                        $"WHERE CLI_ID = {cliente.codigo}'";
                }
                else
                {
                    ssql = "INSERT INTO TB_CLIENTES(" +
                        "CLI_NOME," +
                        "CLI_DATA_NASCIMENTO," +
                        "CLI_CPF," +
                        "CLI_RG," +
                        "CLI_SEXO," +
                        "CLI_CIDADE," +
                        "CLI_ESTADO," +
                        "CLI_BAIRRO," +
                        "CLI_LOGRADOURO," +
                        "CLI_NUMERO," +
                        "CLI_EMAIL," +
                        "CLI_CELULAR," +
                        $"CLI_CEP) VALUES ('{this.cliente.nome}'," +
                        $"'{cliente.data_nascimento}'," +
                        $"'{this.cliente.cpf}'," +
                        $"'{this.cliente.rg}'," +
                        $"'{this.cliente.sexo}'," +
                        $"'{this.cliente.cidade}'," +
                        $"'{this.cliente.estado}'," +
                        $"'{this.cliente.bairro}'," +
                        $"'{this.cliente.logradouro}'," +
                        $"'{this.cliente.numero_casa}'," +
                        $"'{this.cliente.email}'," +
                        $"'{this.cliente.celular}'," +
                        $"'{this.cliente.cep}')";
                }
                con.ExecSql(ssql);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar o cliente - {ex.Message}");
            }
        }

        private void VerificarTab()
        {
            DataTable da;
            try
            {
                da = con.Consulta("SHOW TABLES LIKE 'TB_CLIENTES'");
                if(da.Rows.Count == 0)
                {
                    con.ExecSql("CREATE TABLE TB_CLIENTES(" +
                        "CLI_ID INT AUTO_INCREMENT PRIMARY KEY," +
                        "CLI_NOME VARCHAR(60) NOT NULL," +
                        "CLI_DATA_NASCIMENTO DATE NOT NULL," +
                        "CLI_CPF VARCHAR(14) NOT NULL," +
                        "CLI_RG VARCHAR(12)," +
                        "CLI_SEXO CHAR(1)," +
                        "CLI_CIDADE VARCHAR(60)," +
                        "CLI_ESTADO CHAR(2)," +
                        "CLI_BAIRRO VARCHAR(100)," +
                        "CLI_LOGRADOURO VARCHAR(100)," +
                        "CLI_NUMERO INT," +
                        "CLI_EMAIL VARCHAR(60)," +
                        "CLI_CELULAR VARCHAR(15)," +
                        "CLI_CEP VARCHAR(11))");
                }
                else
                {
                    //da = con.Consulta("SHOW COLUMNS FROM TAB_CLIENTES");
                    //if (da.Rows.Contains(""))
                    //{

                    //}
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool VerificarExiste()
        {
            string ssql = "";
            DataTable da;
            ssql = $"SELECT * FROM TB_CLIENTES WHERE CLI_ID = '{this.cliente.codigo}'";
            da = con.Consulta(ssql);
            if(da.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }


    }
}
