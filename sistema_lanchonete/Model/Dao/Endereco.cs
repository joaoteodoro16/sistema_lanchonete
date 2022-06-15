using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_lanchonete.Model.Dao
{
    internal class Endereco
    {
        public string rua { get; set; }
        public string bairro { get; set; }
        public int numero { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }

    }
}
