using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlcidesLaboratorio.Models;
using AlcidesLaboratorio.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlcidesLaboratorio.Controllers
{
    public class PacientesController : Controller
    {
        private readonly PacienteServices pacienteServices;
        public PacientesController(PacienteServices pacienteServices)
        {
            this.pacienteServices = pacienteServices;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            IList<Paciente> pacientes = pacienteServices.FindAll();
            return View(pacientes);
        }
        [HttpPost]
        public IActionResult Listar(IList<Paciente> pacientes)
        {
            return View(pacientes);
        }
        [HttpGet]
        public IActionResult Novo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Novo(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                pacienteServices.Insert(paciente);
                return RedirectToAction(nameof(Listar));
            }
            return View();

        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Paciente paciente = pacienteServices.FindById(id);
            return View(paciente);
        }
        [HttpPost]
        public IActionResult Delete(Paciente paciente)
        {
            pacienteServices.Delete(paciente);
            return RedirectToAction(nameof(Listar));
        }
        [HttpPost]
        public IActionResult Update(Paciente paciente)
        {
            pacienteServices.Update(paciente);
            return RedirectToAction(nameof(Listar));
        }
        public IActionResult Update(int id)
        {
            Paciente paciente = pacienteServices.FindById(id);
            return View(paciente);
        }
    }
}