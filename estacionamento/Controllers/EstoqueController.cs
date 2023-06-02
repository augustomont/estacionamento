using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using estacionamento.Models;

namespace estacionamento.Controllers
{
    public class EstoqueController : Controller
    {
        private readonly Contexto _context;

        public EstoqueController(Contexto context)
        {
            _context = context;
        }

        // GET: Estoque
        public async Task<IActionResult> Index()
        {
              return _context.Estoque != null ? 
                          View(await _context.Estoque.ToListAsync()) :
                          Problem("Entity set 'Contexto.Estoque'  is null.");
        }

        // GET: Estoque/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Estoque == null)
            {
                return NotFound();
            }

            var estoqueModel = await _context.Estoque
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estoqueModel == null)
            {
                return NotFound();
            }

            return View(estoqueModel);
        }

        // GET: Estoque/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Estoque/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Marca,Modelo,Ano,Km,Automatico,Cor,Placa,Preco,Dispinivel,Entrada,Saida")] EstoqueModel estoqueModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estoqueModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estoqueModel);
        }

        // GET: Estoque/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Estoque == null)
            {
                return NotFound();
            }

            var estoqueModel = await _context.Estoque.FindAsync(id);
            if (estoqueModel == null)
            {
                return NotFound();
            }
            return View(estoqueModel);
        }

        // POST: Estoque/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Marca,Modelo,Ano,Km,Automatico,Cor,Placa,Preco,Dispinivel,Entrada,Saida")] EstoqueModel estoqueModel)
        {
            if (id != estoqueModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estoqueModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstoqueModelExists(estoqueModel.Id))
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
            return View(estoqueModel);
        }

        // GET: Estoque/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Estoque == null)
            {
                return NotFound();
            }

            var estoqueModel = await _context.Estoque
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estoqueModel == null)
            {
                return NotFound();
            }

            return View(estoqueModel);
        }

        // POST: Estoque/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Estoque == null)
            {
                return Problem("Entity set 'Contexto.Estoque'  is null.");
            }
            var estoqueModel = await _context.Estoque.FindAsync(id);
            if (estoqueModel != null)
            {
                _context.Estoque.Remove(estoqueModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstoqueModelExists(int id)
        {
          return (_context.Estoque?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
