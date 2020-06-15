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
    public class NewTradesController : ControllerBase
    {
        private readonly SeilernContext _context;

        public NewTradesController(SeilernContext context)
        {
            _context = context;
        }

        // GET: api/NewTrades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NewTrade>>> GetNewTrade()
        {
            return await _context.NewTrade.ToListAsync();
        }

        // GET: api/NewTrades/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NewTrade>> GetNewTrade(Guid id)
        {
            var newTrade = await _context.NewTrade.FindAsync(id);

            if (newTrade == null)
            {
                return NotFound();
            }

            return newTrade;
        }

        // PUT: api/NewTrades/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNewTrade(Guid id, NewTrade newTrade)
        {
            if (id != newTrade.IdNewtrade)
            {
                return BadRequest();
            }

            _context.Entry(newTrade).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NewTradeExists(id))
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

        // POST: api/NewTrades
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<NewTrade>> PostNewTrade(NewTrade newTrade)
        {
            _context.NewTrade.Add(newTrade);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (NewTradeExists(newTrade.IdNewtrade))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetNewTrade", new { id = newTrade.IdNewtrade }, newTrade);
        }

        // DELETE: api/NewTrades/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<NewTrade>> DeleteNewTrade(Guid id)
        {
            var newTrade = await _context.NewTrade.FindAsync(id);
            if (newTrade == null)
            {
                return NotFound();
            }

            _context.NewTrade.Remove(newTrade);
            await _context.SaveChangesAsync();

            return newTrade;
        }

        private bool NewTradeExists(Guid id)
        {
            return _context.NewTrade.Any(e => e.IdNewtrade == id);
        }
    }
}
