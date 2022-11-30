using Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Controllers
{
    [Route("admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            List<User> user = new List<User>
			{  
                new User { Id = 1, Name = "Mateus Falk", Login = "mateusf"},
                new User { Id = 2, Name = "Tuca Canguru", Login = "tucac"},
                new User { Id = 3, Name = "Mel Abelha", Login = "mela"},
                new User { Id = 4, Name = "Zuky Coelha", Login = "zukyc"},
                new User { Id = 5, Name = "Bidu Biduskão", Login = "bicub"},
                new User { Id = 6, Name = "Nickolas Queijo", Login = "nicko"},
                new User { Id = 7, Name = "Nanica Nanicota", Login = "nanican"},
                new User { Id = 8, Name = "Lilica Lilicota", Login = "lilical"},
                new User { Id = 9, Name = "Mingui Miguinha", Login = "minguim"},
                new User { Id = 10, Name = "Peta Dina", Login = "petad"}

			};
            return View(user);
        }
        [Route("indicadores")]
        [Route("numbers")]
        public IActionResult Indicadores()
        {
            return View();
        }
        [Route("cards")]
        public PartialViewResult CardsResultados()
        {
            // var result = Service.GetLista();
            return PartialView();
        }
    }
}
