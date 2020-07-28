using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AFM_Project.Models;
using Microsoft.AspNetCore.Http.Connections;

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

        [HttpGet("getUserPortfolioStat/{id_meta}")]
        public async Task<ActionResult<IEnumerable<Object>>> getPortfolioStat(Guid id_meta)
        {
            return await _context.TradedOrders
                // si besoin des information de NewTrade :
                .Join(_context.NewTrade, t => t.IdNtslmc, nt => nt.IdNewtrade, 
                    (t, nt) => new { t.TradedDate, t.Sell, t.ExecutedSaving, t.DaySinceCreation, t.IdCustomer, t.StopLoss
                ,nt.Dividend})
                .Join(_context.Sp500, a=> a.Sell, sp => sp.Symbol,
                    (a, sp) => new {a, sp.GicsSector})
                .Join(_context.Customer, b=> b.a.IdCustomer, cus => cus.IdCustomer,
                    (b,cus) => new {b, cus.IdCustomer, cus.IdMetaCustomer})
                .Where(c => c.IdMetaCustomer == id_meta)
                .Select(data => new
                {
                    data.b.a.IdCustomer,
                    data.b.a.ExecutedSaving,
                    data.b.a.Sell,
                    data.b.a.StopLoss,
                    data.b.a.TradedDate,
                    data.b.a.DaySinceCreation,
                    data.b.GicsSector
                })
                .ToListAsync();         
        }


        private bool NewTradeExists(Guid id)
        {
            return _context.NewTrade.Any(e => e.IdNewtrade == id);
        }
    }
}
