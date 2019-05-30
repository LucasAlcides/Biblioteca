using AlcidesLaboratorio.Models;
using AlcidesLaboratorio.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace AlcidesLaboratorio.Controllers
{
    public class HomeController : Controller
    {
        private readonly PlanoDeSaudeService planodesaudeservice;

        public HomeController(PlanoDeSaudeService planoDeSaudeService)
        {
            this.planodesaudeservice = planodesaudeservice;
        }
        public IActionResult Index()
        {
            IList<PlanoDeSaude> planos = planodesaudeservice.FindAll();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
