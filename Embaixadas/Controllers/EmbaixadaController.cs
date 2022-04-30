using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Embaixadas.Models;
using Embaixadas.Models.Context;

namespace Embaixadas.Controllers
{
    public class EmbaixadaController : Controller
    {
        private readonly EmbaixadasContext _context;

        public EmbaixadaController(EmbaixadasContext context)
        {
            _context = context;
        }

        // GET: Embaixada
        public async Task<IActionResult> Index()
        {
            var embaixadasContext = _context.Embaixadas.Include(e => e.Pais);
            return View(await embaixadasContext.ToListAsync());
        }

        // GET: Embaixada/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var embaixada = await _context.Embaixadas
                .Include(e => e.Pais)
                .FirstOrDefaultAsync(m => m.EmbaixadaId == id);
            if (embaixada == null)
            {
                return NotFound();
            }

            return View(embaixada);
        }

        // GET: Embaixada/Create
        public IActionResult Create()
        {
            ViewData["PaisId"] = new SelectList(_context.Pais, "PaisId", "PaisNome");
            return View();
        }

        // POST: Embaixada/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmbaixadaId,EmbaixadaNome,EmbaixadaEndereco,EmbaixadaNumero,EmbaixadaEmail,PaisId")] Embaixada embaixada)
        {
            if (ModelState.IsValid)
            {
                _context.Add(embaixada);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PaisId"] = new SelectList(_context.Pais, "PaisId", "PaisId", embaixada.PaisId);
            return View(embaixada);
        }

        // GET: Embaixada/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var embaixada = await _context.Embaixadas.FindAsync(id);
            if (embaixada == null)
            {
                return NotFound();
            }
            ViewData["PaisId"] = new SelectList(_context.Pais, "PaisId", "PaisId", embaixada.PaisId);
            return View(embaixada);
        }

        // POST: Embaixada/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmbaixadaId,EmbaixadaNome,EmbaixadaEndereco,EmbaixadaNumero,EmbaixadaEmail,PaisId")] Embaixada embaixada)
        {
            if (id != embaixada.EmbaixadaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(embaixada);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmbaixadaExists(embaixada.EmbaixadaId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["PaisId"] = new SelectList(_context.Pais, "PaisId", "PaisId", embaixada.PaisId);
            return View(embaixada);
        }

        // GET: Embaixada/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var embaixada = await _context.Embaixadas
                .Include(e => e.Pais)
                .FirstOrDefaultAsync(m => m.EmbaixadaId == id);
            if (embaixada == null)
            {
                return NotFound();
            }

            return View(embaixada);
        }

        // POST: Embaixada/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var embaixada = await _context.Embaixadas.FindAsync(id);
            _context.Embaixadas.Remove(embaixada);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmbaixadaExists(int id)
        {
            return _context.Embaixadas.Any(e => e.EmbaixadaId == id);
        }
    }
}
