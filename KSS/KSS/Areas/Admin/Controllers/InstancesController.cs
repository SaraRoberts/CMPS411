﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KSS.Areas.Admin.Data;
using KSS.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using System.Globalization;

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

        [Authorize(Roles = "Admin")]
        // GET: Admin/Instances
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.Instance
                .Include(i => i.Course)
                .Include(i => i.Location)
                .Include(i => i.Course.CourseCategory)
                .Include(i => i.Instructor)
                .OrderByDescending(e => e.StartDate);
            return View(await dataContext.ToListAsync());
        }

        [Authorize(Roles = "Admin, Staff")]
        // GET: Instructor's Classes
        public async Task<IActionResult> ClassList()
        {
            var dataContext = _context.Instance.Include(i => i.Course)
                .Include(i => i.Location)
                .Include(i => i.Instructor)
                .Where(e => e.StartDate >= DateTime.UtcNow);
            return View(await dataContext.ToListAsync());
        }

        [Authorize(Roles = "Admin, Staff")]
        [HttpPost]
        public async Task<ActionResult> ClassDetail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instance = await _context.Instance
                .Include(i => i.Course)
                .Include(i => i.Location)
                .Include(i => i.Instructor)
                .FirstOrDefaultAsync(m => m.InstanceId == id);
            if (instance == null)
            {
                return NotFound();
            }

            String month = instance.StartDate.ToString("MMMM");
            String time = instance.StartDate.ToString("h:mm tt");

            var response = Json(new
            {
                success = true,
                startdate = instance.StartDate.DayOfWeek +
                    ", " + month + ", " + instance.StartDate.Day +
                    ", " + instance.StartDate.Year,
                price = instance.Price,
                course = instance.Course.Name,
                location = instance.Location.Name,
                seats = instance.Seats,
                instructor = instance.Instructor.FirstName +" "+ instance.Instructor.LastName,
                bookavailable = instance.BookAvailable,
                bookprice = instance.BookPrice,
                       

            });

            return response;
        }

        [HttpPost]
        public async Task<ActionResult> Details(int? id)
        {
            string bookAvailible = "Book Availible : No";
            string bookPrice = "";
            if (id == null)
            {
                return NotFound();
            }

            var instance = await _context.Instance
                .Include(i => i.Course)
                .Include(i => i.Location)
                .Include(i => i.Instructor)
                .FirstOrDefaultAsync(m => m.InstanceId == id);
            if (instance == null)
            {
                return NotFound();
            }
            if (instance.BookAvailable)
            {
                bookPrice = instance.BookPrice.ToString();
                bookPrice = "Book Price: " + "$ "+bookPrice;
                bookAvailible = "Book Available : Yes";
            }

            String month = instance.StartDate.ToString("MMMM");
            String time = instance.StartDate.ToString("h:mm tt");

            return Json(new
            {
                success    = true,
                startDate  = instance.StartDate.ToString("f", CultureInfo.CreateSpecificCulture("en-US")),
                price      = "Price : $ " + instance.Price,
                courseName = instance.Course.Name,
                location   = "Location : " + instance.Location.Street,
                seats      = "Seats : " + instance.Seats,
                instructor = "Instructor : " + instance.Instructor.FirstName + " " +
                instance.Instructor.LastName,
                book       = bookAvailible,
                bookP      = bookPrice,
                id         = instance.InstanceId
            });
        }

        //[Authorize(Roles = "Admin")]
        //// GET: Admin/Instances/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var instance = await _context.Instance
        //        .Include(i => i.Course)
        //        .Include(i => i.Location)
        //        .Include(i => i.Instructor)
        //        .FirstOrDefaultAsync(m => m.InstanceId == id);
        //    if (instance == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(instance);
        //}

        [Authorize(Roles = "Admin")]
        // GET: Admin/Instances/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "Name");
            ViewData["LocationId"] = new SelectList(_context.Location, "LocationId", "Street");
            ViewData["InstructorId"] = new SelectList(_context.Users.Where(e => e.Role == "Staff" || e.Role == "Admin"), "UserId", "FirstName");
            return View();
        }

        [Authorize(Roles = "Admin")]
        // POST: Admin/Instances/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InstanceId,StartDate,Price,CourseId,LocationId,Seats,InstructorId,BookAvailable,BookPrice")] Instance instance)
        {
            if (ModelState.IsValid)
            {
                _context.Add(instance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            instance.BookAvailable = true;
            instance.BookPrice = 0;

            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "Name", instance.CourseId);
            ViewData["LocationId"] = new SelectList(_context.Location, "LocationId", "Street", instance.LocationId);
            ViewData["InstructorId"] = new SelectList(_context.Users.Where(e => e.Role == "Staff" || e.Role == "Admin"), "UserId", "FirstName", instance.InstructorId);
            return View(instance);
        }

        [Authorize(Roles = "Admin")]
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
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "Name", instance.CourseId);
            ViewData["LocationId"] = new SelectList(_context.Location, "LocationId", "Street", instance.LocationId);
            ViewData["InstructorId"] = new SelectList(_context.Users.Where(e => e.Role == "Staff" || e.Role == "Admin"), "UserId", "FirstName", instance.InstructorId);
            return View(instance);
        }

        [Authorize(Roles = "Admin")]
        // POST: Admin/Instances/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InstanceId,StartDate,Price,CourseId,LocationId,Seats,InstructorId,Graded,BookAvailable,BookPrice")] Instance instance)
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
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "Name", instance.CourseId);
            ViewData["LocationId"] = new SelectList(_context.Location, "LocationId", "Street", instance.LocationId);
            ViewData["InstructorId"] = new SelectList(_context.Users.Where(e => e.Role == "Staff" || e.Role == "Admin"), "UserId", "FirstName", instance.InstructorId);
            return View(instance);
        }

        [Authorize(Roles = "Admin")]
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
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "Name", instance.CourseId);
            ViewData["LocationId"] = new SelectList(_context.Location, "LocationId", "Street", instance.LocationId);
            ViewData["InstructorId"] = new SelectList(_context.Users, "UserId", "FirstName", instance.InstructorId);
            return View(instance);
        }

        [Authorize(Roles = "Admin")]
        // POST: Admin/Instances/Delete/5
        //[HttpPost, ActionName("Delete")]
       // [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var instance = await _context.Instance.FindAsync(id);
            //Maybe we can also check if the instance is expired. If so, We can delete it 
            var used = await _context.Enrollment
               .Include(e => e.Instance)
               .FirstOrDefaultAsync(e => e.InstanceId == instance.InstanceId);
            if (used != null)
            {                
                return Json(new
                {
                    success = true,
                    message = "Cannot delete. Students are " +
                    "currently enrolled in this class"
            });
            }
            var deletedInstance = await _context.Instance
               .Include(i => i.Course)
               .Include(i => i.Location)
               .Include(i => i.Instructor)
               .FirstOrDefaultAsync(m => m.InstanceId == id);
            _context.Instance.Remove(instance);
            await _context.SaveChangesAsync();
            return Json(new
            {
                success = true,
                message = "Start Date : " + deletedInstance.StartDate + " " +
                "Price : " + deletedInstance.Price + " $ " +
                " Course Name : " + deletedInstance.Course.Name + " " +
                " Location : " + deletedInstance.Location.Street + " " +
                " Seats : " + deletedInstance.Seats + " " +
                " Instructor : " + deletedInstance.Instructor.FirstName + " " +
                deletedInstance.Instructor.LastName + " Has been deleted "

            });
        }

        // GET: Admin/Enrollments
        [Authorize(Roles = "Admin, Staff")]
        public async Task<IActionResult> Grade(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var instance = await _context.Instance
                .Include(c => c.Course)
                .Where(e => e.InstanceId == id)
                .FirstOrDefaultAsync();
            if (instance == null)
            {
                return NotFound();
            }
            var enrollments = await _context.Enrollment
                .Include(e => e.Instance)
                .Include(e => e.User)
                .Include(c => c.Instance.Course)
                .Include(c => c.Instance.Location)
                .Where(e => e.InstanceId == id)
                .OrderBy(e => e.User.FirstName)
                .ToListAsync();
            if (enrollments == null)
            {
                return NotFound();
            }
            ViewData["instance"] = instance.InstanceId;
            ViewData["class"] = instance.Course.Name;
            ViewData["location"] = instance.Location.Name;
            ViewData["date"] = instance.StartDate.Date;
            return View(enrollments);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Grade(int instanceId, IEnumerable<int> studentsPassed)
        {
            if(studentsPassed != null)
            {
                //grab all enrollments for the instance
                var enrollments = await _context.Enrollment
                .Where(e => e.InstanceId == instanceId)
                .ToListAsync();

                //cycle through enrollments, check if in studentsPassed, mark P or F
                foreach ( var e in enrollments)
                {
                    foreach( var s in studentsPassed)
                    {
                        if (e.UserId == s)
                        {
                            e.Status = 'P';
                            break;
                        }
                        else e.Status = 'F';
                    }
                    _context.Enrollment.Update(e);
                }

                //mark instance "graded"
                var instance = await _context.Instance.FindAsync(instanceId);
                instance.Graded = true;
                _context.Update(instance);

                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index", "Dashboard");
        }

        private bool InstanceExists(int id)
        {
            return _context.Instance.Any(e => e.InstanceId == id);
        }
    }
}
