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
    public class ShippingsController : Controller
    {
        private readonly MaerskLineContext _context;

        public ShippingsController(MaerskLineContext context)
        {
            _context = context;    
        }

        // GET: Shippings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Shipping.ToListAsync());
        }

        // GET: Shippings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shipping = await _context.Shipping
                .SingleOrDefaultAsync(m => m.ID == id);
            if (shipping == null)
            {
                return NotFound();
            }

            return View(shipping);
        }

        // GET: Shippings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Shippings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ShipID,Destination,CargoTag,ShippingDate,ShippingStatus")] Shipping shipping)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shipping);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(shipping);
        }

        // GET: Shippings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shipping = await _context.Shipping.SingleOrDefaultAsync(m => m.ID == id);
            if (shipping == null)
            {
                return NotFound();
            }
            return View(shipping);
        }

        // POST: Shippings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ShipID,Destination,CargoTag,ShippingDate,ShippingStatus")] Shipping shipping)
        {
            if (id != shipping.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shipping);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShippingExists(shipping.ID))
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
            return View(shipping);
        }

        // GET: Shippings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shipping = await _context.Shipping
                .SingleOrDefaultAsync(m => m.ID == id);
            if (shipping == null)
            {
                return NotFound();
            }

            return View(shipping);
        }

        // POST: Shippings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shipping = await _context.Shipping.SingleOrDefaultAsync(m => m.ID == id);
            _context.Shipping.Remove(shipping);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ShippingExists(int id)
        {
            return _context.Shipping.Any(e => e.ID == id);
        }
    }
}
