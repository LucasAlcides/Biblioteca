using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlcidesMontadora.Models;
using AlcidesMontadora.Services;
using Microsoft.AspNetCore.Mvc;

namespace AlcidesMontadora.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly FonecedorServices fonecedorServices;
        public FornecedorController(FonecedorServices fonecedorServices)
        {
            this.fonecedorServices = fonecedorServices;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            IList<Fornecedor> fornecedores = fonecedorServices.FindAll();
            return View(fornecedores);
        }
        [HttpPost]
        public IActionResult Listar(IList<Fornecedor> fornecedores)
        {
            return View(fornecedores);
        }
        [HttpGet]
        public IActionResult Novo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Novo(Fornecedor fornecedores)
        {
            if (ModelState.IsValid)
            {
                fonecedorServices.Add(fornecedores);
                return RedirectToAction(nameof(Listar));
            }
            return View();

        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Fornecedor fornecedores = fonecedorServices.FindById(id);
            return View(fornecedores);
        }
        [HttpPost]
        public IActionResult Delete(Fornecedor fornecedores)
        {
            fonecedorServices.Delete(fornecedores);
            return RedirectToAction(nameof(Listar));
        }
        [HttpPost]
        public IActionResult Update(Fornecedor fornecedores)
        {
            fonecedorServices.Update(fornecedores);
            return RedirectToAction(nameof(Listar));
        }
        public IActionResult Update(int id)
        {
            Fornecedor fornecedores = fonecedorServices.FindById(id);
            return View(fornecedores);
        }
    }
}