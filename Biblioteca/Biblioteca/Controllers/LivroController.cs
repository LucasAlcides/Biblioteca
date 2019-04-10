using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Controllers
{
    public class LivroController : Controller
    {
        [HttpGet]
        public IActionResult Listar()
        {
            IList<Livro> livros = new Livro().SearchForAll();
            return View(livros);
        }
        [HttpGet]
        public IActionResult Novo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Novo(Livro livro)
        {
            livro.Insert();
            return RedirectToAction("Listar");
        }
        [HttpGet]
        public IActionResult Excluir(int id)
        {
            Livro livro = new Livro().SearchForId(id);
            return View(livro);
        }
        [HttpPost]
        public IActionResult Excluir(Livro livro)
        {
            livro.Delete();
            return RedirectToAction("Listar");
        }
        //public IActionResult Editar(Livro livro)
        //{

        //}
    }
}
