﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using asp.net_mvc_core.Models;

namespace asp.net_mvc_core.Controllers
{
    [Route("")]
    [Route("gestao-clientes")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("pagina-principal")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("sobre")]
        [Route("sobre/{id:int}/{empresa:guid}")]
        public IActionResult About(int id, Guid empresa)
        {
            Informacoes(id, empresa);
            return View();
        }

        [Route("contato")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            //return Json("{nome: " +ViewData["nome"]+"}");
            return View();
        }

        [Route("privacidade")]
        public IActionResult Privacy()
        {
            return View("Privacy");
        }

        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("erro")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // testando function
        public void Informacoes(int id, Guid empresa)
        {   
            ViewData["Message"] = "ID: "+ id + " EMPRESA: " + empresa;
        }
    }
}
