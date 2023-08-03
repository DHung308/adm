using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Adm1.Data;
using Adm1.Models;

namespace Adm1.Controllers
{
    public class DongvatController : Controller
    {
        private readonly Adm1Context _context;

        public DongvatController(Adm1Context context)
        {
            _context = context;
        }

        // GET: Dongvat
        public async Task<IActionResult> Index()
        {
              return _context.Dongvat != null ? 
                          View(await _context.Dongvat.ToListAsync()) :
                          Problem("Entity set 'Adm1Context.Dongvat'  is null.");
        }

        // GET: Dongvat/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Dongvat == null)
            {
                return NotFound();
            }

            var dongvat = await _context.Dongvat
                .FirstOrDefaultAsync(m => m.ID == id);
            if (dongvat == null)
            {
                return NotFound();
            }

            return View(dongvat);
        }

        // GET: Dongvat/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dongvat/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ChungLoai,XuatXu")] Dongvat dongvat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dongvat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dongvat);
        }

        // GET: Dongvat/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Dongvat == null)
            {
                return NotFound();
            }

            var dongvat = await _context.Dongvat.FindAsync(id);
            if (dongvat == null)
            {
                return NotFound();
            }
            return View(dongvat);
        }

        // POST: Dongvat/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,ChungLoai,XuatXu")] Dongvat dongvat)
        {
            if (id != dongvat.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dongvat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DongvatExists(dongvat.ID))
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
            return View(dongvat);
        }

        // GET: Dongvat/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Dongvat == null)
            {
                return NotFound();
            }

            var dongvat = await _context.Dongvat
                .FirstOrDefaultAsync(m => m.ID == id);
            if (dongvat == null)
            {
                return NotFound();
            }

            return View(dongvat);
        }

        // POST: Dongvat/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Dongvat == null)
            {
                return Problem("Entity set 'Adm1Context.Dongvat'  is null.");
            }
            var dongvat = await _context.Dongvat.FindAsync(id);
            if (dongvat != null)
            {
                _context.Dongvat.Remove(dongvat);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DongvatExists(string id)
        {
          return (_context.Dongvat?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
