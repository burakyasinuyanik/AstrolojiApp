using AstrolojiApp.Areas.Admin.Data;
using AstrolojiApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        private readonly IRepository<AppSetting> _appsetting;

        public ContactController(IRepository<AppSetting> appsetting)
        {
            _appsetting = appsetting;
        }

        // GET: ContactController
        public async Task<ActionResult> Index()
        {
            var entity = await _appsetting.GetAsync(1);
            entity.BrandName = "Bir Baþka Dapper";
            var result = await _appsetting.UpdateAsync(entity);
            return View();
        }

    }
}
