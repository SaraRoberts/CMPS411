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
    [Route("api/Instance")]
    [ApiController]
    public class InstancesApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public InstancesApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/InstanceApi
        [HttpGet]
        public IEnumerable<Instance> GetInstance()
        {
            return _context.Instance
                .Include(e => e.Course);
        }

        // GET: api/InstanceApi/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetInstance([FromRoute] int id)
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

            return Ok(instance);
        }

        // PUT: api/InstanceApi/5
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

        // POST: api/InstanceApi
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

        // DELETE: api/InstanceApi/5
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