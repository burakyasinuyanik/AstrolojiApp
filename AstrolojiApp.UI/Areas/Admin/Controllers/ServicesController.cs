using System.Data.SqlClient;
using AstrolojiApp.Business.Abstract;
using AstrolojiApp.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;



namespace AstrolojiApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServicesController : Controller
    {
        // GET: ServicesController
        private readonly IServiceService _serviceService;

        public ServicesController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public async Task<ActionResult> Index()
        {
           
            var services=await _serviceService.GetServiceAsync();
            
            return View(services);
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var service = await _serviceService.GetByIdAsync(id);

            return View(service);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ServiceUpdateDto  serviceUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var service = await _serviceService.UpdateAsync(serviceUpdateDto);

                return RedirectToAction("Index", "Service");
            }
            return View(serviceUpdateDto);
            
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ServiceCreateDto  serviceCreateDto)
        {
            if (ModelState.IsValid)
            {
                var service = await _serviceService.CreateAsync(serviceCreateDto);

                return RedirectToAction("Index", "Service");
            }
            return View(serviceCreateDto);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
           await _serviceService.DeleteAsync(id);

            return RedirectToAction("Index", "Services");
        }

    }
}
