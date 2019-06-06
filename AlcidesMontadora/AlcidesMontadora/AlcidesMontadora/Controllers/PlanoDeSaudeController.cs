using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlcidesMontadora.Controllers
{
    public class PlanoDeSaudeController : Controller
    {
        // GET: PlanoDeSaude
        public ActionResult Index()
        {
            return View();
        }

        // GET: PlanoDeSaude/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlanoDeSaude/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlanoDeSaude/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PlanoDeSaude/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlanoDeSaude/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PlanoDeSaude/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PlanoDeSaude/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}