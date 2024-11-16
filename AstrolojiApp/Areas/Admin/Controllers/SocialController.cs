using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SocialController : Controller
    {
        // GET: SocialController
        public ActionResult Index()
        {
            return View();
        }

    }
}
