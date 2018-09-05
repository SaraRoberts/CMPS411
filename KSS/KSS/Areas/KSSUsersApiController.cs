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
    [Route("api/KSSUser")]
    [ApiController]
    public class KSSUsersApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public KSSUsersApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/KSSUsersApi
        [HttpGet]
        public IEnumerable<KSSUser> GetKSSUsers()
        {
            return _context.KSSUsers;
        }

        // GET: api/KSSUsersApi/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetKSSUser([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var kSSUser = await _context.KSSUsers.FindAsync(id);

            if (kSSUser == null)
            {
                return NotFound();
            }

            return Ok(kSSUser);
        }

        // PUT: api/KSSUsersApi/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKSSUser([FromRoute] string id, [FromBody] KSSUser kSSUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kSSUser.Id)
            {
                return BadRequest();
            }

            _context.Entry(kSSUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KSSUserExists(id))
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

        // POST: api/KSSUsersApi
        [HttpPost]
        public async Task<IActionResult> PostKSSUser([FromBody] KSSUser kSSUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.KSSUsers.Add(kSSUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKSSUser", new { id = kSSUser.Id }, kSSUser);
        }

        // DELETE: api/KSSUsersApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKSSUser([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var kSSUser = await _context.KSSUsers.FindAsync(id);
            if (kSSUser == null)
            {
                return NotFound();
            }

            _context.KSSUsers.Remove(kSSUser);
            await _context.SaveChangesAsync();

            return Ok(kSSUser);
        }

        private bool KSSUserExists(string id)
        {
            return _context.KSSUsers.Any(e => e.Id == id);
        }
    }
}