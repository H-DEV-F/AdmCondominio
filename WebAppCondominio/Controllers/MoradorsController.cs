using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppCondominio.Data;
using WebAppCondominio.Models;

namespace WebAppCondominio.Controllers
{
    public class MoradorsController : Controller
    {
        private readonly WebAppCondominioContext _context;

        public MoradorsController(WebAppCondominioContext context)
        {
            _context = context;
        }

        // GET: Moradors
        public async Task<IActionResult> Index()
        {
            var webAppCondominioContext = _context.Morador.Include(m => m.Familia);
            return View(await webAppCondominioContext.ToListAsync());
        }

        // GET: Moradors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var morador = await _context.Morador
                .Include(m => m.Familia)
                .FirstOrDefaultAsync(m => m.MoradorID == id);
            if (morador == null)
            {
                return NotFound();
            }

            return PartialView(morador);
        }

        // GET: Moradors/Create
        public IActionResult Create()
        {
            ViewData["Familia"] = new SelectList(_context.Familia, "FamiliaId", "Nome");
            return View();
        }

        // POST: Moradors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MoradorID,FamiliaID,Nome,QuantidadeBichosEstimacao")] Morador morador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(morador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FamiliaID"] = new SelectList(_context.Familia, "FamiliaId", "FamiliaId", morador.FamiliaID);
            return View(morador);
        }

        // GET: Moradors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var morador = await _context.Morador.FindAsync(id);
            if (morador == null)
            {
                return NotFound();
            }
            ViewData["Familia"] = new SelectList(_context.Familia, "FamiliaId", "Nome", morador.FamiliaID);
            return View(morador);
        }

        // POST: Moradors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MoradorID,FamiliaID,Nome,QuantidadeBichosEstimacao")] Morador morador)
        {
            if (id != morador.MoradorID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(morador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoradorExists(morador.MoradorID))
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
            ViewData["FamiliaID"] = new SelectList(_context.Familia, "FamiliaId", "FamiliaId", morador.FamiliaID);
            return View(morador);
        }

        // GET: Moradors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var morador = await _context.Morador
                .Include(m => m.Familia)
                .FirstOrDefaultAsync(m => m.MoradorID == id);
            if (morador == null)
            {
                return NotFound();
            }

            return View(morador);
        }

        // POST: Moradors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var morador = await _context.Morador.FindAsync(id);
            _context.Morador.Remove(morador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MoradorExists(int id)
        {
            return _context.Morador.Any(e => e.MoradorID == id);
        }
    }
}
