using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamMemberController : ControllerBase
    {
        private readonly ILogger<TeamMemberController> _logger;
        private readonly DefultContext _context;

        public TeamMemberController(ILogger<TeamMemberController> logger, DefultContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_context.TeamMembers.ToList());

        }
    }
}