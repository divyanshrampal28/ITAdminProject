using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ITAdminProject.Models;

namespace ITAdminProject.Controllers
{
    public class InventoriesController : Controller
    {
        private readonly ItAdminContext _context;

        public InventoriesController(ItAdminContext context)
        {
            _context = context;
        }

        // GET: Inventories
        public async Task<IActionResult> Index()
        {
            var itAdminContext = _context.Inventory.Include(i => i.AssignedToNavigation).Include(i => i.Category).Include(i => i.CreatedByNavigation).Include(i => i.Status).Include(i => i.UpdatedByNavigation);
            return View(await itAdminContext.ToListAsync());
        }

        // GET: Inventories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventory = await _context.Inventory
                .Include(i => i.AssignedToNavigation)
                .Include(i => i.Category)
                .Include(i => i.CreatedByNavigation)
                .Include(i => i.Status)
                .Include(i => i.UpdatedByNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inventory == null)
            {
                return NotFound();
            }

            return View(inventory);
        }

        // GET: Inventories/Create
        public IActionResult Create()
        {
            ViewData["AssignedTo"] = new SelectList(_context.Employee, "Id", "Email");
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "CategoryName");
            ViewData["CreatedBy"] = new SelectList(_context.Employee, "Id", "Email");
            ViewData["StatusId"] = new SelectList(_context.StatusTable, "Id", "StatusName");
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "Id", "Email");
            return View();
        }

        // POST: Inventories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DeviceName,SerialNumber,CategoryId,CreatedBy,CreatedAtUtc,UpdatedBy,UpdatedAtUtc,AssignedTo,StatusId")] Inventory inventory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inventory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AssignedTo"] = new SelectList(_context.Employee, "Id", "Email", inventory.AssignedTo);
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "CategoryName", inventory.CategoryId);
            ViewData["CreatedBy"] = new SelectList(_context.Employee, "Id", "Email", inventory.CreatedBy);
            ViewData["StatusId"] = new SelectList(_context.StatusTable, "Id", "StatusName", inventory.StatusId);
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "Id", "Email", inventory.UpdatedBy);
            return View(inventory);
        }

        // GET: Inventories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventory = await _context.Inventory.FindAsync(id);
            if (inventory == null)
            {
                return NotFound();
            }
            ViewData["AssignedTo"] = new SelectList(_context.Employee, "Id", "Email", inventory.AssignedTo);
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "CategoryName", inventory.CategoryId);
            ViewData["CreatedBy"] = new SelectList(_context.Employee, "Id", "Email", inventory.CreatedBy);
            ViewData["StatusId"] = new SelectList(_context.StatusTable, "Id", "StatusName", inventory.StatusId);
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "Id", "Email", inventory.UpdatedBy);
            return View(inventory);
        }

        // POST: Inventories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DeviceName,SerialNumber,CategoryId,CreatedBy,CreatedAtUtc,UpdatedBy,UpdatedAtUtc,AssignedTo,StatusId")] Inventory inventory)
        {
            if (id != inventory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inventory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InventoryExists(inventory.Id))
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
            ViewData["AssignedTo"] = new SelectList(_context.Employee, "Id", "Email", inventory.AssignedTo);
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "CategoryName", inventory.CategoryId);
            ViewData["CreatedBy"] = new SelectList(_context.Employee, "Id", "Email", inventory.CreatedBy);
            ViewData["StatusId"] = new SelectList(_context.StatusTable, "Id", "StatusName", inventory.StatusId);
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "Id", "Email", inventory.UpdatedBy);
            return View(inventory);
        }

        // GET: Inventories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventory = await _context.Inventory
                .Include(i => i.AssignedToNavigation)
                .Include(i => i.Category)
                .Include(i => i.CreatedByNavigation)
                .Include(i => i.Status)
                .Include(i => i.UpdatedByNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inventory == null)
            {
                return NotFound();
            }

            return View(inventory);
        }

        // POST: Inventories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inventory = await _context.Inventory.FindAsync(id);
            _context.Inventory.Remove(inventory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InventoryExists(int id)
        {
            return _context.Inventory.Any(e => e.Id == id);
        }
    }
}
