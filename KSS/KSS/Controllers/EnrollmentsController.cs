using KSS.Data;
using KSS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace KSS.Controllers
{
    //[Authorize(Policy = "KSSUser")]
    public class EnrollmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EnrollmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Enrollments
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Enrollment.Include(e => e.Instance).Include(e => e.KSSUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Enrollments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrollment = await _context.Enrollment
                .Include(e => e.Instance)
                .Include(e => e.KSSUser)
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
                .Include(e => e.KSSUser)
                .Where(e => e.InstanceId == id)
                .ToListAsync();
            var instance = await _context.Instance
                .FirstOrDefaultAsync(e => e.InstanceId == id);
            var course = await _context.Course
                .FirstOrDefaultAsync(e => e.CourseId == instance.InstanceId);
            var location = await _context.Location
                .FirstOrDefaultAsync(e => e.LocationId == instance.LocationId);
            if (instance == null)
            {
                return NotFound();
            }

            ViewData["Course"] = course.Name;
            ViewData["Location"] = location.City;
            return View(enrollment);
        }

        // GET: Enrollments/Create
        public async Task<IActionResult> Create(int? id)
        {
            if (id == null)
            {
                ViewData["InstanceId"] = new SelectList(_context.Instance, "InstanceId", "InstanceId");
                ViewData["UserId"] = new SelectList(_context.KSSUsers, "Id", "FirstName");
                return View();
                //return NotFound();
            }

            var instance = await _context.Instance.FirstOrDefaultAsync(m => m.InstanceId == id);
            if (instance == null)
            {
                return NotFound();
            }
            ViewData["InstanceId"] = new SelectList(_context.Instance, "InstanceId", "InstanceId", instance.InstanceId);
            ViewData["UserId"] = new SelectList(_context.KSSUsers, "Id", "FirstName");
            return View();
        }

        // POST: Enrollments/Create
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
                ViewData["UserId"] = new SelectList(_context.KSSUsers, "Id", "FirstName", enrollment.UserId);
                return View(enrollment);
            }

            ViewData["InstanceId"] = new SelectList(_context.Instance, "InstanceId", "InstanceId", enrollment.InstanceId);
            ViewData["UserId"] = new SelectList(_context.KSSUsers, "Id", "FirstName", enrollment.UserId);
            return View(enrollment);
        }

        // GET: Enrollments/Edit/5
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
            ViewData["UserId"] = new SelectList(_context.KSSUsers, "Id", "FirstName", enrollment.UserId);
            return View(enrollment);
        }

        // POST: Enrollments/Edit/5
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
            ViewData["UserId"] = new SelectList(_context.KSSUsers, "Id", "Id", enrollment.UserId);
            return View(enrollment);
        }

        // GET: Enrollments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrollment = await _context.Enrollment
                .Include(e => e.Instance)
                .Include(e => e.KSSUser)
                .FirstOrDefaultAsync(m => m.EnrollmentId == id);
            if (enrollment == null)
            {
                return NotFound();
            }

            return View(enrollment);
        }

        // POST: Enrollments/Delete/5
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
