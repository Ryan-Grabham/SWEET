using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SWEET.Data;
using SWEET.Models;

namespace SWEET
{
    public class MaintenanceIssueController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MaintenanceIssueController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MaintenanceIssue
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.MaintenanceIssue.Include(m => m.Asset).Include(m => m.LoggedBy).Include(m => m.Room);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MaintenanceIssue/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MaintenanceIssue == null)
            {
                return NotFound();
            }

            var maintenanceIssueModel = await _context.MaintenanceIssue
                .Include(m => m.Asset)
                .Include(m => m.LoggedBy)
                .Include(m => m.Room)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (maintenanceIssueModel == null)
            {
                return NotFound();
            }

            return View(maintenanceIssueModel);
        }

        // GET: MaintenanceIssue/Create
        public IActionResult Create()
        {
            ViewData["AssetId"] = new SelectList(_context.Assets, "Id", "Id");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "Id");
            return View();
        }

        // POST: MaintenanceIssue/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Updated,Description,UserId,RoomId,AssetId")] MaintenanceIssueModel maintenanceIssueModel)
        {
                       
                _context.Add(maintenanceIssueModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            
            ViewData["AssetId"] = new SelectList(_context.Assets, "Id", "Id", maintenanceIssueModel.AssetId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", maintenanceIssueModel.UserId);
            ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "Id", maintenanceIssueModel.RoomId);
            return View(maintenanceIssueModel);
        }

        // GET: MaintenanceIssue/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MaintenanceIssue == null)
            {
                return NotFound();
            }

            var maintenanceIssueModel = await _context.MaintenanceIssue.FindAsync(id);
            if (maintenanceIssueModel == null)
            {
                return NotFound();
            }
            ViewData["AssetId"] = new SelectList(_context.Assets, "Id", "Id", maintenanceIssueModel.AssetId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", maintenanceIssueModel.UserId);
            ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "Id", maintenanceIssueModel.RoomId);
            return View(maintenanceIssueModel);
        }

        // POST: MaintenanceIssue/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Updated,Description,UserId,RoomId,AssetId")] MaintenanceIssueModel maintenanceIssueModel)
        {
            if (id != maintenanceIssueModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(maintenanceIssueModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaintenanceIssueModelExists(maintenanceIssueModel.Id))
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
            ViewData["AssetId"] = new SelectList(_context.Assets, "Id", "Id", maintenanceIssueModel.AssetId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", maintenanceIssueModel.UserId);
            ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "Id", maintenanceIssueModel.RoomId);
            return View(maintenanceIssueModel);
        }

        // GET: MaintenanceIssue/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MaintenanceIssue == null)
            {
                return NotFound();
            }

            var maintenanceIssueModel = await _context.MaintenanceIssue
                .Include(m => m.Asset)
                .Include(m => m.LoggedBy)
                .Include(m => m.Room)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (maintenanceIssueModel == null)
            {
                return NotFound();
            }

            return View(maintenanceIssueModel);
        }

        // POST: MaintenanceIssue/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MaintenanceIssue == null)
            {
                return Problem("Entity set 'ApplicationDbContext.MaintenanceIssueModel'  is null.");
            }
            var maintenanceIssueModel = await _context.MaintenanceIssue.FindAsync(id);
            if (maintenanceIssueModel != null)
            {
                _context.MaintenanceIssue.Remove(maintenanceIssueModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MaintenanceIssueModelExists(int id)
        {
          return (_context.MaintenanceIssue?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
