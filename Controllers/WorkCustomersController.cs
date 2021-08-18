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
    public class WorkCustomersController : ControllerBase
    {
        private readonly LumisourceContext _context;

        public WorkCustomersController(LumisourceContext context)
        {
            _context = context;
        }

        // GET: api/WorkCustomers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkCustomer>>> GetWorkCustomers()
        {
           // var x= _context.Grid1ResultSets.FromSqlRaw<Grid1ResultSet>("exec getSaleRevenueGrid").ToList();
            return await _context.WorkCustomers.ToListAsync();
        }
        [HttpGet]
        [Route("Grid1ResultSet")]
        public async Task<ActionResult<IEnumerable<Grid1ResultSet>>> GetWorkResultForGrid1()
        { 
            return await _context.Grid1ResultSets.FromSqlRaw<Grid1ResultSet>("exec getSaleRevenueGrid").ToListAsync();
        }
        [HttpGet]
        [Route("Grid2ResultSet")]
        public async Task<ActionResult<IEnumerable<ActivityDetail>>> GetWorkResultForGrid2()
        { 
            return await _context.ActivityDetails.FromSqlRaw<ActivityDetail>("exec getActivityDetail").ToListAsync();
        }

        /*  [HttpGet]
          public async Task<ActionResult<IEnumerable<Grid1ResultSet>>> GetWorkGridItems()
          {
            // return await _context.WorkCustomers.ToListAsync();

              return await _context.Grid1ResultSets.FromSqlRaw<Grid1ResultSet>("exec getSaleRevenueGrid").ToListAsync();
          }*/
        //getSaleRevenueGrid

        // GET: api/WorkCustomers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkCustomer>> GetWorkCustomer(int id)
        {
            var workCustomer = await _context.WorkCustomers.FindAsync(id);

            if (workCustomer == null)
            {
                return NotFound();
            }

            return workCustomer;
        }

        // PUT: api/WorkCustomers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkCustomer(int id, WorkCustomer workCustomer)
        {
            if (id != workCustomer.CustomerId)
            {
                return BadRequest();
            }

            _context.Entry(workCustomer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkCustomerExists(id))
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

        // POST: api/WorkCustomers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WorkCustomer>> PostWorkCustomer(WorkCustomer workCustomer)
        {
            _context.WorkCustomers.Add(workCustomer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWorkCustomer", new { id = workCustomer.CustomerId }, workCustomer);
        }

        // DELETE: api/WorkCustomers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkCustomer(int id)
        {
            var workCustomer = await _context.WorkCustomers.FindAsync(id);
            if (workCustomer == null)
            {
                return NotFound();
            }

            _context.WorkCustomers.Remove(workCustomer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WorkCustomerExists(int id)
        {
            return _context.WorkCustomers.Any(e => e.CustomerId == id);
        }
    }
}
