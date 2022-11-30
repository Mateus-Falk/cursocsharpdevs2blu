using Devs2Blu.ProjetosAula.Atividade2v2MVC.Models;
using Devs2Blu.ProjetosAula.Atividade2v2MVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Devs2Blu.ProjetosAula.Atividade2v2MVC.Controllers
{
	[Route("consulta")]
	public class ConsultaAPIController : Controller
	{
		private readonly CharacterAPIService Service = new CharacterAPIService();


		[Route("characters")]
		public async Task<IActionResult> Index()
		{
			var result = await Service.GetCharacter();
			return View(result);
		}
	}
}