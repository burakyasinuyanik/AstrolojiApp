using System.Data;
using AstrolojiApp.Areas.Admin.Data;
using AstrolojiApp.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.ViewComponents
{
    public class AppSettingViewComponent: ViewComponent
    {

        private readonly IRepository<AppSetting> _repositoryAppsSettingRepository;

        public AppSettingViewComponent(IRepository<AppSetting> repositoryAppsSettingRepository)
        {
            _repositoryAppsSettingRepository = repositoryAppsSettingRepository;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
           var appSetting= await _repositoryAppsSettingRepository.GetAllAsync();

            return View(appSetting.First());
        }
    }
}
