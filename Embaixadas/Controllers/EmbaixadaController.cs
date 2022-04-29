using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Embaixadas.Controllers
{
    public class EmbaixadaController : Controller
    {
        // GET: EmbaixadaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: EmbaixadaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmbaixadaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmbaixadaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmbaixadaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmbaixadaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmbaixadaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmbaixadaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
