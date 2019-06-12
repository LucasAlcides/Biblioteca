using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlcidesMontadora.Models;
using AlcidesMontadora.Services;
using Microsoft.AspNetCore.Mvc;

namespace AlcidesMontadora.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly VeiculoServices veiculoServices;
        public VeiculoController(VeiculoServices veiculoServices)
        {
            this.veiculoServices = veiculoServices;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            IList<Veiculo> veiculos = veiculoServices.FindAll();
            return View(veiculos);
        }
        [HttpPost]
        public IActionResult Listar(IList<Veiculo> veiculos)
        {
            return View(veiculos);
        }
        [HttpGet]
        public IActionResult Novo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Novo(Veiculo veiculos)
        {
            if (ModelState.IsValid)
            {
                veiculoServices.Add(veiculos);
                return RedirectToAction(nameof(Listar));
            }
            return View();

        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Veiculo veiculos = veiculoServices.FindById(id);
            return View(veiculos);
        }
        [HttpPost]
        public IActionResult Delete(Veiculo veiculos)
        {
            veiculoServices.Delete(veiculos);
            return RedirectToAction(nameof(Listar));
        }
        [HttpPost]
        public IActionResult Update(Veiculo veiculos)
        {
            veiculoServices.Update(veiculos);
            return RedirectToAction(nameof(Listar));
        }
        public IActionResult Update(int id)
        {
            Veiculo veiculos = veiculoServices.FindById(id);
            return View(veiculos);
        }
    }
}