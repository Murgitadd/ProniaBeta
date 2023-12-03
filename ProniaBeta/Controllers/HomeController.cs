using Microsoft.AspNetCore.Mvc;

namespace ProniaBeta.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
