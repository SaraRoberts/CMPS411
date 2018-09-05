using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KSS.Data;
using KSS.Models;

namespace KSS.Areas
{
    [Route("api/Enrollment")]
    [ApiController]
    public class EnrollmentApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EnrollmentApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/EnrollmentApi
        [HttpGet]
        public IEnumerable<Enrollment> GetEnrollment()
        {
            return _context.Enrollment;
        }

        // GET: api/EnrollmentApi/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEnrollment([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var enrollment = await _context.Enrollment.FindAsync(id);

            if (enrollment == null)
            {
                return NotFound();
            }

            return Ok(enrollment);
        }

        // PUT: api/EnrollmentApi/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEnrollment([FromRoute] int id, [FromBody] Enrollment enrollment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != enrollment.EnrollmentId)
            {
                return BadRequest();
            }

            _context.Entry(enrollment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnrollmentExists(id))
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

        // POST: api/EnrollmentApi
        [HttpPost]
        public async Task<IActionResult> PostEnrollment([FromBody] Enrollment enrollment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Enrollment.Add(enrollment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEnrollment", new { id = enrollment.EnrollmentId }, enrollment);
        }

        // DELETE: api/EnrollmentApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEnrollment([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var enrollment = await _context.Enrollment.FindAsync(id);
            if (enrollment == null)
            {
                return NotFound();
            }

            _context.Enrollment.Remove(enrollment);
            await _context.SaveChangesAsync();

            return Ok(enrollment);
        }

        private bool EnrollmentExists(int id)
        {
            return _context.Enrollment.Any(e => e.EnrollmentId == id);
        }
    }
}