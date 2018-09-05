using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using KSS.Data;
using KSS.Models;

namespace KSS.Controllers
{
    [Authorize(Policy = "KSSUser")]
    public class InstancesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InstancesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Instances
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Instance.Include(i => i.Course).Include(i => i.Location)
                .OrderBy(i => i.Course.Name);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Instances/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instance = await _context.Instance
                .Include(i => i.Course)
                .Include(i => i.Location)
                .FirstOrDefaultAsync(m => m.InstanceId == id);
            if (instance == null)
            {
                return NotFound();
            }

            return View(instance);
        }

        // GET: Instances/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "Name");
            ViewData["LocationId"] = new SelectList(_context.Location, "LocationId", "Street");
            return View();
        }

        // POST: Instances/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InstanceId,StartDate,Price,CourseId,LocationId,Seats")] Instance instance)
        {
            if (ModelState.IsValid)
            {
                _context.Add(instance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "CourseId", instance.CourseId);
            ViewData["LocationId"] = new SelectList(_context.Location, "LocationId", "LocationId", instance.LocationId);
            return View(instance);
        }

        // GET: Instances/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instance = await _context.Instance.FindAsync(id);
            if (instance == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "CourseId", instance.CourseId);
            ViewData["LocationId"] = new SelectList(_context.Location, "LocationId", "LocationId", instance.LocationId);
            return View(instance);
        }

        // POST: Instances/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InstanceId,StartDate,Price,CourseId,LocationId,Seats")] Instance instance)
        {
            if (id != instance.InstanceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(instance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InstanceExists(instance.InstanceId))
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
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "CourseId", instance.CourseId);
            ViewData["LocationId"] = new SelectList(_context.Location, "LocationId", "LocationId", instance.LocationId);
            return View(instance);
        }

        // GET: Instances/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instance = await _context.Instance
                .Include(i => i.Course)
                .Include(i => i.Location)
                .FirstOrDefaultAsync(m => m.InstanceId == id);
            if (instance == null)
            {
                return NotFound();
            }

            return View(instance);
        }

        // POST: Instances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var instance = await _context.Instance.FindAsync(id);
            _context.Instance.Remove(instance);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InstanceExists(int id)
        {
            return _context.Instance.Any(e => e.InstanceId == id);
        }
    }
}
