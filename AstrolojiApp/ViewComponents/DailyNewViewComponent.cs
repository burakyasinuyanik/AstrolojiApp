using System;
using AstrolojiApp.Areas.Admin.Data;
using AstrolojiApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.ViewComponents;

public class DailyNewViewComponent : ViewComponent
{
    private readonly IRepository<DailyNew> _repositoryAppsSettingRepository;

    public DailyNewViewComponent(IRepository<DailyNew> repositoryAppsSettingRepository)
    {
        _repositoryAppsSettingRepository = repositoryAppsSettingRepository;
    }


    public async Task<IViewComponentResult> InvokeAsync()
    {
        var dailyNews = await _repositoryAppsSettingRepository.GetAllAsync();

        return View(dailyNews);
    }

}
