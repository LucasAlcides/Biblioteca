using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlcidesMontadora.Models;
using AlcidesMontadora.Services;
using Microsoft.AspNetCore.Mvc;

namespace AlcidesMontadora.Controllers
{
    public class PecaController : Controller
    {
        private readonly PecaServices pecaServices;
        public PecaController(PecaServices pecaServices)
        {
            this.pecaServices = pecaServices;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            IList<Peca> pecas = pecaServices.FindAll();
            return View(pecas);
        }
        [HttpPost]
        public IActionResult Listar(IList<Peca> pecas)
        {
            return View(pecas);
        }
        [HttpGet]
        public IActionResult Novo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Novo(Peca pecas)
        {
            if (ModelState.IsValid)
            {
                pecaServices.Add(pecas);
                return RedirectToAction(nameof(Listar));
            }
            return View();

        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Peca pecas = pecaServices.FindById(id);
            return View(pecas);
        }
        [HttpPost]
        public IActionResult Delete(Peca pecas)
        {
            pecaServices.Delete(pecas);
            return RedirectToAction(nameof(Listar));
        }
        [HttpPost]
        public IActionResult Update(Peca pecas)
        {
            pecaServices.Update(pecas);
            return RedirectToAction(nameof(Listar));
        }
        public IActionResult Update(int id)
        {
            Peca pecas = pecaServices.FindById(id);
            return View(pecas);
        }
    }
}