using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlcidesMontadora.Models;
using AlcidesMontadora.Services;
using Microsoft.AspNetCore.Mvc;

namespace AlcidesMontadora.Controllers
{
    public class CidadeController : Controller
    {
        private readonly CidadeServices cidadeServices;
        public CidadeController(CidadeServices cidadeServices)
        {
            this.cidadeServices = cidadeServices;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            IList<Cidade> cidades = cidadeServices.FindAll();
            return View(cidades);
        }
        [HttpPost]
        public IActionResult Listar(IList<Cidade> cidades)
        {
            return View(cidades);
        }
        [HttpGet]
        public IActionResult Novo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Novo(Cidade cidades)
        {
            if (ModelState.IsValid)
            {
                cidadeServices.Insert(cidades);
                return RedirectToAction(nameof(Listar));
            }
            return View();

        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Cidade cidades = cidadeServices.FindById(id);
            return View(cidades);
        }
        [HttpPost]
        public IActionResult Delete(Cidade cidades)
        {
            cidadeServices.Delete(cidades);
            return RedirectToAction(nameof(Listar));
        }
        [HttpPost]
        public IActionResult Update(Cidade cidades)
        {
            cidadeServices.Update(cidades);
            return RedirectToAction(nameof(Listar));
        }
        public IActionResult Update(int id)
        {
            Cidade cidade = cidadeServices.FindById(id);
            return View(cidade);
        }
    }
}