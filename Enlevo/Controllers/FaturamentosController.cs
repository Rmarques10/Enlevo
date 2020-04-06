using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Enlevo.Contexts;
using Enlevo.Models;

namespace Enlevo.Controllers
{
    public class FaturamentosController : Controller
    {
        private readonly AdegaContext _context;

        public FaturamentosController(AdegaContext context)
        {
            _context = context;
        }

     
        public IActionResult Index()
        {
            return View(_context.Faturamentos.ToList());
        }

       
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faturamento = _context.Faturamentos
                .FirstOrDefault(m => m.FaturamentoId == id);
            if (faturamento == null)
            {
                return NotFound();
            }

            return View(faturamento);
        }

        // GET: Faturamentos/Create
        public IActionResult Create()
        {
            return View();
        }

    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("FaturamentoId,ValorTotal")] Faturamento faturamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(faturamento);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(faturamento);
        }

      
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faturamento = _context.Faturamentos.Find(id);
            if (faturamento == null)
            {
                return NotFound();
            }
            return View(faturamento);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("FaturamentoId,ValorTotal")] Faturamento faturamento)
        {
            if (id != faturamento.FaturamentoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(faturamento);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FaturamentoExists(faturamento.FaturamentoId))
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
            return View(faturamento);
        }

        
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faturamento = _context.Faturamentos
                .FirstOrDefault(m => m.FaturamentoId == id);
            if (faturamento == null)
            {
                return NotFound();
            }

            return View(faturamento);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var faturamento = _context.Faturamentos.Find(id);
            _context.Faturamentos.Remove(faturamento);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool FaturamentoExists(int id)
        {
            return _context.Faturamentos.Any(e => e.FaturamentoId == id);
        }
    }
}
