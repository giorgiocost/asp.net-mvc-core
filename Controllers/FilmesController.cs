using Microsoft.AspNetCore.Mvc;

namespace asp.net_mvc_core.Controllers
{
    public class FilmesController : Controller
    {
        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }
    }
}