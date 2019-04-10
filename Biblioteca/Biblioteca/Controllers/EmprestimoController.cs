using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Controllers
{
    public class EmprestimoController : Controller
    {
        public IActionResult Listar()
        {
            IList<Emprestimo> emprestimos = new Emprestimo().SearchForAll();
            return View(emprestimos);
        }
    }
}
