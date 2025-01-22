using System.Data.SqlClient;
using AstrolojiApp.Business.Abstract;
using AstrolojiApp.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HoroscopeController : Controller
    {
        private readonly IHoroscopeService _horoscopeService;

        public HoroscopeController(IHoroscopeService horoscopeService)
        {
            _horoscopeService = horoscopeService;
        }

        // GET: HoroscopeController
        public async Task<ActionResult> Index()
        {
        
            var horoscopes=await _horoscopeService.GetHoroscopeAsync();
            return View(horoscopes);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var horoscope = await _horoscopeService.GetByIdAsync(id);

            return View(horoscope);
        }

        [HttpPost]
        public async Task<IActionResult> Update(HoroscopeUpdateDto horoscopeUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var horoscope = await _horoscopeService.UpdateAsync(horoscopeUpdateDto);

                return RedirectToAction("Index", "Horoscope");
            }
            return View(horoscopeUpdateDto);

        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await _horoscopeService.DeleteAsync(id);

            return RedirectToAction("Index", "Horoscope");
        }

    }
}
