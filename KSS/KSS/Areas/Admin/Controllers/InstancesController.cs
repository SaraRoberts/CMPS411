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
    public class InstancesController : Controller
    {
        private readonly DataContext _context;

        public InstancesController(DataContext context)
        {
            _context = context;
        }

        // GET: Admin/Instances
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.Instance.Include(i => i.Course).Include(i => i.Location);
            return View(await dataContext.ToListAsync());
        }

        // GET: Admin/Instances/Details/5
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

        // GET: Admin/Instances/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "CourseId");
            ViewData["LocationId"] = new SelectList(_context.Location, "LocationId", "LocationId");
            return View();
        }

        // POST: Admin/Instances/Create
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

        // GET: Admin/Instances/Edit/5
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

        // POST: Admin/Instances/Edit/5
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

        // GET: Admin/Instances/Delete/5
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

        // POST: Admin/Instances/Delete/5
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
