using Devs2Blu.ProjetosAula.Atividade4MVC.Models;
using Devs2Blu.ProjetosAula.Atividade4MVC.Models.DTO;
using Devs2Blu.ProjetosAula.Atividade4MVC.Models.Entities;
using Devs2Blu.ProjetosAula.Atividade4MVC.Services.Interfeces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Devs2Blu.ProjetosAula.Atividade4MVC.Controllers
{
	public class JogoController : Controller
	{
		private readonly IJogosService _service;
		private readonly ContextoDatabase _context;
		public JogoController(IJogosService service)
		{
			_service= service;
			
		}


		// GET: JogoController
		public async Task<IActionResult> Index()
		{
			var listCategorias = await _service.GetAllJogos();
			return View(listCategorias);
		}

		// GET: JogoController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: JogoController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create([Bind("Id,Nome,Personagem,Review,Nota,GeneroId")]Jogo jogo)
		{
			try
			{
				if (ModelState.IsValid)
				{
					await _service.Save(jogo);
					return RedirectToAction(nameof(Index));
				}
					//ViewData["GeneroId"] = new SelectList(await _serviceGenero.GetAllGeneros(), "Id", "Nome", jogo.GeneroId);
			}
			catch
			{
			}
			return View(jogo);
		}

		public async Task<ActionResult> Delete(int id)
		{
			var jogo = await _service.FindById(id);
			return View(new JogoViewModel()
			{
				id = jogo.Id,
				nome = jogo.Nome,
				personagem = jogo.Personagem,
				review = jogo.Review,
				nota = jogo.Nota,
				generoid = jogo.GeneroId
			});
		}

		[HttpPost, ActionName("Delete")]
		public async Task<ActionResult<string>> ExecuteDelete(
					[Bind("id,nome,personagem,review,nota,generoid")] JogoViewModel jogo)
		{
			try
			{
				var resp = await _service.Delete(jogo.ToEntity());
				return new ActionResult<string>("OK");
			}
			catch (Exception ex)
			{
				return new ActionResult<string>(ex.Message);
			}
		}

	}
}
