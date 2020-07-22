using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AFM_Project.Models;

namespace AFM_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EodindexesController : ControllerBase
    {
        private readonly SeilernContext _context;

        public EodindexesController(SeilernContext context)
        {
            _context = context;
        }

        // GET: api/Eodindexes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eodindexes>>> GetEodindexes()
        {
            return await _context.Eodindexes.ToListAsync();
        }

        // GET: api/Eodindexes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eodindexes>> GetEodindexes(int id)
        {
            var eodindexes = await _context.Eodindexes.FindAsync(id);

            if (eodindexes == null)
            {
                return NotFound();
            }

            return eodindexes;
        }

        // PUT: api/Eodindexes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEodindexes(int id, Eodindexes eodindexes)
        {
            if (id != eodindexes.Id)
            {
                return BadRequest();
            }

            _context.Entry(eodindexes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EodindexesExists(id))
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

        // POST: api/Eodindexes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Eodindexes>> PostEodindexes(Eodindexes eodindexes)
        {
            _context.Eodindexes.Add(eodindexes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEodindexes", new { id = eodindexes.Id }, eodindexes);
        }

        // DELETE: api/Eodindexes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Eodindexes>> DeleteEodindexes(int id)
        {
            var eodindexes = await _context.Eodindexes.FindAsync(id);
            if (eodindexes == null)
            {
                return NotFound();
            }

            _context.Eodindexes.Remove(eodindexes);
            await _context.SaveChangesAsync();

            return eodindexes;
        }

        private bool EodindexesExists(int id)
        {
            return _context.Eodindexes.Any(e => e.Id == id);
        }
    }
}
