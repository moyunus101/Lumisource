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
    public class WorkProductLinesController : ControllerBase
    {
        private readonly LumisourceContext _context;

        public WorkProductLinesController(LumisourceContext context)
        {
            _context = context;
        }

        // GET: api/WorkProductLines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkProductLine>>> GetWorkProductLines()
        {
            return await _context.WorkProductLines.ToListAsync();
        }

        // GET: api/WorkProductLines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkProductLine>> GetWorkProductLine(int id)
        {
            var workProductLine = await _context.WorkProductLines.FindAsync(id);

            if (workProductLine == null)
            {
                return NotFound();
            }

            return workProductLine;
        }

        // PUT: api/WorkProductLines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkProductLine(int id, WorkProductLine workProductLine)
        {
            if (id != workProductLine.Id)
            {
                return BadRequest();
            }

            _context.Entry(workProductLine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkProductLineExists(id))
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

        // POST: api/WorkProductLines
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WorkProductLine>> PostWorkProductLine(WorkProductLine workProductLine)
        {
            _context.WorkProductLines.Add(workProductLine);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWorkProductLine", new { id = workProductLine.Id }, workProductLine);
        }

        // DELETE: api/WorkProductLines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkProductLine(int id)
        {
            var workProductLine = await _context.WorkProductLines.FindAsync(id);
            if (workProductLine == null)
            {
                return NotFound();
            }

            _context.WorkProductLines.Remove(workProductLine);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WorkProductLineExists(int id)
        {
            return _context.WorkProductLines.Any(e => e.Id == id);
        }
    }
}
