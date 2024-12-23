using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using AstrolojiApp.Areas.Admin.Data;
using AstrolojiApp.Areas.Admin.Dto;
using AstrolojiApp.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;


namespace AstrolojiApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HoroscopeCommentController : Controller
    {
        private readonly IRepository<HoroscopeComment> _horoscopecommentRepository;
        private readonly IRepository<HoroscopeCommentDto> _horoscopeCommentUpdateRepository;

        public HoroscopeCommentController(IRepository<HoroscopeComment> horoscopecommentRepository, IRepository<HoroscopeCommentDto> horoscopeCommentUpdateRepository)
        {
            _horoscopecommentRepository = horoscopecommentRepository;
            _horoscopeCommentUpdateRepository = horoscopeCommentUpdateRepository;
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
        public async Task<IActionResult> Update(HoroscopeCommentDto entity)
        {
            var horoscopeComment = await _horoscopeCommentUpdateRepository.UpdateAsync(entity);

            return RedirectToAction("Index", "horoscopeComment");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _horoscopecommentRepository.DeleteAsync(id);

            return RedirectToAction("Index", "HoroscopeComment");
        }





    }
}
