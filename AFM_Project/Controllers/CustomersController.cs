﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AFM_Project.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AFM_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly SeilernContext _context;

        public CustomersController(SeilernContext context)
        {
            _context = context;
        }

        //USER
        [HttpGet("{idMeta}")]
        public async Task<ActionResult<IEnumerable<Object>>> GetCustomerOfMeta(Guid idMeta)
        {
            return await _context.Customer
                .Select(c => new {
                    username = c.UserName,
                    portfolioname = c.AccountNick,
                    IdMetaCustomer = c.IdMetaCustomer.ToString()
                })
                .Where( m =>  m.IdMetaCustomer == idMeta.ToString())
                .ToListAsync();
        }

        //SUPERUSER
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Object>>> GetCustomer()
        {
             return await _context.Customer
                .Select(c => new {
                    username = c.UserName,
                    portfolioname = c.AccountNick,
                    IdMetaCustomer = c.IdMetaCustomer.ToString()
                })                
                .ToListAsync();
        }

        /*  

        // PUT: api/Customers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(Guid id, Customer customer)
        {
            if (id != customer.IdCustomer)
            {
                return BadRequest();
            }

            _context.Entry(customer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(id))
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

        // POST: api/Customers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
        {
            _context.Customer.Add(customer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomer", new { id = customer.IdCustomer }, customer);
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Customer>> DeleteCustomer(Guid id)
        {
            var customer = await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();

            return customer;
        }

        private bool CustomerExists(Guid id)
        {
            return _context.Customer.Any(e => e.IdCustomer == id);
        }
        */
    }
}
