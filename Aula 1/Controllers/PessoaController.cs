using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_1.Models;

namespace Aula_1.Controllers
{
    public class PessoaController : Controller
    {
        // GET: PessoaController
        public ActionResult Navegacao()
        {
            return View();
        }

        // GET: PessoaController
        public ActionResult Visualizar()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Id = 1;
            pessoa.Nome = "Richardson";
            pessoa.Idade = 46;

            //pessoa = bd.Pessoas.select....



            return View(pessoa);
        }
    }
}
