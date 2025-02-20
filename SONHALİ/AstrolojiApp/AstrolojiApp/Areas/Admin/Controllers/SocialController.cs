using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Dapper;
using AstrolojiApp.Models;
using AstrolojiApp.Areas.Admin.Data;
using System.Security.Permissions;

namespace AstrolojiApp.Areas.Admin.Controllers
{
   [Area("Admin")]
   public class SocialController : Controller
   {

      private readonly IRepository<SocialMedia> _social;

      public SocialController(IRepository<SocialMedia> social)
      {
         _social = social;
      }
      // GET: SocialController
      public async Task<ActionResult> Index()
      {

         var social = await _social.GetAllAsync();
         return View(social);
      }

      [HttpGet]
      public async Task<IActionResult> Update(int id)
      {
         var social = await _social.GetAsync(id);
         return View(social);
      }


      [HttpPost]
      public async Task<IActionResult> Update(SocialMedia entity)
      {
         var social = await _social.UpdateAsync(entity);

         return RedirectToAction("Index", "Social");
      }

      [HttpGet]
      public async Task<IActionResult> Add()
      {
         return View();
      }

      [HttpPost]
      public async Task<IActionResult> Add(SocialMedia entity)
      {
         var social = await _social.AddAsync(entity);

         return RedirectToAction("Index", "Social");
      }

      [HttpGet]
      public async Task<IActionResult> Delete(int id)
      {
         var result = await _social.DeleteAsync(id);

         return RedirectToAction("Index", "Social");
      }

   }
}
