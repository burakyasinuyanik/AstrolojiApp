using AstrolojiApp.Areas.Admin.Data;
using AstrolojiApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.Controllers
{
    public class HoroscopeCommentController : Controller
    {

        private readonly IRepository<HoroscopeComment> _horoscopeComment;
        private readonly IRepository<Horoscope> _horocope;

        public HoroscopeCommentController(IRepository<HoroscopeComment> horoscopeComment, IRepository<Horoscope> horocope)
        {
            _horoscopeComment = horoscopeComment;
            _horocope = horocope;
        }

        // GET: HoroscopeCommentController
        public async Task<ActionResult> Index(int id)
        {
            var horoscopeComment = await _horoscopeComment.GetAsync(id);
            var horocope = await _horocope.GetAsync(horoscopeComment!.HoroscopeId);
            horoscopeComment.Horoscope = horocope;

            return View(horoscopeComment);
        }

    }
}
