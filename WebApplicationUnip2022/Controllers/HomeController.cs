using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationUnip2022.Models;

namespace WebApplicationUnip2022.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //instancia da pessoa
            PessoaModel pessoa = new PessoaModel();

            pessoa.Id = 123;
            pessoa.Nome = "Galeto Junior";
            pessoa.Cpf = 456712348910;
            pessoa.Endereco = "Rua Pelé Eterno";
            pessoa.Telefone = 11987451234;

            return View(pessoa);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
