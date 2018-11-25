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

                         }).ToAsyncEnumerable().OrderBy(i => i.InstanceId);


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

        [HttpGet("GetPrciceById/{id}")]
        public async Task<IActionResult> GetInstancePriceById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            double? price = null;
            var instance = await (from i in _context.Instance
                                  join c in _context.Course on i.CourseId equals c.CourseId
                                  join l in _context.Location on i.LocationId equals l.LocationId
                                  join t in _context.Users on i.InstructorId equals t.UserId
                                  where i.InstanceId == id
                                  select new InstancesDto
                                  {                                     
                                      Price = i.Price,                                   
                                  }).FirstAsync();
            price = instance.Price;
            if (instance == null)
            {
                return NotFound();
            }

            return Ok(price);
        }

        [HttpGet("GetInstanceByCourseId/{id}")]
        public async Task<IActionResult> GetInstanceByCourseId([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var instance = await (from i in _context.Instance
                                  join c in _context.Course on i.CourseId equals c.CourseId
                                  join l in _context.Location on i.LocationId equals l.LocationId
                                  join t in _context.Users on i.InstructorId equals t.UserId
                                  where i.CourseId == id
                                  select new InstancesDto
                                  {
                                      InstanceId = i.InstanceId,
                                      StartDateDOW = i.StartDate.DayOfWeek.ToString(),
                                      StartDateMonthF3 = i.StartDate.ToString("MMMM").Substring(0, 3),
                                      StartDateTime = i.StartDate.ToString("f", CultureInfo.CreateSpecificCulture("en-US")).Substring(i.StartDate.ToString("f", CultureInfo.CreateSpecificCulture("en-US")).Length - 8, 8),
                                      StartDateDay = i.StartDate.Day.ToString(),
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

            foreach(var item in instance)
            {
                var enrollment = await _context.Enrollment
                .Include(e => e.User)
                .Where(e => e.InstanceId == item.InstanceId)
                .ToListAsync();
                var studentCount = enrollment.Count();
                if(studentCount >= item.Seats)
                {
                    item.Full = true;
                }
                else
                {
                    item.Full = false;
                }
            }

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