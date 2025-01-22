using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using AstrolojiApp.Business.Abstract;
using AstrolojiApp.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;


namespace AstrolojiApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HoroscopeCommentController : Controller
    {
        private readonly IHoroscopeCommentService _horoscopeCommnetService;

        public HoroscopeCommentController(IHoroscopeCommentService horoscopeCommnetService)
        {
            _horoscopeCommnetService = horoscopeCommnetService;
        }


        // GET: HoroscopeCommentController
        public async Task<ActionResult> Index()
        {
            var HoroscopeComments = await _horoscopeCommnetService.GetHoroscopeCommentAsync();
            return View(HoroscopeComments);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var horoscopeComment = await _horoscopeCommnetService.GetByIdAsync(id);

            return View(horoscopeComment);
        }

        [HttpPost]
        public async Task<IActionResult> Update(HoroscopeCommentUpdateDto  horoscopeCommentUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var horoscopeComment = await _horoscopeCommnetService.UpdateAsync(horoscopeCommentUpdateDto);

                return RedirectToAction("Index", "HoroscopeComment");
            }
              return View(horoscopeCommentUpdateDto);
            
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
             await _horoscopeCommnetService.DeleteAsync(id);

            return RedirectToAction("Index", "HoroscopeComment");
        }

    }
}
