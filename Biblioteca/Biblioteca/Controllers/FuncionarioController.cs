using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Controllers
{
    public class FuncionarioController : Controller
    {
        [HttpGet]
        public IActionResult Listar()
        {
            IList<Funcionario> funcionarios = new Funcionario().SearchForAll();
            return View(funcionarios);
        }
        [HttpGet]
        public IActionResult Novo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Novo(Funcionario funcionario)
        {
            funcionario.Insert();
            return RedirectToAction("Listar");
        }
        [HttpGet]
        public IActionResult Excluir(int id)
        {
            Funcionario funcionario = new Funcionario().SearchForId(id);
            return View(funcionario);
        }
        [HttpPost]
        public IActionResult Excluir(Funcionario funcionario)
        {
            funcionario.Delete();
            return RedirectToAction("Listar");
        }
        //public IActionResult Editar()
        //{

        //}
    }
}
