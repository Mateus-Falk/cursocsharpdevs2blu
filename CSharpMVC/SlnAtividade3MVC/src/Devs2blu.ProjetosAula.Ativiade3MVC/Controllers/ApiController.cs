using Devs2blu.ProjetosAula.Ativiade3MVC.Models;
using Devs2blu.ProjetosAula.Ativiade3MVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Devs2blu.ProjetosAula.Ativiade3MVC.Controllers
{
    [Route("table")]
    public class ApiController : Controller
    {
        private readonly ILogger<ApiController> _logger;
        private readonly ServiceAPI service;

        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
            service = new ServiceAPI();
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("loaddigimon")]
        public async Task<PartialViewResult> LoadListDigimon()
        {
            var result = await service.GetDigimon();
            return PartialView(result);
        }

        [Route("search/{nameDigimon}")]
        public async Task<PartialViewResult> SearchDigimon(string nameDigimon)
        {
            var Digimon = await service.GetDigimonByName(nameDigimon);
            return PartialView(Digimon);
        }
    }
}