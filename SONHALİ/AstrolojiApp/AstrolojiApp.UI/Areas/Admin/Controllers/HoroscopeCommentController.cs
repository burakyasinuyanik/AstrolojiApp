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
        private readonly IHoroscopeCommentService _horoscopeCommentService;

        public HoroscopeCommentController(IHoroscopeCommentService horoscopeCommentService)
        {
            _horoscopeCommentService = horoscopeCommentService;
        }

        public async Task<ActionResult> Index()
        {
            var horoscopeComments = await _horoscopeCommentService.GetHoroscopeCommentAsync();
            return View(horoscopeComments);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var horoscopeComment = await _horoscopeCommentService.GetByIdAsync(id);
            if (horoscopeComment == null)
            {
                return NotFound();
            }

            var updateDto = new HoroscopeCommentUpdateDto
            {
                Id = horoscopeComment.Id,
                HoroscopeId = horoscopeComment.HoroscopeId,
                Name = horoscopeComment.Name,
                Daily = horoscopeComment.Daily,
                Monthly = horoscopeComment.Monthly,
                Annual = horoscopeComment.Annual
            };

            return View(updateDto);
        }

        [HttpPost]
        public async Task<IActionResult> Update(HoroscopeCommentUpdateDto horoscopeCommentUpdateDto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _horoscopeCommentService.UpdateAsync(horoscopeCommentUpdateDto);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(ex.Message, "Güncelleme sırasında bir hata oluştu.");
                }
            }
            return View(horoscopeCommentUpdateDto);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await _horoscopeCommentService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
