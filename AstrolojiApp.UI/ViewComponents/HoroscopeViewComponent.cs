using System;
using AstrolojiApp.Areas.Admin.Data;
using AstrolojiApp.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.ViewComponents;

public class HoroscopeViewComponent : ViewComponent

{
    private readonly IRepository<Horoscope> _repositoryHoroscopeRepository;

    public HoroscopeViewComponent(IRepository<Horoscope> repositoryHoroscopeRepository)
    {
        _repositoryHoroscopeRepository = repositoryHoroscopeRepository;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var horoscopes = await _repositoryHoroscopeRepository.GetAllAsync();

        return View(horoscopes);
    }
}
