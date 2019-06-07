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
                planoDeSaudeService.Insert(planoDeSaude);
                return RedirectToAction(nameof(Listar));
            }
            return View();                                                                                                                         

        }
        [HttpPost]
        public IActionResult Delete(PlanoDeSaude planoDeSaude)
        {
            planoDeSaudeService.Delete(planoDeSaude);
            return RedirectToAction(nameof(Listar));
        }
        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(PlanoDeSaude planoDeSaude)
        {
            planoDeSaudeService.Update(planoDeSaude);
            return RedirectToAction(nameof(Listar));
        }
        public IActionResult Update()
        {
            return View();
        }

    } 
}