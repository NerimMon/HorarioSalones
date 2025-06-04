using Microsoft.AspNetCore.Mvc;

namespace HorarioSalones.Controllers
{
    public class SalonesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Planta()
        {
            return View();
        }
    }
}
