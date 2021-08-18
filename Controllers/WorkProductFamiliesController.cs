using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LumiSourceApi.Models;

namespace LumiSourceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkProductFamiliesController : ControllerBase
    {
        private readonly LumisourceContext _context;

        public WorkProductFamiliesController(LumisourceContext context)
        {
            _context = context;
        }

        // GET: api/WorkProductFamilies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkProductFamily>>> GetWorkProductFamilies()
        {
            return await _context.WorkProductFamilies.ToListAsync();
        }

        // GET: api/WorkProductFamilies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkProductFamily>> GetWorkProductFamily(int id)
        {
            var workProductFamily = await _context.WorkProductFamilies.FindAsync(id);

            if (workProductFamily == null)
            {
                return NotFound();
            }

            return workProductFamily;
        }

        // PUT: api/WorkProductFamilies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkProductFamily(int id, WorkProductFamily workProductFamily)
        {
            if (id != workProductFamily.Id)
            {
                return BadRequest();
            }

            _context.Entry(workProductFamily).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkProductFamilyExists(id))
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

        // POST: api/WorkProductFamilies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WorkProductFamily>> PostWorkProductFamily(WorkProductFamily workProductFamily)
        {
            _context.WorkProductFamilies.Add(workProductFamily);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWorkProductFamily", new { id = workProductFamily.Id }, workProductFamily);
        }

        // DELETE: api/WorkProductFamilies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkProductFamily(int id)
        {
            var workProductFamily = await _context.WorkProductFamilies.FindAsync(id);
            if (workProductFamily == null)
            {
                return NotFound();
            }

            _context.WorkProductFamilies.Remove(workProductFamily);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WorkProductFamilyExists(int id)
        {
            return _context.WorkProductFamilies.Any(e => e.Id == id);
        }
    }
}
