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
    public class LendersController : ControllerBase
    {
        private readonly LenderDbContext _context;

        public LendersController(LenderDbContext context)
        {
            _context = context;
        }

        // GET: api/Lenders
        [HttpGet]
        public IEnumerable<Lender> GetLender()
        {
            return _context.Lender;
        }

        // GET: api/Lenders/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLender([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var lender = await _context.Lender.FindAsync(id);

            if (lender == null)
            {
                return NotFound();
            }

            return Ok(lender);
        }

        // PUT: api/Lenders/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLender([FromRoute] int id, [FromBody] Lender lender)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != lender.Id)
            {
                return BadRequest();
            }

            _context.Entry(lender).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LenderExists(id))
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

        // POST: api/Lenders
        [HttpPost]
        public async Task<IActionResult> PostLender([FromBody] Lender lender)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Lender.Add(lender);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLender", new { id = lender.Id }, lender);
        }

        // DELETE: api/Lenders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLender([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var lender = await _context.Lender.FindAsync(id);
            if (lender == null)
            {
                return NotFound();
            }

            _context.Lender.Remove(lender);
            await _context.SaveChangesAsync();

            return Ok(lender);
        }

        private bool LenderExists(int id)
        {
            return _context.Lender.Any(e => e.Id == id);
        }
    }
}