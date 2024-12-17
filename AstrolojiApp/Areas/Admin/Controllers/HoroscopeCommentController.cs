using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using AstrolojiApp.Areas.Admin.Data;
using AstrolojiApp.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;


namespace AstrolojiApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HoroscopeCommentController : Controller
    {
        private readonly IRepository<HoroscopeComment> _horoscopecommentRepository;

        public HoroscopeCommentController(IRepository<HoroscopeComment> horoscopecommentRepository)
        {
            _horoscopecommentRepository = horoscopecommentRepository;
        }

        // GET: HoroscopeCommentController
        public async Task<ActionResult> Index()
        {
            var HoroscopeComments = await _horoscopecommentRepository.GetAllAsync();
            return View(HoroscopeComments);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var horoscopeComment = await _horoscopecommentRepository.GetAsync(id);

            return View(horoscopeComment);
        }

        [HttpPost]
        public async Task<IActionResult> Update(HoroscopeComment entity)
        {
            var horoscopeComment = await _horoscopecommentRepository.UpdateAsync(entity);

            return RedirectToAction("Index", "horoscope");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _horoscopecommentRepository.DeleteAsync(id);

            return RedirectToAction("Index", "HoroscopeComment");
        }





    }
}
