using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SiteAgoraVai.Models;

namespace SiteAgoraVai.Controllers
{
    public class TransacoesController : Controller
    {
        private readonly MainContext _context;

        public TransacoesController(MainContext context)
        {
            _context = context;
        }

        // GET: Transacoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Transacoes.ToListAsync());
        }

        // GET: Transacoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transacoes = await _context.Transacoes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transacoes == null)
            {
                return NotFound();
            }

            return View(transacoes);
        }

        // GET: Transacoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Transacoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Valor")] Transacoes transacoes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transacoes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transacoes);
        }

        // GET: Transacoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transacoes = await _context.Transacoes.FindAsync(id);
            if (transacoes == null)
            {
                return NotFound();
            }
            return View(transacoes);
        }

        // POST: Transacoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Valor")] Transacoes transacoes)
        {
            if (id != transacoes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transacoes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransacoesExists(transacoes.Id))
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
            return View(transacoes);
        }

        // GET: Transacoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transacoes = await _context.Transacoes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transacoes == null)
            {
                return NotFound();
            }

            return View(transacoes);
        }

        // POST: Transacoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transacoes = await _context.Transacoes.FindAsync(id);
            _context.Transacoes.Remove(transacoes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransacoesExists(int id)
        {
            return _context.Transacoes.Any(e => e.Id == id);
        }
    }
}
