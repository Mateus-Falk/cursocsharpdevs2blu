using Devs2Blu.ProjetosAula.Atividade3v2MVC.Models;
using Devs2Blu.ProjetosAula.Atividade3v2MVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Devs2Blu.ProjetosAula.Atividade3v2MVC.Controllers
{
    [Route("table")]
    public class ApiController : Controller
    {
        private readonly ILogger<ApiController> _logger;
        private readonly ServiceAPI service;

        public ApiController(ILogger<ApiController> logger)
        {
            service = new ServiceAPI();
            _logger = logger;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("loadcharacter")]
        public async Task<PartialViewResult> LoadListCharacter()
        {
            var result = await service.GetListCharacters();
            return PartialView(result);
        }

        [Route("search/{nameCharacter}")]
        public async Task<PartialViewResult> SearchCharacter(string nameCharacter)
        {
            var character = await service.GetCharacterByName(nameCharacter);
            return PartialView(character);
        }

    }
}