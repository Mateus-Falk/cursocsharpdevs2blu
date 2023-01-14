using Devs2Blu.ProjetosAula.Atividade4MVC.Models.DTO;
using Devs2Blu.ProjetosAula.Atividade4MVC.Models.Entities;
using Devs2Blu.ProjetosAula.Atividade4MVC.Services.Interfeces;
using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.Atividade4MVC.Controllers
{
    public class GeneroController : Controller
    {
        private readonly IGenerosService _service;
        public GeneroController(IGenerosService service)
        {
            _service = service;
        }

		#region Consulta DB
		public async Task<IActionResult> Index()
        {
            var listGeneros = await _service.GetAllGeneros();
            return View(listGeneros);
        }
        #endregion
		#region Create
		public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("Id,Nome")]Genero genero)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    await _service.Save(genero);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {

            }
            return View(genero);
        }

		#endregion
		#region Delete

		public async Task<ActionResult> Delete(int id)
        {
            var genero = await _service.FindById(id);
            return View(new GeneroViewModel(){ id = genero.Id, nome = genero.Nome });
        }
        [HttpPost, ActionName("Delete")]
        public async Task<ActionResult<string>> ExecuteDelete([Bind("id,nome")] GeneroViewModel genero)
        {
            try
            {
                var resp = await _service.Delete(genero.ToEntity());
                return new ActionResult<string>("OK");
            }
            catch(Exception ex)
            {
                return new ActionResult<string>(ex.Message);
            }
        }
		#endregion

		#region Update

		public async Task<ActionResult> Edit(int id)
        {
            var genero = await _service.FindById(id);
            return View(new GeneroViewModel() { id = genero.Id, nome = genero.Nome });
        }

		[HttpPost, ActionName("Edit")]
        public async Task<ActionResult<string>> ExecuteEdit([Bind("id,nome")] GeneroViewModel genero)
        {
			try
			{
				if (ModelState.IsValid)
				{
					await _service.Update(genero.ToEntity());
					return RedirectToAction(nameof(Index));
				}
				return new ActionResult<string>("Erro");

			}
			catch (Exception ex)
			{
				return new ActionResult<string>(ex.Message);
			}
		}
		#endregion
	}
}
