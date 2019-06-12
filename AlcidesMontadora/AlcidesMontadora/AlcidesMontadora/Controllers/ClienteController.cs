using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlcidesMontadora.Models;
using AlcidesMontadora.Services;
using Microsoft.AspNetCore.Mvc;

namespace AlcidesMontadora.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteServices clienteServices;
        public ClienteController(ClienteServices clienteServices)
        {
            this.clienteServices = clienteServices;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            IList<Cliente> clientes = clienteServices.GetAll();
            return View(clientes);
        }
        [HttpPost]
        public IActionResult Listar(IList<Cliente> clientes)
        {
            return View(clientes);
        }
        [HttpGet]
        public IActionResult Novo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Novo(Cliente clientes)
        {
            if (ModelState.IsValid)
            {
                clienteServices.Add(clientes);
                return RedirectToAction(nameof(Listar));
            }
            return View();

        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Cliente clientes = clienteServices.FindById(id);
            return View(clientes);
        }
        [HttpPost]
        public IActionResult Delete(Cliente clientes)
        {
            clienteServices.Delete(clientes);
            return RedirectToAction(nameof(Listar));
        }
        [HttpPost]
        public IActionResult Update(Cliente clientes)
        {
            clienteServices.Update(clientes);
            return RedirectToAction(nameof(Listar));
        }
        public IActionResult Update(int id)
        {
            Cliente clientes = clienteServices.FindById(id);
            return View(clientes);
        }
    }
}