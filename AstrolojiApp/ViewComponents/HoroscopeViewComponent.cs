using System;
using AstrolojiApp.Areas.Admin.Data;
using AstrolojiApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.ViewComponents;

public class HoroscopeViewComponent : ViewComponent

{
    private readonly IRepository<Horoscope> _repositoryAppsSettingRepository;

    public HoroscopeViewComponent(IRepository<Horoscope> repositoryAppsSettingRepository)
    {
        _repositoryAppsSettingRepository = repositoryAppsSettingRepository;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var horoscopes = await _repositoryAppsSettingRepository.GetAllAsync();

        return View(horoscopes);
    }
}
