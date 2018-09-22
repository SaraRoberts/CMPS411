using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KSS.Areas.Admin.Data;
using KSS.Areas.Admin.Models;

namespace KSS.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BioController : Controller
    {
        private readonly DataContext _context;

        public BioController(DataContext context)
        {
            _context = context;
        }

        // GET: Admin/Bio
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bio.ToListAsync());
        }

        // GET: Admin/Bio/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bio = await _context.Bio
                .FirstOrDefaultAsync(m => m.StaffBioId == id);
            if (bio == null)
            {
                return NotFound();
            }

            return View(bio);
        }

        // GET: Admin/Bio/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Bio/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StaffId,Picture,Bio")] StaffBio bio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bio);
        }

        // GET: Admin/Bio/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bio = await _context.Bio.FindAsync(id);
            if (bio == null)
            {
                return NotFound();
            }
            return View(bio);
        }

        // POST: Admin/Bio/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StaffId,Picture,Bio")] StaffBio bio)
        {
            if (id != bio.StaffBioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BioExists(bio.StaffBioId))
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
            return View(bio);
        }

        // GET: Admin/Bio/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bio = await _context.Bio
                .FirstOrDefaultAsync(m => m.StaffBioId == id);
            if (bio == null)
            {
                return NotFound();
            }

            return View(bio);
        }

        // POST: Admin/Bio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bio = await _context.Bio.FindAsync(id);
            _context.Bio.Remove(bio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BioExists(int id)
        {
            return _context.Bio.Any(e => e.StaffBioId == id);
        }
    }
}
