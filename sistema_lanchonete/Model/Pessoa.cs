using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_lanchonete.Model
{
    internal class Pessoa
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public DateOnly data_nascimento { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string sexo { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string bairro { get; set; }
        public string logradouro { get; set; }
        public string numero_casa {get;set;}
        public string email { get; set; }    
        public string celular { get; set;}
        public string cep { get; set; }
    }
}
