using Microsoft.AspNetCore.Mvc;

namespace asp.net_mvc_core.Controllers
{
    public class MinhaPaginaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Pagina()
        {
            return View();
        }
    }
}