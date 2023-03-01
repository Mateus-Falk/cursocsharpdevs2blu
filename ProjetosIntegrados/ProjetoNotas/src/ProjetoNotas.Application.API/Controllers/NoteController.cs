using Microsoft.AspNetCore.Mvc;
using ProjetoNotas.Domain.DTO;
using ProjetoNotas.Domain.Interfaces.IService;

namespace ProjetoNotas.Application.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class NoteController : ControllerBase
	{
		private readonly INoteService _service;
		public NoteController(INoteService service)
		{
			_service = service;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<NoteDTO>>> GetNotes()
		{
			return _service.FindAll();
		}
		
		[HttpGet("{id}")]
		public async Task<ActionResult<NoteDTO>> GetNote(int id)
		{
			return await _service.FindById(id);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> PutNote(NoteDTO note)
		{
			await _service.Save(note);
			return NoContent();
		}

		[HttpPost]
		public async Task<ActionResult<NoteDTO>> PostNote(NoteDTO note)
		{
			await _service.Save(note);
			return CreatedAtAction("GetNote", new { id = note.id }, note);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteNote(int id)
		{
			await _service.Delete(id);
			return NoContent();
		}
	}
}
