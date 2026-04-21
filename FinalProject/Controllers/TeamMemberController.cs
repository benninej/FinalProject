using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace FinalProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamMembersController : ControllerBase
    {
        private readonly DefultContext _context;

        public TeamMembersController(DefultContext context)
        {
            _context = context;
        }

        // READ
        [HttpGet("{id?}")]
        public async Task<IActionResult> Get(int? id)
        {
            if (id == null || id == 0)
                return Ok(await _context.TeamMembers.Take(5).ToListAsync());

            var member = await _context.TeamMembers.FindAsync(id);

            if (member == null)
                return NotFound();

            return Ok(member);
        }

        // CREATE
        [HttpPost]
        public async Task<IActionResult> Create(TeamMember member)
        {
            _context.TeamMembers.Add(member);
            await _context.SaveChangesAsync();
            return Ok(member);
        }

        // UPDATE
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, TeamMember member)
        {
            if (id != member.Id)
                return BadRequest();

            _context.Entry(member).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok(member);
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var member = await _context.TeamMembers.FindAsync(id);

            if (member == null)
                return NotFound();

            _context.TeamMembers.Remove(member);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
