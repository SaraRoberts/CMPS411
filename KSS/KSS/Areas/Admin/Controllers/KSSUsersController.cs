using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KSS.Data;
using KSS.Models;

namespace KSS.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class KSSUsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KSSUsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/KSSUsers
        public async Task<IActionResult> Index()
        {
            return View(await _context.KSSUsers.ToListAsync());
        }

        // GET: Admin/KSSUsers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kSSUser = await _context.KSSUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kSSUser == null)
            {
                return NotFound();
            }

            return View(kSSUser);
        }

        // GET: Admin/KSSUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/KSSUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,CellPhone,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] KSSUser kSSUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kSSUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kSSUser);
        }

        // GET: Admin/KSSUsers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kSSUser = await _context.KSSUsers.FindAsync(id);
            if (kSSUser == null)
            {
                return NotFound();
            }
            return View(kSSUser);
        }

        // POST: Admin/KSSUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("FirstName,LastName,CellPhone,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] KSSUser kSSUser)
        {
            if (id != kSSUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kSSUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KSSUserExists(kSSUser.Id))
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
            return View(kSSUser);
        }

        // GET: Admin/KSSUsers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kSSUser = await _context.KSSUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kSSUser == null)
            {
                return NotFound();
            }

            return View(kSSUser);
        }

        // POST: Admin/KSSUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var kSSUser = await _context.KSSUsers.FindAsync(id);
            _context.KSSUsers.Remove(kSSUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KSSUserExists(string id)
        {
            return _context.KSSUsers.Any(e => e.Id == id);
        }
    }
}
