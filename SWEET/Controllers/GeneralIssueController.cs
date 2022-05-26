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
    public class GeneralIssueController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GeneralIssueController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: GeneralIssue
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.GeneralIssues.Include(g => g.LoggedBy);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: GeneralIssue/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.GeneralIssues == null)
            {
                return NotFound();
            }

            var generalIssueModel = await _context.GeneralIssues
                .Include(g => g.LoggedBy)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (generalIssueModel == null)
            {
                return NotFound();
            }

            return View(generalIssueModel);
        }

        // GET: GeneralIssue/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: GeneralIssue/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Updated,Description,UserId")] GeneralIssueModel generalIssueModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(generalIssueModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", generalIssueModel.UserId);
            return View(generalIssueModel);
        }

        // GET: GeneralIssue/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.GeneralIssues == null)
            {
                return NotFound();
            }

            var generalIssueModel = await _context.GeneralIssues.FindAsync(id);
            if (generalIssueModel == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", generalIssueModel.UserId);
            return View(generalIssueModel);
        }

        // POST: GeneralIssue/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Updated,Description,UserId")] GeneralIssueModel generalIssueModel)
        {
            if (id != generalIssueModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(generalIssueModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GeneralIssueModelExists(generalIssueModel.Id))
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", generalIssueModel.UserId);
            return View(generalIssueModel);
        }

        // GET: GeneralIssue/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.GeneralIssues == null)
            {
                return NotFound();
            }

            var generalIssueModel = await _context.GeneralIssues
                .Include(g => g.LoggedBy)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (generalIssueModel == null)
            {
                return NotFound();
            }

            return View(generalIssueModel);
        }

        // POST: GeneralIssue/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.GeneralIssues == null)
            {
                return Problem("Entity set 'ApplicationDbContext.GeneralIssueModel'  is null.");
            }
            var generalIssueModel = await _context.GeneralIssues.FindAsync(id);
            if (generalIssueModel != null)
            {
                _context.GeneralIssues.Remove(generalIssueModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GeneralIssueModelExists(int id)
        {
          return (_context.GeneralIssues?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
