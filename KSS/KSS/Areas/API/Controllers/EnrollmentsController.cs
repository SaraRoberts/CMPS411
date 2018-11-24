using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KSS.Areas.Admin.Data;
using KSS.Areas.Admin.Models;
using KSS.Areas.API.Models;
using System.Globalization;
using System.Net;

namespace KSS.Areas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentsController : ControllerBase
    {
        private readonly DataContext _context;

        public EnrollmentsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Enrollments

        [HttpGet("{userId}")]
        public async Task <IActionResult> GetEnrollment([FromRoute] int userId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var enrollment = await (from e in _context.Enrollment
                              join i in _context.Instance on e.InstanceId equals i.InstanceId
                              join u in _context.Users on e.UserId  equals u.UserId
                              join c in _context.Course on e.Instance.Course.CourseId equals c.CourseId
                              join l in _context.Location on e.Instance.Location.LocationId equals l.LocationId
                              where e.UserId == userId && e.Instance.StartDate > DateTime.UtcNow

                                    select new EnrollmentsDto
                              {
                                  EnrollmentId = e.EnrollmentId,
                                  InstanceId = e.InstanceId,
                                  InstanceStartDateDOW = e.Instance.StartDate.DayOfWeek.ToString(),
                                  InstanceStartDateMonthF3 = e.Instance.StartDate.ToString("MMMM").Substring(0,3),
                                  InstanceStartDateTime = e.Instance.StartDate.ToString("f", CultureInfo.CreateSpecificCulture("en-US")).Substring(e.Instance.StartDate.ToString("f", CultureInfo.CreateSpecificCulture("en-US")).Length-8,8),
                                  InstanceStartDateDay = e.Instance.StartDate.Day.ToString(),
                                  UserId = e.UserId,
                                  UserName = e.User.FirstName + " "+ e.User.LastName,
                                  CourseName = e.Instance.Course.Name,
                                  CategoryName = e.Instance.Course.CourseCategory.Name,
                                  LocationName = i.Location.Name,
                                  LocationStreet = i.Location.Street,
                                  LocationCity = i.Location.City,
                                  LocationState = i.Location.State,
                                  LocationZip = i.Location.Zipcode,
                                  Status = e.Status,
                                  BookBought = e.BookBought,
                                  Paid = e.Paid,
                                  Confirmed = e.Confirmed

                              }).ToListAsync();
            if (enrollment == null)
            {
                return NotFound();
            }

            return Ok(enrollment);

        }

        [HttpGet("{userId},{instanceId}")]
        public async Task<IActionResult> GetEnrollment([FromRoute] int userId, int instanceId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var enrollment = await (from e in _context.Enrollment
                                    join i in _context.Instance on e.InstanceId equals i.InstanceId
                                    join u in _context.Users on e.UserId equals u.UserId
                                    join c in _context.Course on e.Instance.Course.CourseId equals c.CourseId
                                    join l in _context.Location on e.Instance.Location.LocationId equals l.LocationId
                                    where e.UserId == userId && e.InstanceId == instanceId

                                    select new EnrollmentsDto
                                    {
                                        EnrollmentId = e.EnrollmentId,
                                        InstanceId = e.InstanceId,
                                        UserId = e.UserId,
                                        UserName = e.User.FirstName + " " + e.User.LastName,
                                        CourseName = e.Instance.Course.Name,
                                        CategoryName = e.Instance.Course.CourseCategory.Name,
                                        LocationName = i.Location.Name,
                                        LocationStreet = i.Location.Street,
                                        LocationCity = i.Location.City,
                                        LocationState = i.Location.State,
                                        LocationZip = i.Location.Zipcode,
                                        Status = e.Status,
                                        BookBought = e.BookBought,
                                        Paid = e.Paid,
                                        Confirmed = e.Confirmed

                                    }).ToListAsync();

            if (enrollment == null)
            {
                return NotFound();
            }

            return Ok(enrollment);

        }

        [Route("Enrollment")]
        [HttpPost]
        public async Task<IActionResult> AddEnrollment([FromBody] EnrollDto enrollDto)
        {
            var duplicate = await _context.Enrollment
                   .FirstOrDefaultAsync(e => e.InstanceId == enrollDto.InstanceId && e.UserId == enrollDto.UserId);
            var numStudents = _context.Enrollment
                       .Count(e => e.InstanceId.Equals(enrollDto.InstanceId));
            var instance = await _context.Instance.FirstOrDefaultAsync(e => e.InstanceId.Equals(enrollDto.InstanceId));
            if (numStudents >= instance.Seats)
            {
                return StatusCode(422,"Classes are full cannot enroll");
            }

            if (duplicate == null)
            {
                var enrollment = _context.Enrollment;
                enrollment.Add(new Enrollment()
                {
                    InstanceId = enrollDto.InstanceId,
                    UserId = enrollDto.UserId,
                    BookBought = enrollDto.BookBought,
                    Status = 'E',
                    Paid = enrollDto.Paid,

                });
                
                await _context.SaveChangesAsync();
                return Ok();
            }
            else
            {
                return NotFound();
            }
            
        }
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutEnrollment([FromRoute] int id, [FromBody] Enrollment enrollment)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != enrollment.EnrollmentId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(enrollment).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!EnrollmentExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Enrollments
        //[HttpPost]
        //public async Task<IActionResult> PostEnrollment([FromBody] Enrollment enrollment)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _context.Enrollment.Add(enrollment);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetEnrollment", new { id = enrollment.EnrollmentId }, enrollment);
        //}

        //// DELETE: api/Enrollments/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteEnrollment([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var enrollment = await _context.Enrollment.FindAsync(id);
        //    if (enrollment == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Enrollment.Remove(enrollment);
        //    await _context.SaveChangesAsync();

        //    return Ok(enrollment);
        //}

        private bool EnrollmentExists(int id)
        {
            return _context.Enrollment.Any(e => e.EnrollmentId == id);
        }
    }
}