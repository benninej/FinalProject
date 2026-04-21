using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace FinalProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SportsController : ControllerBase
    {
        private readonly DefultContext _context;
        public SportsController(DefultContext context)
        {
            _context = context;
        }
        // READ
        [HttpGet("{id?}")]
        public async Task<IActionResult> Get(int? id)
        {
            if (id == null || id == 0)
                return Ok(await _context.Sports.Take(5).ToListAsync());
            var sport = await _context.Sports.FindAsync(id);
            if (sport == null)
                return NotFound();
            return Ok(sport);
        }
        // CREATE
        [HttpPost]
        public async Task<IActionResult> Create(Sports sport)
        {
            _context.Sports.Add(sport);
            await _context.SaveChangesAsync();
            return Ok(sport);
        }
        // UPDATE
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Sports sport)
        {
            if (id != sport.Id)
                return BadRequest();
            _context.Entry(sport).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(sport);
        }
        // DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var sport = await _context.Sports.FindAsync(id);
            if (sport == null)
                return NotFound();
            _context.Sports.Remove(sport);
            await _context.SaveChangesAsync();
            return NoContent();  
        }
    }
}