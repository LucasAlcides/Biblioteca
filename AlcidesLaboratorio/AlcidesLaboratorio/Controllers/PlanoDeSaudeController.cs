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
        public IActionResult Listar(IList<PlanoDeSaude> planos)
        {
            return View(planos);
        }
        [HttpPost]
        public IActionResult Listar()
        {
            return View(planoDeSaudeService.FindAll());
        }
        [HttpGet]
        public IActionResult Novo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Novo(PlanoDeSaude planoDeSaude)
        {
            if (ModelState.IsValid)
            {
                planoDeSaudeService.Add(planoDeSaude);
                return RedirectToAction("Listar");
            }
            return View(                                                                                                                           );
        
        }
        //public IActionResult Delete(int id)
        //{
        //    return RedirectToAction();
        //}

    }
}