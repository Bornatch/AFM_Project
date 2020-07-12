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
    public class ClaimUsersController : ControllerBase
    {
        private readonly SeilernContext _context;

        public ClaimUsersController(SeilernContext context)
        {
            _context = context;
        }

        // GET: api/ClaimUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClaimUser>>> GetClaimUser()
        {
            return await _context.ClaimUser.ToListAsync();
        }

        // GET: api/ClaimUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClaimUser>> GetClaimUser(Guid id)
        {
            var claimUser = await _context.ClaimUser.FindAsync(id);

            if (claimUser == null)
            {
                return NotFound();
            }

            return claimUser;
        }

        // PUT: api/ClaimUsers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClaimUser(Guid id, ClaimUser claimUser)
        {
            if (id != claimUser.ClaimId)
            {
                return BadRequest();
            }

            _context.Entry(claimUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClaimUserExists(id))
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

        // POST: api/ClaimUsers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ClaimUser>> PostClaimUser(ClaimUser claimUser)
        {
            _context.ClaimUser.Add(claimUser);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ClaimUserExists(claimUser.ClaimId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetClaimUser", new { id = claimUser.ClaimId }, claimUser);
        }

        // DELETE: api/ClaimUsers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ClaimUser>> DeleteClaimUser(Guid id)
        {
            var claimUser = await _context.ClaimUser.FindAsync(id);
            if (claimUser == null)
            {
                return NotFound();
            }

            _context.ClaimUser.Remove(claimUser);
            await _context.SaveChangesAsync();

            return claimUser;
        }

        private bool ClaimUserExists(Guid id)
        {
            return _context.ClaimUser.Any(e => e.ClaimId == id);
        }
    }
}
