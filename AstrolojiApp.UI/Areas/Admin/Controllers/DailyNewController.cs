using System.Data.SqlClient;
using AstrolojiApp.Business.Abstract;
using AstrolojiApp.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DailyNewController : Controller
    {
        private readonly IDailyNewService _dailyNewService;

        public DailyNewController(IDailyNewService dailyNewService)
        {
            _dailyNewService = dailyNewService;
        }



        // GET: DailyNewController
        public async Task<ActionResult> Index()
        {

            var dailyNews = await _dailyNewService.GetDailyNewAsync();
            return View(dailyNews);
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var dailynew = await _dailyNewService.GetByIdAsync(id);
            return View(dailynew);
        }


        [HttpPost]
        public async Task<IActionResult> Update(DailyNewUpdateDto dailyNewUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var dailynew = await _dailyNewService.UpdateAsync(dailyNewUpdateDto);
                return RedirectToAction("Index", "DailyNew");

            }
            return View(dailyNewUpdateDto);

        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(DailyNewCreateDto dailyNewCreateDto)
        {
            if (ModelState.IsValid)
            {
                var dailynew = await _dailyNewService.CreateAsync(dailyNewCreateDto);
                return RedirectToAction("Index", "DailyNew");
            }
            return View(dailyNewCreateDto);

        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await _dailyNewService.DeleteAsync(id);

            return RedirectToAction("Index", "DailyNew");
        }

    }
}
