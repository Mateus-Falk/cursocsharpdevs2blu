using Devs2Blu.ProjetosAula.Atividade3v2MVC.Models;
using Devs2Blu.ProjetosAula.Atividade3v2MVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Devs2Blu.ProjetosAula.Atividade3v2MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ServiceAPI service;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            service = new ServiceAPI();
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<PartialViewResult> Content()
        {
            var result = await service.GetListCharacters();
            return PartialView(result);
        }

    }
}