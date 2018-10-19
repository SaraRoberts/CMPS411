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
using KSS.Areas.Admin.ViewModels;

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
            var dataContext = _context.Enrollment
                .Include(e => e.Instance)
                .Include(e => e.User)
                .Include(c => c.Instance.Course)
                .Include(c => c.Instance.Location);
            return View(await dataContext.ToListAsync());
        }

        // GET: Admin/Enrollments/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var enrollment = await _context.Enrollment
        //        .Include(e => e.Instance)
        //        .Include(e => e.User)
        //        .Include(c => c.Instance.Course)
        //        .Include(c => c.Instance.Location)
        //        .FirstOrDefaultAsync(m => m.EnrollmentId == id);
        //    if (enrollment == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(enrollment);
        //}

        [HttpPost]
        public async Task<ActionResult> Details(int? id)
        {
            string bookPaid = "Book Bought : Yes";
            string coursePaid   = "Course Paid : Yes";
            if (id == null)
            {
                return NotFound();
            }

            var enrollment = await _context.Enrollment
                .Include(e => e.Instance)
                .Include(e => e.User)
                .Include(c => c.Instance.Course)
                .Include(c => c.Instance.Location)
                .FirstOrDefaultAsync(m => m.EnrollmentId == id);
            if (enrollment == null)
            {
                return NotFound();
            }
            if (!enrollment.BookBought)
            {
                bookPaid = "Book Bought : No";
            }
            if (!enrollment.Paid)
            {
                coursePaid = "Course Paid : No";
            }
            

            return Json(new
            {
                success    = true,
                instance   = enrollment.Instance.Course.Name + " " + enrollment.Instance.Location.City + " " +
                enrollment.Instance.StartDate.LocalDateTime,
                fullName   = enrollment.User.FirstName + " " + enrollment.User.LastName,
                status     = enrollment.Status,
                bookBought = bookPaid,
                paid       = coursePaid,
                confirmed  = enrollment.Confirmed,
                enrollmentId = enrollment.EnrollmentId
            });
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
            ViewData["Location"] = instance.Location.Name;
            return View(enrollment);
        }

        // GET: Admin/Enrollments/Create
        public async Task<IActionResult> Create(int? id)
        {
            List<UserViewModel> userList = new List<UserViewModel>();
            List<UserViewModel> instanceList = new List<UserViewModel>();
            var users = _context.Users;
            var instances = _context.Instance.Include(i => i.Course).Include(i => i.Location);

            foreach (var name in users)
            {
                UserViewModel user = new UserViewModel();
                user.FirstName = name.LastName;
                user.LastName = name.FirstName;
                user.FullName = name.FirstName + " " + name.LastName;
                user.UserId = name.UserId;
                userList.Add(user);
            }

            foreach (var inst in instances)
            {
                UserViewModel location = new UserViewModel();
                location.CourseName = inst.Course.Name;
                location.City = inst.Location.City;
                var startDate = inst.StartDate.ToString();
                location.StartDate = startDate;
                location.InstanceId = inst.InstanceId;
                location.FullInstance = inst.Course.Name + "   " + inst.Location.City + "   " + inst.StartDate;
                instanceList.Add(location);

            }

            if (id == null)
            {                

                ViewData["InstanceId"] = new SelectList(instanceList, "InstanceId", "FullInstance");
                ViewData["UserId"] = new SelectList(userList, "UserId", "FullName");
                return View();
                //return NotFound();
            }

            var instance = await _context.Instance.FirstOrDefaultAsync(m => m.InstanceId == id);
            


            ViewData["InstanceId"] = new SelectList(instanceList, "InstanceId", "FullInstance", instance.InstanceId);
            ViewData["UserId"] = new SelectList(userList, "UserId", "FullName");
            return View();
        }

        // POST: Admin/Enrollments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EnrollmentId,InstanceId,UserId,BookBought,Paid")] Enrollment enrollment)
        {
            if (ModelState.IsValid)
            {
                var duplicate = await _context.Enrollment
                    .FirstOrDefaultAsync(e => e.InstanceId == enrollment.InstanceId && e.UserId == enrollment.UserId);

                if (duplicate == null)
                {
                    enrollment.Status = 'E';
                    _context.Add(enrollment);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }

                ViewData["Duplicate"] = "User already registered for this class.";
                ViewData["InstanceId"] = new SelectList(_context.Instance, "InstanceId", "InstanceId", enrollment.InstanceId);
                ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId", enrollment.UserId);
                return View(enrollment);
            }

            ViewData["InstanceId"] = new SelectList(_context.Instance, "InstanceId", "InstanceId", enrollment.InstanceId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId", enrollment.UserId);
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
        public async Task<IActionResult> Edit(int id, [Bind("EnrollmentId,InstanceId,UserId,Status,BookBought,Paid,Confirmed")] Enrollment enrollment)
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
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var enrollment = await _context.Enrollment.FindAsync(id);
            var enrollmentDelete = await _context.Enrollment //used to display the deleted information
               .Include(e => e.Instance)
               .Include(e => e.User)
               .Include(c => c.Instance.Course)
               .Include(c => c.Instance.Location)
               .FirstOrDefaultAsync(m => m.EnrollmentId == id);
            _context.Enrollment.Remove(enrollment);
            await _context.SaveChangesAsync();
            return Json(new
            {
                success = true,
               
                removed = enrollmentDelete.User.FirstName + " " + enrollmentDelete.User.LastName +" Was removed from "
                + enrollmentDelete.Instance.Course.Name + " " + enrollmentDelete.Instance.Location.City + " " +
                enrollmentDelete.Instance.StartDate.LocalDateTime 
                ,

            });
        }

        private bool EnrollmentExists(int id)
        {
            return _context.Enrollment.Any(e => e.EnrollmentId == id);
        }
    }
}
