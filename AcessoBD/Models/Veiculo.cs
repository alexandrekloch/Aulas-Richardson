using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcessoBD.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public String Modelo { get; set; }
        public int Ano { get; set; }

        //Propiedades de Navegação
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
