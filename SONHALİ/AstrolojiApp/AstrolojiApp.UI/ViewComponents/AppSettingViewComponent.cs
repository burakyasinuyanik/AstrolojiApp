using System.Data;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.ViewComponents
{
    
    public class AppSettingViewComponent: ViewComponent
    {

        private readonly IGenericRepository<AppSetting> _appsetting;

        public AppSettingViewComponent(IGenericRepository<AppSetting> appsetting)
        {
            _appsetting = appsetting;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
           var appSetting= await _appsetting.GetAllAsync();

            return View(appSetting.First());
        }
    }
}
