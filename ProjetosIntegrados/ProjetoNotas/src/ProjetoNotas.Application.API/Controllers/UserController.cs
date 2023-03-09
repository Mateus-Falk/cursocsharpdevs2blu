using Microsoft.AspNetCore.Mvc;
using ProjetoNotas.Domain.DTO;
using ProjetoNotas.Domain.Interfaces.IService;

namespace ProjetoNotas.Application.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : Controller
	{
		private readonly IUserService _service;
		public UserController(IUserService service)
		{
			_service = service;
		}

		[HttpGet]
		public async Task<JsonResult> GetUsers()
		{
			return Json(_service.FindAll());
		}

		[HttpGet("{id}")]
		public async Task<JsonResult> GetUser(int id)
		{
			return Json(_service.FindAll().FirstOrDefault(u => u.id == id));
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> PutUser(UserDTO user)
		{
			await _service.Save(user);
			return NoContent();
		}

		[HttpPost]
		public async Task<ActionResult<UserDTO>> PostUser(UserDTO user)
		{
			await _service.Save(user);
			return CreatedAtAction("GetUser", new { id = user.id}, user);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteUser(int id)
		{
			await _service.Delete(id);
			return NoContent();
		}
	}
}
