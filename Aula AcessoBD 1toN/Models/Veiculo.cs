using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_AcessoBD_1toN.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public String Modelo { get; set; }
        public int Ano { get; set; }

        public int ProprietarioId { get; set; }
        public Pessoa Proprietario { get; set; }


    }
}
