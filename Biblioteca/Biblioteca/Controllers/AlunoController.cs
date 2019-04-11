using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Controllers
{
    public class AlunoController : Controller
    {
        [HttpGet]
        public IActionResult Listar()
        {
            IList<Aluno> alunos = new Aluno().SearchForAll();
            return View(alunos);
        }
        [HttpPost]
        public IActionResult Listar(IList<Aluno> alunos)
        {
            return View(alunos);
        }
        [HttpGet]
        public IActionResult Novo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Novo(Aluno aluno)
        {
            aluno.Insert();
            return RedirectToAction("Listar");
        }
        [HttpGet]
        public IActionResult Excluir(int id)
        {
            Aluno aluno = new Aluno().SearchForId(id);
            return View(aluno);
        }
        [HttpPost]
        public IActionResult Excluir(Aluno aluno)
        {
            aluno.Delete();
            return RedirectToAction("Listar");
        }
        //       public IActionResult Editar()
        //       {

        //       }
        //}
    }
}
