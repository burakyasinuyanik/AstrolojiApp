using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.Areas.Admin.Controllers
{


    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // ben sametim değiştirdim
            return View();
        }
    }
}
