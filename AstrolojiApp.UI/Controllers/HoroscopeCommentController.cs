using AstrolojiApp.Data.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.UI.Controllers
{
    public class HoroscopeCommentController : Controller
    {
        // GET: HoroscopeCommentController
        private readonly IHoroscopeCommentRepository _horoscopeComment;
        private readonly IHoroscopeRepository _horocope;
        public HoroscopeCommentController(IHoroscopeCommentRepository horoscopeComment, IHoroscopeRepository horocope)
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
