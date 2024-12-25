using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
   
    }
}
