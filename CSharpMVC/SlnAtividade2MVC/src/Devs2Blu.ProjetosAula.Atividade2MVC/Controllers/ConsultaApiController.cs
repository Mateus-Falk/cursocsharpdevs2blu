using Devs2Blu.ProjetosAula.Atividade2MVC.Models;
using Devs2Blu.ProjetosAula.Atividade2MVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Devs2Blu.ProjetosAula.Atividade2MVC.Controllers
{
	[Route("consulta")]
	public class ConsultaApiController : Controller
	{
		private readonly APIService Service = new APIService();
		[Route("agents")]
		public async Task<IActionResult> Agents()
		{
			var data = await Service.GetAgents();
			return View(data);
		}

		[Route("maps")]
		public async Task<IActionResult> Maps()
		{
			var data = await Service.GetMaps();
			return View(data);

		}
		
		[Route("weapons")]
		public async Task<IActionResult> Weapons()
		{
			var data = await Service.GetWeapons();
			return View(data);
		}

	}
}