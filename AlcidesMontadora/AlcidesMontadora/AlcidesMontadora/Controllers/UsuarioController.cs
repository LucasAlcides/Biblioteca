using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlcidesMontadora.Models;
using AlcidesMontadora.Services;
using Microsoft.AspNetCore.Mvc;

namespace AlcidesMontadora.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UsuarioServices usuarioServices;
        public UsuarioController(UsuarioServices usuarioServices)
        {
            this.usuarioServices = usuarioServices;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            IList<Usuario> usuarios = usuarioServices.GetAll();
            return View(usuarios);
        }
        [HttpPost]
        public IActionResult Listar(IList<Usuario> usuarios)
        {
            return View(usuarios);
        }
        [HttpGet]
        public IActionResult Novo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Novo(Usuario usuarios)
        {
            if (ModelState.IsValid)
            {
                usuarioServices.Add(usuarios);
                return RedirectToAction(nameof(Listar));
            }
            return View();

        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Usuario usuarios = usuarioServices.FindById(id);
            return View(usuarios);
        }
        [HttpPost]
        public IActionResult Delete(Usuario usuarios)
        {
            usuarioServices.Delete(usuarios);
            return RedirectToAction(nameof(Listar));
        }
        [HttpPost]
        public IActionResult Update(Usuario usuarios)
        {
            usuarioServices.Update(usuarios);
            return RedirectToAction(nameof(Listar));
        }
        public IActionResult Update(int id)
        {
            Usuario usuarios = usuarioServices.FindById(id);
            return View(usuarios);
        }
    }
}