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
    public class WorkProductStylesController : ControllerBase
    {
        private readonly LumisourceContext _context;

        public WorkProductStylesController(LumisourceContext context)
        {
            _context = context;
        }

        // GET: api/WorkProductStyles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkProductStyle>>> GetWorkProductStyles()
        {
            return await _context.WorkProductStyles.ToListAsync();
        }

        // GET: api/WorkProductStyles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkProductStyle>> GetWorkProductStyle(int id)
        {
            var workProductStyle = await _context.WorkProductStyles.FindAsync(id);

            if (workProductStyle == null)
            {
                return NotFound();
            }

            return workProductStyle;
        }

        // PUT: api/WorkProductStyles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkProductStyle(int id, WorkProductStyle workProductStyle)
        {
            if (id != workProductStyle.Id)
            {
                return BadRequest();
            }

            _context.Entry(workProductStyle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkProductStyleExists(id))
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

        // POST: api/WorkProductStyles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WorkProductStyle>> PostWorkProductStyle(WorkProductStyle workProductStyle)
        {
            _context.WorkProductStyles.Add(workProductStyle);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWorkProductStyle", new { id = workProductStyle.Id }, workProductStyle);
        }

        // DELETE: api/WorkProductStyles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkProductStyle(int id)
        {
            var workProductStyle = await _context.WorkProductStyles.FindAsync(id);
            if (workProductStyle == null)
            {
                return NotFound();
            }

            _context.WorkProductStyles.Remove(workProductStyle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WorkProductStyleExists(int id)
        {
            return _context.WorkProductStyles.Any(e => e.Id == id);
        }
    }
}
