using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_AcessoBD_1toN.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public DateTime Nascimento { get; set; }

        public ICollection<Veiculo> Frota { get; set; }


    }
}
