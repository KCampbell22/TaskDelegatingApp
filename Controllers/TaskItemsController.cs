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
    public class TaskItemsController : Controller
    {
        private readonly TaskDelegatingAppContext _context;

        public TaskItemsController(TaskDelegatingAppContext context)
        {
            _context = context;
        }

        // GET: TaskItems
        public async Task<IActionResult> Index()
        {
<<<<<<< Updated upstream
            var taskDelegatingAppContext = _context.TaskItem.Include(t => t.Day);
            return View(await taskDelegatingAppContext.ToListAsync());
=======

            var taskItems = _context.TaskItem.Include(e => e.Person).Include(e => e.Day);
            
                return View(await taskItems.ToListAsync());
>>>>>>> Stashed changes
        }

        // GET: TaskItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TaskItem == null)
            {
                return NotFound();
            }

            var taskItem = await _context.TaskItem
                .Include(t => t.Day)
                .FirstOrDefaultAsync(m => m.TaskItemID == id);
            if (taskItem == null)
            {
                return NotFound();
            }

            return View(taskItem);
        }

        // GET: TaskItems/Create
        public IActionResult Create()
        {
            ViewData["DayID"] = new SelectList(_context.Day, "DayID", "DayID");
            return View();
        }

        // POST: TaskItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TaskItemID,TaskName,TaskDescription,TimeOfDay,DayID")] TaskItem taskItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(taskItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DayID"] = new SelectList(_context.Day, "DayID", "DayID", taskItem.DayID);
            return View(taskItem);
        }

        // GET: TaskItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TaskItem == null)
            {
                return NotFound();
            }

            var taskItem = await _context.TaskItem.FindAsync(id);
            if (taskItem == null)
            {
                return NotFound();
            }
            ViewData["DayID"] = new SelectList(_context.Day, "DayID", "DayID", taskItem.DayID);
            return View(taskItem);
        }

        // POST: TaskItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TaskItemID,TaskName,TaskDescription,TimeOfDay,DayID")] TaskItem taskItem)
        {
            if (id != taskItem.TaskItemID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taskItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaskItemExists(taskItem.TaskItemID))
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
            ViewData["DayID"] = new SelectList(_context.Day, "DayID", "DayID", taskItem.DayID);
            return View(taskItem);
        }

        // GET: TaskItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TaskItem == null)
            {
                return NotFound();
            }

            var taskItem = await _context.TaskItem
                .Include(t => t.Day)
                .FirstOrDefaultAsync(m => m.TaskItemID == id);
            if (taskItem == null)
            {
                return NotFound();
            }

            return View(taskItem);
        }

        // POST: TaskItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TaskItem == null)
            {
                return Problem("Entity set 'TaskDelegatingAppContext.TaskItem'  is null.");
            }
            var taskItem = await _context.TaskItem.FindAsync(id);
            if (taskItem != null)
            {
                _context.TaskItem.Remove(taskItem);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaskItemExists(int id)
        {
          return (_context.TaskItem?.Any(e => e.TaskItemID == id)).GetValueOrDefault();
        }
    }
}
