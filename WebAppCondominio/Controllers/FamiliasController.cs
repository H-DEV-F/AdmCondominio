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
    public class FamiliasController : Controller
    {
        private readonly WebAppCondominioContext _context;

        public FamiliasController(WebAppCondominioContext context)
        {
            _context = context;
        }

        // GET: Familias
        public async Task<IActionResult> Index()
        {
            var webAppCondominioContext = _context.Familia.Include(f => f.Condominio);
            return View(await webAppCondominioContext.ToListAsync());
        }

        // GET: Familias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var familia = await _context.Familia
                .Include(f => f.Condominio)
                .FirstOrDefaultAsync(m => m.FamiliaId == id);
            if (familia == null)
            {
                return NotFound();
            }

            return PartialView(familia);
        }

        // GET: Familias/Create
        public IActionResult Create()
        {

            ViewData["Condominio"] = new SelectList(_context.Condominio, "CondominioID", "Nome");
            return View();
        }

        // POST: Familias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FamiliaId,Nome,CondominioID,Apto")] Familia familia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(familia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CondominioID"] = new SelectList(_context.Condominio, "CondominioID", "CondominioID", familia.CondominioID);
            return View(familia);
        }

        // GET: Familias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var familia = await _context.Familia.FindAsync(id);
            if (familia == null)
            {
                return NotFound();
            }
            ViewData["Condominio"] = new SelectList(_context.Condominio, "CondominioID", "Nome", familia.CondominioID);
            return View(familia);
        }

        // POST: Familias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FamiliaId,Nome,CondominioID,Apto")] Familia familia)
        {
            if (id != familia.FamiliaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(familia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FamiliaExists(familia.FamiliaId))
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
            ViewData["CondominioID"] = new SelectList(_context.Condominio, "CondominioID", "CondominioID", familia.CondominioID);
            return View(familia);
        }

        // GET: Familias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var familia = await _context.Familia
                .Include(f => f.Condominio)
                .FirstOrDefaultAsync(m => m.FamiliaId == id);
            if (familia == null)
            {
                return NotFound();
            }

            return View(familia);
        }

        // POST: Familias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var familia = await _context.Familia.FindAsync(id);
            _context.Familia.Remove(familia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FamiliaExists(int id)
        {
            return _context.Familia.Any(e => e.FamiliaId == id);
        }
    }
}
