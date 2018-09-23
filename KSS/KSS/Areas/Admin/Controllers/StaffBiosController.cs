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
    public class StaffBiosController : Controller
    {
        private readonly DataContext _context;

        public StaffBiosController(DataContext context)
        {
            _context = context;
        }

        // GET: Admin/StaffBios
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.Bio.Include(s => s.User);
            return View(await dataContext.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Details(int? id)
        {
             if (id == null)
             {
                 return NotFound();
             }

             var staffBio = await _context.Bio
                 .Include(s => s.User)
                 .FirstOrDefaultAsync(m => m.StaffBioId == id);
             if (staffBio == null)
             {
                 return NotFound();
             }


            return Json(new
            {
                success  = true,
                fullName = staffBio.User.FirstName + " " + staffBio.User.LastName,
                bio      = staffBio.Bio,
                picture  = staffBio.Picture

            });
        }

        // GET: Admin/StaffBios/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FirstName");
            return View();
        }

        // POST: Admin/StaffBios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StaffBioId,Picture,Bio,UserId")] StaffBio staffBio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(staffBio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FirstName", staffBio.UserId);
            return View(staffBio);
        }

        // GET: Admin/StaffBios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffBio = await _context.Bio.FindAsync(id);
            if (staffBio == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FirstName", staffBio.UserId);
            return View(staffBio);
        }

        // POST: Admin/StaffBios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StaffBioId,Picture,Bio,UserId")] StaffBio staffBio)
        {
            if (id != staffBio.StaffBioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(staffBio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StaffBioExists(staffBio.StaffBioId))
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
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FirstName", staffBio.UserId);
            return View(staffBio);
        }

        // GET: Admin/StaffBios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffBio = await _context.Bio
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.StaffBioId == id);
            if (staffBio == null)
            {
                return NotFound();
            }

            return View(staffBio);
        }

        // POST: Admin/StaffBios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var staffBio = await _context.Bio.FindAsync(id);
            _context.Bio.Remove(staffBio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StaffBioExists(int id)
        {
            return _context.Bio.Any(e => e.StaffBioId == id);
        }
    }
}
