using System;
using AstrolojiApp.Areas.Admin.Data;
using AstrolojiApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.ViewComponents;

public class HoroscopeGroupViewComponent : ViewComponent
{
    private readonly IRepository<HoroscopeGroup> _repositoryAppsSettingRepository;

    public HoroscopeGroupViewComponent(IRepository<HoroscopeGroup> repositoryAppsSettingRepository)
    {
        _repositoryAppsSettingRepository = repositoryAppsSettingRepository;
    }


    public async Task<IViewComponentResult> InvokeAsync()
    {
        var horoscopeGroups = await _repositoryAppsSettingRepository.GetAllAsync();

        return View(horoscopeGroups);
    }

}
