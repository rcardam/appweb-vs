using Microsoft.AspNetCore.Mvc;
using winAppWebMVC.Models;

namespace winAppWebMVC.Controllers
{
    public class EquipeController : Controller
    {
        Equipe equipeModel = new Equipe();

        public IActionResult Index()
        {
            ViewBag.Equipes = equipeModel.lerEquipes();
            return View();
        }
    }
}
