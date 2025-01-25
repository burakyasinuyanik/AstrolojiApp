using System;

using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.ViewComponents;

public class HoroscopeViewComponent : ViewComponent

{
    private readonly IGenericRepository<Horoscope> _repositoryHoroscopeRepository;

    public HoroscopeViewComponent(IGenericRepository<Horoscope> repositoryHoroscopeRepository)
    {
        _repositoryHoroscopeRepository = repositoryHoroscopeRepository;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var horoscopes = await _repositoryHoroscopeRepository.GetAllAsync();

        return View(horoscopes);
    }
}
