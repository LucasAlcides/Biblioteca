using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Controllers
{
    public class ItensEmprestimoController : Controller
    {
        public IActionResult Listar()
        {
            Emprestimo emprestimo = new Emprestimo();
            IList<ItensEmprestimo> itensEmprestimos = new ItensEmprestimo(emprestimo).SearchForAll();
            return View(itensEmprestimos);
        }
    }
}
