using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationUnip2022.Controllers
{
    public class TelefoneController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CriarTelefone()
        {
            return View();
        }

        public IActionResult EditarTelefone()
        {
            return View();
        }
        public IActionResult DeletarTelefone()
        {
            return View();
        }
    }
}
