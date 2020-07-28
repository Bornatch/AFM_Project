using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AFM_Project.Models;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.AspNetCore.SignalR;

namespace AFM_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EoddatasController : ControllerBase
    {
        private readonly SeilernContext _context;

        public EoddatasController(SeilernContext context)
        {
            _context = context;
        }

        // GET: api/Eoddatas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eoddata>>> GetEoddata()
        {
            return await _context.Eoddata.ToListAsync();
        }        

        // GET: api/Eoddatas
        [HttpGet("getUserPortfolioPerf/{id_meta}")]
        public async Task<ActionResult<IEnumerable<Object>>> getPortfolioPerf(Guid id_meta)
        {
            
            //return await _context.Eoddata.ToListAsync();
            return await _context.Eoddata
                .Join(
                    _context.Customer                    
                    .Where(cus => cus.IdMetaCustomer == id_meta),                    
                    eodData => eodData.IdCustomer,
                    customer => customer.IdCustomer,
                    (eodData, customer) => new { 
                        portfolioName = customer.AccountNick,
                        dateStamp = eodData.DateStamp,
                        value = eodData.Portfolio
                    })                
                .ToListAsync();
        }

        // GET: api/Eoddatas
        [HttpGet("getUserPortfolioPerf/{id_meta}/portfolios")]
        public async Task<ActionResult<IEnumerable<Object>>> getPortfoliosName(Guid id_meta)
        {
            //return await _context.Eoddata.ToListAsync();
            return await _context.Eoddata
                .Join(
                    _context.Customer
                    .Where(cus => cus.IdMetaCustomer == id_meta),
                    eodData => eodData.IdCustomer,
                    customer => customer.IdCustomer,
                    (eodData, customer) => new {
                        portfolioName = customer.AccountNick,
                        dateStamp = eodData.DateStamp,
                        value = eodData.Portfolio
                    })
                .ToListAsync();
        }


        // GET: api/Eoddatas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eoddata>> GetEoddata(int id)
        {
            var eoddata = await _context.Eoddata.FindAsync(id);

            if (eoddata == null)
            {
                return NotFound();
            }

            return eoddata;
        }

        private bool EoddataExists(int id)
        {
            return _context.Eoddata.Any(e => e.Id == id);
        }
    }
}
