using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_lanchonete.Model
{
    internal class Funcionario : Pessoa
    {
        public DateOnly data_admissao { get; set; }
        public string profissao { get; set; }
        public string nivel_acesso { get; set; }
        public string salario { get; set; }
        public string senha { get; set; }
        public string usuario { get; set; }
        public string estado_civil { get; set; }
        public string escolaridade { get; set; }
        public string pis_pasep { get; set; }
        public string ctps { get; set; }
        public string serie { get; set; }
        public string emissao { get; set; }
        public string banco { get; set; }
        public string agencia { get; set; }
        public string conta { get; set; }
        public string tipo_conta { get; set; }
        public DateOnly data_demissao { get; set; }
        public string horario { get; set; }
        public string observacao { get; set; }
    }
}
