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
using KSS.Areas.Admin.ViewModels;

namespace KSS.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CoursesController : Controller
    {
        private readonly DataContext _context;

        public CoursesController(DataContext context)
        {
            _context = context;
        }

        // GET: Admin/Courses
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Course.Include(c => c.Prereq).Include(c => c.CourseCategory)
                .OrderBy(c => c.Name);
            return View(await applicationDbContext.ToListAsync());
        }

        [Authorize(Roles = "User, Admin")]
        // GET: Instructor Courses
        public async Task<IActionResult> CourseList()
        {
            var applicationDbContext = _context.Course.Include(c => c.Prereq).Include(c => c.CourseCategory)
                .OrderBy(c => c.Name);
            return View(await applicationDbContext.ToListAsync());
        }
     
        [HttpPost]
        public async Task<ActionResult> CourseDetail(int? id)
        {
            string preRequisite = "";
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Course
                .Include(c => c.Prereq)
                .Include(c => c.CourseCategory)
                .FirstOrDefaultAsync(m => m.CourseId == id);
            if (course.Prereq != null)
            {
                preRequisite = course.Prereq.Name;
            }
            if (course == null)
            {
                return NotFound();
            }
            return Json(new
            {
                success = true,
                description = course.Description,
                name = course.Name,
                price = course.TypicalPrice,
                book = course.BookAvailable,
                bookPrice = course.BookPrice,
                preReq = preRequisite
            });
        }

        // GET: Admin/Courses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Course
                .Include(c => c.Prereq)
                .Include(c => c.CourseCategory)
                .FirstOrDefaultAsync(m => m.CourseId == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // GET: Admin/Courses/Create
        public IActionResult Create()
        {
            ViewData["PrereqId"] = new SelectList(_context.Course, "CourseId", "Name");
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "Name");
            return View();
        }

        // POST: Admin/Courses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CourseCreate course)
        {
            if (ModelState.IsValid)
            {
                var newCourse = new Course
                {
                    Name = course.Name,
                    Description = course.Description,
                    TypicalPrice = course.TypicalPrice,
                    BookAvailable = course.BookAvailable,
                    BookPrice = course.BookPrice,
                    PrereqId = course.PrereqId,
                    CategoryId = course.CategoryId
                };
                _context.Add(newCourse);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PrereqId"] = new SelectList(_context.Course, "CourseId", "Name", course.PrereqId);
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "Name", course.CategoryId);
            return View(course);
        }

        // GET: Admin/Courses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Course.FindAsync(id);
            var editCourse = new CourseEdit
            {
                CourseId = course.CourseId,
                Name = course.Name,
                Description = course.Description,
                TypicalPrice = course.TypicalPrice,
                BookAvailable = course.BookAvailable,
                BookPrice = course.BookPrice,
                PrereqId = course.PrereqId,
                CategoryId = course.CategoryId
            };
            if (course == null)
            {
                return NotFound();
            }
            ViewData["PrereqId"] = new SelectList(_context.Course, "CourseId", "Name", course.PrereqId);
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "Name", course.CategoryId);
            return View(editCourse);
        }

        // POST: Admin/Courses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CourseEdit course)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var editCourse = new Course
                    {
                        CourseId = course.CourseId,
                        Name = course.Name,
                        Description = course.Description,
                        TypicalPrice = course.TypicalPrice,
                        BookAvailable = course.BookAvailable,
                        BookPrice = course.BookPrice,
                        PrereqId = course.PrereqId,
                        CategoryId = course.CategoryId
                    };
                    _context.Update(editCourse);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseExists(course.CourseId))
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
            ViewData["PrereqId"] = new SelectList(_context.Course, "CourseId", "Name", course.PrereqId);
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "Name", course.CategoryId);
            return View(course);
        }

        // GET: Admin/Courses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Course
                .Include(c => c.Prereq)
                .Include(c => c.CourseCategory)
                .FirstOrDefaultAsync(m => m.CourseId == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: Admin/Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var course = await _context.Course
                .Include(e => e.CourseCategory)
                .FirstOrDefaultAsync(m => m.CourseId == id);

            var used = await _context.Instance
                .Include(e => e.Course)
                .Include(e => e.Location)
                .FirstOrDefaultAsync(e => e.CourseId == course.CourseId);
            if (used != null)
            {
                ViewData["Duplicate"] = used.Course.Name + " in " + used.Location.City + " is using this Course.";
                return View(course);
            }
            _context.Course.Remove(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseExists(int id)
        {
            return _context.Course.Any(e => e.CourseId == id);
        }
    }
}
