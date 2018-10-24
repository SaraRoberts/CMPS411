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

namespace KSS.Areas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly DataContext _context;

        public CoursesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Courses
        //[HttpGet]
        //public IEnumerable<Course> GetCourse()
        //{
        //    return _context.Course;
        //}

        [HttpGet]
        public IActionResult GetCourse()
        {
            var query = (from c in _context.Course
                         join k in _context.Category on c.CategoryId equals k.CategoryId


                         select new CourseDto
                         {
                             CategoryId = c.CategoryId,
                             CourseId = c.CourseId,
                             Name = c.Name,
                             Description = c.Description,
                             TypicalPrice = c.TypicalPrice,
                             BookAvailable = c.BookAvailable,
                             PrereqId = c.PrereqId,
                             CategoryName = c.CourseCategory.Name,
                             PrereqName = c.Prereq.Name

                         }).ToList();

            return Ok(query);

        }

        // GET: api/Courses/5
        [HttpGet("{id}")]
    public async Task<IActionResult> GetCourse([FromRoute] int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

            var course =  await(from c in _context.Course
                         join k in _context.Category on c.CategoryId equals k.CategoryId
                         where c.CourseId == id


                         select new CourseDto
                         {
                             CategoryId = c.CategoryId,
                             CourseId = c.CourseId,
                             Name = c.Name,
                             Description = c.Description,
                             TypicalPrice = c.TypicalPrice,
                             BookAvailable = c.BookAvailable,
                             PrereqId = c.PrereqId,                            
                             CategoryName = c.CourseCategory.Name,
                             PrereqName = c.Prereq.Name

                         }).FirstOrDefaultAsync();

            if (course == null)
        {
            return NotFound();
        }

        return Ok(course);
    }
        [HttpGet("GetByCategory/{category}")]
        public async Task<IActionResult> GetCourseByCategory([FromRoute] string category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            category = category.ToUpper();

            if (!category.Equals("CPR") && !category.Equals("BLS") &&
                !category.Equals("AED") && !category.Equals("EMT"))
            {
                return NotFound();
            }

            var course = await (from c in _context.Course
                          join k in _context.Category on c.CategoryId equals k.CategoryId
                          where c.CourseCategory.Name == category


                          select new CourseDto
                          {
                              CategoryId = c.CategoryId,
                              CourseId = c.CourseId,
                              Name = c.Name,
                              Description = c.Description,
                              TypicalPrice = c.TypicalPrice,
                              BookAvailable = c.BookAvailable,
                              PrereqId = c.PrereqId,
                              CategoryName = c.CourseCategory.Name,
                              PrereqName = c.Prereq.Name

                          }).ToListAsync();

            if (course == null)
            {
                return NotFound();
            }

            return Ok(course);
        }
        //// PUT: api/Courses/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutCourse([FromRoute] int id, [FromBody] Course course)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != course.CourseId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(course).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CourseExists(id))
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

        //// POST: api/Courses
        //[HttpPost]
        //public async Task<IActionResult> PostCourse([FromBody] Course course)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _context.Course.Add(course);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetCourse", new { id = course.CourseId }, course);
        //}

        //// DELETE: api/Courses/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteCourse([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var course = await _context.Course.FindAsync(id);
        //    if (course == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Course.Remove(course);
        //    await _context.SaveChangesAsync();

        //    return Ok(course);
        //}

        private bool CourseExists(int id)
        {
            return _context.Course.Any(e => e.CourseId == id);
        }
    }
}