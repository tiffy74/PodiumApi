using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Podium.API.Models;

namespace Podium.API.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CstomerDbContext _context;

        public CustomerController(CstomerDbContext context)
        {
            _context = context;
        }

        // GET: api/CustomerId
        [HttpGet]
        public IEnumerable<Customer> GetCustomerId()
        {
            return _context.Customer;
        }

        // GET: api/CustomerId/5
        [HttpGet("{CustomerId}")]
        public async Task<IActionResult> GetCustomerId([FromRoute] int CustomerId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Customer = await _context.Customer.FindAsync(CustomerId);

            if (Customer == null)
            {
                return NotFound();
            }

            return Ok(Customer);
        }

        
    }
}