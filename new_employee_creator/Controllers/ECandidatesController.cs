using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using new_employee_creator.Models;

namespace new_employee_creator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ECandidatesController : ControllerBase
    {
        private readonly EmployeeDBContext _context;

        public ECandidatesController(EmployeeDBContext context)
        {
            _context = context;
        }

        // GET: api/ECandidates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ECandidate>>> GetECandidates()
        {
            return await _context.ECandidates.ToListAsync();
        }

        // GET: api/ECandidates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ECandidate>> GetECandidate(int id)
        {
            var eCandidate = await _context.ECandidates.FindAsync(id);

            if (eCandidate == null)
            {
                return NotFound();
            }

            return eCandidate;
        }

        // PUT: api/ECandidates/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutECandidate(int id, ECandidate eCandidate)
        {
            if (id != eCandidate.Id)
            {
                return BadRequest();
            }

            _context.Entry(eCandidate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ECandidateExists(id))
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

        // POST: api/ECandidates
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ECandidate>> PostECandidate(ECandidate eCandidate)
        {
            _context.ECandidates.Add(eCandidate);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetECandidate", new { id = eCandidate.Id }, eCandidate);
        }

        // DELETE: api/ECandidates/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ECandidate>> DeleteECandidate(int id)
        {
            var eCandidate = await _context.ECandidates.FindAsync(id);
            if (eCandidate == null)
            {
                return NotFound();
            }

            _context.ECandidates.Remove(eCandidate);
            await _context.SaveChangesAsync();

            return eCandidate;
        }

        private bool ECandidateExists(int id)
        {
            return _context.ECandidates.Any(e => e.Id == id);
        }
    }
}
