using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Security.Permissions;
using AstrolojiApp.Business.Abstract;
using AstrolojiApp.Shared.Dtos;

namespace AstrolojiApp.Areas.Admin.Controllers
{
   [Area("Admin")]
   public class SocialController : Controller
   {

     private readonly ISocialMediaService _socialMediaService;

        public SocialController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        // GET: SocialController
        public async Task<ActionResult> Index()
      {

         var social = await _socialMediaService.GetSocialMediaAsync();
         return View(social);
      }

      [HttpGet]
      public async Task<IActionResult> Update(int id)
      {
         var social = await _socialMediaService.GetByIdAsync(id);
         return View(social);
      }


      [HttpPost]
      public async Task<IActionResult> Update(SocialMediaUpdateDto socialMediaUpdateDto)
      {
         if (ModelState.IsValid)
         {
            var social = await _socialMediaService.UpdateAsync(socialMediaUpdateDto);

            return RedirectToAction("Index", "Social");
         }
          return View(socialMediaUpdateDto);
      }

      [HttpGet]
      public async Task<IActionResult> Add()
      {
         return View();
      }

      [HttpPost]
      public async Task<IActionResult> Add(SocialMediaCreateDto  socialMediaCreateDto)
      {
         if (ModelState.IsValid)
         {
            var social = await _socialMediaService.CreateAsync(socialMediaCreateDto);

            return RedirectToAction("Index", "Social");
         }
         return View(socialMediaCreateDto);
         
      }

      [HttpGet]
      public async Task<IActionResult> Delete(int id)
      {
          await _socialMediaService.DeleteAsync(id);

         return RedirectToAction("Index", "Social");
      }

   }
}
