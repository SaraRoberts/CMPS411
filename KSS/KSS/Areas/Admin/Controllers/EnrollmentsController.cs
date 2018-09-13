using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KSS.Areas.Admin.Data;
using KSS.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;

namespace KSS.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class EnrollmentsController : Controller
    {
        private readonly DataContext _context;

        public EnrollmentsController(DataContext context)
        {
            _context = context;
        }

        // GET: Admin/Enrollments
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.Enrollment.Include(e => e.Instance).Include(e => e.User).Include(c => c.Instance.Course);
            return View(await dataContext.ToListAsync());
        }

        // GET: Admin/Enrollments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrollment = await _context.Enrollment
                .Include(e => e.Instance)
                .Include(e => e.User)
                .FirstOrDefaultAsync(m => m.EnrollmentId == id);
            if (enrollment == null)
            {
                return NotFound();
            }

            return View(enrollment);
        }

        // GET: Enrollments/Roster
        public async Task<IActionResult> Roster(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrollment = await _context.Enrollment
                .Include(e => e.User)
                .Where(e => e.InstanceId == id)
                .ToListAsync();
            var instance = await _context.Instance
                .Include(e => e.Location)
                .Include(e => e.Course)
                .FirstOrDefaultAsync(e => e.InstanceId == id);
            if (instance == null)
            {
                return NotFound();
            }

            ViewData["Course"] = instance.Course.Name;
            ViewData["Location"] = instance.Location.City;
            return View(enrollment);
        }

        // GET: Admin/Enrollments/Create
        public async Task<IActionResult> Create(int? id)
        {
            if (id == null)
            {
                ViewData["InstanceId"] = new SelectList(_context.Instance, "InstanceId", "InstanceId");
                ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FirstName");
                return View();
                //return NotFound();
            }

            var instance = await _context.Instance.FirstOrDefaultAsync(m => m.InstanceId == id);

            if (instance == null)
            {
                return NotFound();
            }
            ViewData["InstanceId"] = new SelectList(_context.Instance, "InstanceId", "InstanceId", instance.InstanceId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId");
            return View();
        }

        // POST: Admin/Enrollments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EnrollmentId,InstanceId,UserId,Status")] Enrollment enrollment)
        {
            if (ModelState.IsValid)
            {
                var duplicate = await _context.Enrollment
                    .FirstOrDefaultAsync(e => e.InstanceId == enrollment.InstanceId && e.UserId == enrollment.UserId);

                if (duplicate == null)
                {
                    _context.Add(enrollment);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }

                ViewData["Duplicate"] = "User already registered for this class.";
                ViewData["InstanceId"] = new SelectList(_context.Instance, "InstanceId", "InstanceId", enrollment.InstanceId);
                ViewData["UserId"] = new SelectList(_context.Users, "UsersId", "UsersId", enrollment.UserId);
                return View(enrollment);
            }

            ViewData["InstanceId"] = new SelectList(_context.Instance, "InstanceId", "InstanceId", enrollment.InstanceId);
            ViewData["UserId"] = new SelectList(_context.Users, "UsersId", "UsersId", enrollment.UserId);
            return View(enrollment);
        }

        // GET: Admin/Enrollments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrollment = await _context.Enrollment.FindAsync(id);
            if (enrollment == null)
            {
                return NotFound();
            }
            ViewData["InstanceId"] = new SelectList(_context.Instance, "InstanceId", "InstanceId", enrollment.InstanceId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId", enrollment.UserId);
            return View(enrollment);
        }

        // POST: Admin/Enrollments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EnrollmentId,InstanceId,UserId,Status")] Enrollment enrollment)
        {
            if (id != enrollment.EnrollmentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enrollment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnrollmentExists(enrollment.EnrollmentId))
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
            ViewData["InstanceId"] = new SelectList(_context.Instance, "InstanceId", "InstanceId", enrollment.InstanceId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId", enrollment.UserId);
            return View(enrollment);
        }

        // GET: Admin/Enrollments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrollment = await _context.Enrollment
                .Include(e => e.Instance)
                .Include(e => e.User)
                .FirstOrDefaultAsync(m => m.EnrollmentId == id);
            if (enrollment == null)
            {
                return NotFound();
            }

            return View(enrollment);
        }

        // POST: Admin/Enrollments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var enrollment = await _context.Enrollment.FindAsync(id);
            _context.Enrollment.Remove(enrollment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnrollmentExists(int id)
        {
            return _context.Enrollment.Any(e => e.EnrollmentId == id);
        }
    }
}
