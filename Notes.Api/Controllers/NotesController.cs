using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Notes.Api.Data;
using Notes.Api.Models;


namespace Notes.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotesController : ControllerBase
    {
        private readonly AppDbContext _context;
        public NotesController(AppDbContext context)
        {
            _context = context;
        }
    
    // GET: api/notes
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Note>>>GetNotes()
    {
        return await _context.Notes.OrderByDescending(n=>n.CreatedAt).ToListAsync();
    }

    // GET: api/notes/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<Note>> GetNote(Guid id)
        {
            var note = await _context.Notes.FindAsync(id);
            if(note == null)
                return NotFound();
            return note;
        }
    // POST: api/notes
    [HttpPost]
    public async Task<ActionResult<Note>> CreateNote(Note note)
        {
            note.Id = Guid.NewGuid();
            note.CreatedAt = DateTime.UtcNow;

            _context.Notes.Add(note);await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetNote), new {id = note.Id}, note);
        }
    // PUT: api/notes/{id}
    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateNote(Guid id, Note updatednote)
        {
           var existingNote = await _context.Notes.FindAsync(id);
           if(existingNote == null)
               return NotFound();
            existingNote.Title = updatednote.Title;
            existingNote.Content = updatednote.Content;
            existingNote.UpdatedAt = DateTime.UtcNow;
            await _context.SaveChangesAsync();
            return NoContent();
        }
    // DELETE: api/notes/{id}
    [HttpDelete("{id}")]
    public async Task<ActionResult>DeleteNote(Guid id)
        {
            var note = await _context.Notes.FindAsync(id);
            if(note == null)
                return NotFound();
            _context.Notes.Remove(note);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
