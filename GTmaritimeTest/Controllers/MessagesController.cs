using Microsoft.AspNetCore.Mvc;
using GTmaritimeTest.Models;
using System.Threading.Tasks;
using System.Linq;

namespace GTmaritimeTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessagesController : ControllerBase
    {
        private readonly AppDbContext _context;
        public MessagesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/messages
        [HttpGet]
        public IActionResult GetAll()
        {
            var messages = _context.MaritimeMessages
                .OrderByDescending(m => m.SentTime)
                .ToList();
            return Ok(messages);
        }

        // POST: api/messages
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] MaritimeMessage message)
        {
            if (message == null)
                return BadRequest();
            message.SentTime = System.DateTime.UtcNow;
            _context.MaritimeMessages.Add(message);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAll), new { id = message.Id }, message);
        }
    }
} 