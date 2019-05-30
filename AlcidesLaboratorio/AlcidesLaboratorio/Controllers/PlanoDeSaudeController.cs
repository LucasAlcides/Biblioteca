using AlcidesLaboratorio.Models;
using AlcidesLaboratorio.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AlcidesLaboratorio.Controllers
{
    public class PlanoDeSaudeController : Controller
    {
        private readonly PlanoDeSaudeService planoDeSaudeService;
        public PlanoDeSaudeController(PlanoDeSaudeService planoDeSaudeService)
        {
            this.planoDeSaudeService = planoDeSaudeService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Listar()
        {
            IList<PlanoDeSaude> planos = new List<PlanoDeSaude>();
            planoDeSaudeService.FindAll();
            return View(planos);
        }
    }
}