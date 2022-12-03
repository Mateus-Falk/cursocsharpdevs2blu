using Devs2blu.ProjetosAula.Ativiade3MVC.Models;
using Devs2blu.ProjetosAula.Ativiade3MVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Devs2blu.ProjetosAula.Ativiade3MVC.Controllers
{
    /*[Route("Home")]*/
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ServiceAPI service;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            service = new ServiceAPI();
        }

 
        /*[Route("Index")]*/
        public IActionResult Index()
        {
            return View();
        }
        /*[Route("search/{nameDigimon}")]*/
        public async Task<PartialViewResult> Content()
        {
            var result = await service.GetDigimon();
            return PartialView(result);
        }
    }
}