using System.Data.SqlClient;
using AstrolojiApp.Business.Abstract;
using AstrolojiApp.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HoroscopeGroupController : Controller
    {
        // GET: HoroscopeGroupController

       private readonly IHoroscopeGroupService _horoscopeGroupService;

        public HoroscopeGroupController(IHoroscopeGroupService horoscopeGroupService)
        {
            _horoscopeGroupService = horoscopeGroupService;
        }

        public async Task<ActionResult> Index()
        {
           
            var horoscopeGroups=await _horoscopeGroupService.GetHoroscopeGroupAsync();

            return View(horoscopeGroups);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var horoscopeGroup = await _horoscopeGroupService.GetByIdAsync(id);

            return View(horoscopeGroup);
        }

        [HttpPost]
        public async Task<IActionResult> Update(HoroscopeGroupUpdateDto horoscopeGroupUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var horoscopeGroup= await _horoscopeGroupService.UpdateAsync(horoscopeGroupUpdateDto);

                return RedirectToAction("Index", "HoroscopeGroup");
            }
            return View(horoscopeGroupUpdateDto);

        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await _horoscopeGroupService.DeleteAsync(id);

            return RedirectToAction("Index", "HoroscopeGroup");
        }


    }
}
