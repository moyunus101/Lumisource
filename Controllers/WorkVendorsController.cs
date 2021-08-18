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
    public class WorkVendorsController : ControllerBase
    {
        private readonly LumisourceContext _context;

        public WorkVendorsController(LumisourceContext context)
        {
            _context = context;
        }

        // GET: api/WorkVendors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkVendor>>> GetWorkVendors()
        {
            return await _context.WorkVendors.ToListAsync();
        }

        // GET: api/WorkVendors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkVendor>> GetWorkVendor(int id)
        {
            var workVendor = await _context.WorkVendors.FindAsync(id);

            if (workVendor == null)
            {
                return NotFound();
            }

            return workVendor;
        }

        // PUT: api/WorkVendors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkVendor(int id, WorkVendor workVendor)
        {
            if (id != workVendor.VendorId)
            {
                return BadRequest();
            }

            _context.Entry(workVendor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkVendorExists(id))
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

        // POST: api/WorkVendors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WorkVendor>> PostWorkVendor(WorkVendor workVendor)
        {
            _context.WorkVendors.Add(workVendor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWorkVendor", new { id = workVendor.VendorId }, workVendor);
        }

        // DELETE: api/WorkVendors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkVendor(int id)
        {
            var workVendor = await _context.WorkVendors.FindAsync(id);
            if (workVendor == null)
            {
                return NotFound();
            }

            _context.WorkVendors.Remove(workVendor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WorkVendorExists(int id)
        {
            return _context.WorkVendors.Any(e => e.VendorId == id);
        }
    }
}
