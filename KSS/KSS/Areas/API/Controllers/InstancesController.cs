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

namespace KSS.Areas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstancesController : ControllerBase
    {
        private readonly DataContext _context;

        public InstancesController(DataContext context)
        {
            _context = context;
        }
        /// <summary>
        /// this method is for fetching every instance.   
        /// </summary>
        /// <returns> InstancesDto list </returns>
        [HttpGet]
        public IActionResult GetInstance()
        {

            var query = (from i in _context.Instance
                         join c in _context.Course on i.CourseId equals c.CourseId
                         join l in _context.Location on i.LocationId equals l.LocationId
                         join t in _context.Users on i.InstructorId equals t.UserId
                         select new InstancesDto
                         {
                             InstanceId = i.InstanceId,
                             StartDate = i.StartDate.ToString("f",CultureInfo.CreateSpecificCulture("en-US")),
                             Price = i.Price,
                             Graded = i.Graded,
                             CourseId = i.CourseId,
                             LocationId = i.LocationId,
                             Seats = i.Seats,
                             InstructorId = i.InstructorId,
                             BookAvailable = i.BookAvailable,
                             BookPrice = i.BookPrice,
                             CourseName = i.Course.Name,
                             LocationName = i.Location.Name,
                             LocationStreet = i.Location.Street,
                             LocationCity = i.Location.City,
                             LocationState = i.Location.State,
                             LocationZip = i.Location.Zipcode,
                             InstructorName = i.Instructor.FirstName + " " + i.Instructor.LastName,
                             CourseCategory = i.Course.CourseCategory.Name

                         }).ToList().OrderBy(i => i.InstanceId);


            return Ok(query);

        }

        // GET: api/Instances/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetInstanceById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var instance = await (from i in _context.Instance
                         join c in _context.Course on i.CourseId equals c.CourseId
                         join l in _context.Location on i.LocationId equals l.LocationId                         
                         join t in _context.Users on i.InstructorId equals t.UserId
                         where i.InstanceId == id
                         select new InstancesDto
                         {
                             InstanceId = i.InstanceId,
                             StartDate = i.StartDate.ToString("f",CultureInfo.CreateSpecificCulture("en-US")),
                             Price = i.Price,
                             Graded = i.Graded,
                             CourseId = i.CourseId,
                             LocationId = i.LocationId,
                             Seats = i.Seats,
                             InstructorId = i.InstructorId,
                             BookAvailable = i.BookAvailable,
                             BookPrice = i.BookPrice,
                             CourseName = i.Course.Name,
                             LocationName = i.Location.Name,
                             LocationStreet = i.Location.Street,
                             LocationCity = i.Location.City,
                             LocationState = i.Location.State,
                             LocationZip = i.Location.Zipcode,
                             InstructorName = i.Instructor.FirstName + " " + i.Instructor.LastName,
                             CourseCategory = i.Course.CourseCategory.Name

                         }).FirstAsync();

            if (instance == null)
            {
                return NotFound();
            }

            return Ok(instance);
        }      
        [HttpGet("GetByCategory/{category}")]
        public async Task<IActionResult> GetInstanceByCategory([FromRoute] string category)
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

            var instance = await (from i in _context.Instance
                                  join c in _context.Course on i.CourseId equals c.CourseId
                                  join l in _context.Location on i.LocationId equals l.LocationId
                                  join t in _context.Users on i.InstructorId equals t.UserId
                                  where i.Course.CourseCategory.Name == category
                                  select new InstancesDto
                                  {
                                      InstanceId = i.InstanceId,
                                      StartDate = i.StartDate.ToString("f",
                  CultureInfo.CreateSpecificCulture("en-US")),
                                      Price = i.Price,
                                      Graded = i.Graded,
                                      CourseId = i.CourseId,
                                      LocationId = i.LocationId,
                                      Seats = i.Seats,
                                      InstructorId = i.InstructorId,
                                      BookAvailable = i.BookAvailable,
                                      BookPrice = i.BookPrice,
                                      CourseName = i.Course.Name,
                                      LocationName = i.Location.Name,
                                      LocationStreet = i.Location.Street,
                                      LocationCity = i.Location.City,
                                      LocationState = i.Location.State,
                                      LocationZip = i.Location.Zipcode,
                                      InstructorName = i.Instructor.FirstName + " " + i.Instructor.LastName,
                                      CourseCategory = i.Course.CourseCategory.Name

                                  }).ToListAsync();

            if (instance == null)
            {
                return NotFound();
            }

            return Ok(instance);
        }

      

        private bool InstanceExists(int id)
        {
            return _context.Instance.Any(e => e.InstanceId == id);
        }
    }
}