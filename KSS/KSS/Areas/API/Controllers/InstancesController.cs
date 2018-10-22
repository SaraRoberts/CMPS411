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
                             StartDate = i.StartDate,
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
                             InstructorName = i.Instructor.FirstName + " " + i.Instructor.LastName,
                             CourseCategory = i.Course.CourseCategory.Name

                         }).ToList().OrderBy(i => i.InstanceId);


            return Ok(query);

        }

        // GET: api/Instances/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetInstance([FromRoute] int id)
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
                             StartDate = i.StartDate,
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
                             InstructorName = i.Instructor.FirstName + " " + i.Instructor.LastName,
                             CourseCategory = i.Course.CourseCategory.Name

                         }).FirstAsync();

            if (instance == null)
            {
                return NotFound();
            }

            return Ok(instance);
        }

        // PUT: api/Instances/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInstance([FromRoute] int id, [FromBody] Instance instance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != instance.InstanceId)
            {
                return BadRequest();
            }

            _context.Entry(instance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InstanceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Instances
        [HttpPost]
        public async Task<IActionResult> PostInstance([FromBody] Instance instance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Instance.Add(instance);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInstance", new { id = instance.InstanceId }, instance);
        }

        // DELETE: api/Instances/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInstance([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var instance = await _context.Instance.FindAsync(id);
            if (instance == null)
            {
                return NotFound();
            }

            _context.Instance.Remove(instance);
            await _context.SaveChangesAsync();

            return Ok(instance);
        }

        private bool InstanceExists(int id)
        {
            return _context.Instance.Any(e => e.InstanceId == id);
        }
    }
}