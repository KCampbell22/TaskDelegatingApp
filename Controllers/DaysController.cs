using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaskDelegatingApp.Data;
using TaskDelegatingApp.Models;

namespace TaskDelegatingApp.Controllers
{
    public class DaysController : Controller
    {
        private readonly TaskDelegatingAppContext _context;

        public DaysController(TaskDelegatingAppContext context)
        {
            _context = context;
        }

        // GET: Days
        public async Task<IActionResult> Index()
        {
              return _context.Day != null ? 
                          View(await _context.Day.ToListAsync()) :
                          Problem("Entity set 'TaskDelegatingAppContext.Day'  is null.");
        }

        // GET: Days/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Day == null)
            {
                return NotFound();
            }

            var day = await _context.Day
                .FirstOrDefaultAsync(m => m.DayID == id);
            if (day == null)
            {
                return NotFound();
            }

            return View(day);
        }

        // GET: Days/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Days/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DayID,DayName,DayDescription")] Day day)
        {
            if (ModelState.IsValid)
            {
                _context.Add(day);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(day);
        }

        // GET: Days/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Day == null)
            {
                return NotFound();
            }

            var day = await _context.Day.FindAsync(id);
            if (day == null)
            {
                return NotFound();
            }
            return View(day);
        }

        // POST: Days/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DayID,DayName,DayDescription")] Day day)
        {
            if (id != day.DayID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(day);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DayExists(day.DayID))
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
            return View(day);
        }

        // GET: Days/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Day == null)
            {
                return NotFound();
            }

            var day = await _context.Day
                .FirstOrDefaultAsync(m => m.DayID == id);
            if (day == null)
            {
                return NotFound();
            }

            return View(day);
        }

        // POST: Days/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Day == null)
            {
                return Problem("Entity set 'TaskDelegatingAppContext.Day'  is null.");
            }
            var day = await _context.Day.FindAsync(id);
            if (day != null)
            {
                _context.Day.Remove(day);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DayExists(int id)
        {
          return (_context.Day?.Any(e => e.DayID == id)).GetValueOrDefault();
        }
    }
}
