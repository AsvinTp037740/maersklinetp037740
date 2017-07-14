using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MaerskLine.Models;

namespace MaerskLine.Controllers
{
    public class CargoController : Controller
    {
        private readonly MaerskLineContext _context;

        public CargoController(MaerskLineContext context)
        {
            _context = context;    
        }

        // GET: Cargo
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cargocargo.ToListAsync());
        }

        // GET: Cargo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cargocargo = await _context.Cargocargo
                .SingleOrDefaultAsync(m => m.ID == id);
            if (cargocargo == null)
            {
                return NotFound();
            }

            return View(cargocargo);
        }

        // GET: Cargo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cargo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CargoWeight,CargoMaterial,WarehouseNo,CargoTag")] Cargocargo cargocargo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cargocargo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(cargocargo);
        }

        // GET: Cargo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cargocargo = await _context.Cargocargo.SingleOrDefaultAsync(m => m.ID == id);
            if (cargocargo == null)
            {
                return NotFound();
            }
            return View(cargocargo);
        }

        // POST: Cargo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CargoWeight,CargoMaterial,WarehouseNo,CargoTag")] Cargocargo cargocargo)
        {
            if (id != cargocargo.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cargocargo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CargocargoExists(cargocargo.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(cargocargo);
        }

        // GET: Cargo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cargocargo = await _context.Cargocargo
                .SingleOrDefaultAsync(m => m.ID == id);
            if (cargocargo == null)
            {
                return NotFound();
            }

            return View(cargocargo);
        }

        // POST: Cargo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cargocargo = await _context.Cargocargo.SingleOrDefaultAsync(m => m.ID == id);
            _context.Cargocargo.Remove(cargocargo);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool CargocargoExists(int id)
        {
            return _context.Cargocargo.Any(e => e.ID == id);
        }
    }
}
