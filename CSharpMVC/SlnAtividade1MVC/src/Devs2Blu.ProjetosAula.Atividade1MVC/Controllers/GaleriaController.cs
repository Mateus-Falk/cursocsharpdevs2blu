using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.Atividade1MVC.Controllers
{
    public class GaleriaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
