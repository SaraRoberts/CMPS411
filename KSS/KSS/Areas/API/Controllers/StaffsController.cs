using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KSS.Areas.Admin.Data;
using KSS.Areas.Admin.Models;

namespace KSS.Areas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffsController : ControllerBase
    {
        private readonly DataContext _context;

        public StaffsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Staffs
        [HttpGet]
        public IEnumerable<StaffBio> GetStaff()
        {
            return _context.Bio;
        }

        // GET: api/Staffs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStaff([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var staff = await _context.Bio.FindAsync(id);

            if (staff == null)
            {
                return NotFound();
            }

            return Ok(staff);
        }

        //// PUT: api/Staffs/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutStaff([FromRoute] int id, [FromBody] Staff staff)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != staff.StaffId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(staff).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!StaffExists(id))
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

        //// POST: api/Staffs
        //[HttpPost]
        //public async Task<IActionResult> PostStaff([FromBody] Staff staff)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _context.Staff.Add(staff);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetStaff", new { id = staff.StaffId }, staff);
        //}

        //// DELETE: api/Staffs/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteStaff([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var staff = await _context.Staff.FindAsync(id);
        //    if (staff == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Staff.Remove(staff);
        //    await _context.SaveChangesAsync();

        //    return Ok(staff);
        //}

        //private bool StaffExists(int id)
        //{
        //    return _context.Bio.Any(e => e.StaffId == id);
        //}
    }
}