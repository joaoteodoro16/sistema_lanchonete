using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_lanchonete.Model
{
    internal class Pessoa
    {
        public int codigo { get; set; } = default;
        public string nome { get; set; } = default;
        public DateOnly data_nascimento { get; set; } = default;
        public string cpf { get; set; } = default;
        public string rg { get; set; } = default;
        public string sexo { get; set; } = default;
        public string cidade { get; set; } = default;
        public string estado { get; set; } = default;
        public string bairro { get; set; } = default;
        public string logradouro { get; set; } = default;
        public string numero_casa {get;set; } = default;
        public string email { get; set; } = default;
        public string celular { get; set; } = default;
        public string cep { get; set; } = default;
    }
}
