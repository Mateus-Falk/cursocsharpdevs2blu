using Microsoft.AspNetCore.Mvc;
using ProjetoNotas.Domain.DTO;
using ProjetoNotas.Domain.Interfaces.IService;

namespace ProjetoNotas.Application.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class NoteController : Controller
	{
		private readonly INoteService _service;
		public NoteController(INoteService service)
		{
			_service = service;
		}

		[HttpGet]
		public async Task<JsonResult> GetNotes()
		{
			return Json(_service.FindAll());
		}
		
		[HttpGet("{id}")]
		public async Task<JsonResult> GetNote(int id)
		{
			return Json(_service.FindAll().FirstOrDefault(n => n.id == id));
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
