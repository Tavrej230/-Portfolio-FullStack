using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Protofolio.Model;

namespace Protofolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactMessageController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ContactMessageController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContactMessage>>> GetMessages()
        { 
            return await _context.ContactMessages
                .OrderByDescending(x => x.CreatedAt)
                .ToListAsync(); 
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ContactMessage>> GetMessage(int id) {
            
            var message = await _context.ContactMessages.FindAsync(id);
            if (message == null) 
               return NotFound();
            return message; 
        }

        [HttpPost] 
        public async Task<ActionResult<ContactMessage>> PostMessage(ContactMessage message) { 
            message.CreatedAt = DateTime.Now; 
            _context.ContactMessages.Add(message); 
            await _context.SaveChangesAsync(); 
            return CreatedAtAction(nameof(GetMessage), new {
                id = message.Id
            }, 
            message);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMessage(int id) { 
            var message = await _context.ContactMessages.FindAsync(id);
            if (message == null) 
                return NotFound(); 
            _context.ContactMessages.Remove(message); 
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
