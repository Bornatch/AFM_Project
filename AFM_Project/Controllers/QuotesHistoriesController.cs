using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AFM_Project.Models;
using Microsoft.AspNetCore.Authorization;

namespace AFM_Project.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesHistoriesController : ControllerBase
    {
        private readonly SeilernContext _context;

        public QuotesHistoriesController(SeilernContext context)
        {
            _context = context;
        }

        // GET: api/QuotesHistories using for distinct securities
        [HttpGet]
        //[Authorize]
        public async Task<ActionResult<IEnumerable<String>>> GetQuotesHistory()
        {
            //return await _context.QuotesHistory.ToListAsync();
            return await _context.QuotesHistory.Select(s => s.Security).Distinct().ToListAsync();
        }


        // GET: api/QuotesHistories/AMZN
        //[Authorize]
        [HttpGet("{security}")]        
        public async Task<ActionResult<IEnumerable<QuotesHistory>>> GetSecurityQuotesHistory(String security)
        {
            return await _context.QuotesHistory
                .Where(s => s.Security == security)
                .OrderBy(s => s.QuoteDateTime)
                .ToListAsync();
        }

        /*

        // GET: api/QuotesHistories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<QuotesHistory>> GetQuotesHistory(int id)
        {
            var quotesHistory = await _context.QuotesHistory.FindAsync(id);

            if (quotesHistory == null)
            {
                return NotFound();
            }

            return quotesHistory;
        }
        

        // PUT: api/QuotesHistories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuotesHistory(int id, QuotesHistory quotesHistory)
        {
            if (id != quotesHistory.Id)
            {
                return BadRequest();
            }

            _context.Entry(quotesHistory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuotesHistoryExists(id))
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

        // POST: api/QuotesHistories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<QuotesHistory>> PostQuotesHistory(QuotesHistory quotesHistory)
        {
            _context.QuotesHistory.Add(quotesHistory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuotesHistory", new { id = quotesHistory.Id }, quotesHistory);
        }

        // DELETE: api/QuotesHistories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<QuotesHistory>> DeleteQuotesHistory(int id)
        {
            var quotesHistory = await _context.QuotesHistory.FindAsync(id);
            if (quotesHistory == null)
            {
                return NotFound();
            }

            _context.QuotesHistory.Remove(quotesHistory);
            await _context.SaveChangesAsync();

            return quotesHistory;
        }

        private bool QuotesHistoryExists(int id)
        {
            return _context.QuotesHistory.Any(e => e.Id == id);
        }
        */

    }
}
