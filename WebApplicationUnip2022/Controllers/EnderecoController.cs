﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationUnip2022.Controllers
{
    public class EnderecoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CriarEndereco()
        {
            return View();
        }

        public IActionResult EditarEndereco()
        {
            return View();
        }
        public IActionResult DeletarEndereco()
        {
            return View();
        }
    }
}
