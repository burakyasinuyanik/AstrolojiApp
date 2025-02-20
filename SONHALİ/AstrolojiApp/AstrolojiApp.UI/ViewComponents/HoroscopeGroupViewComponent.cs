using System;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.ViewComponents;

public class HoroscopeGroupViewComponent : ViewComponent
{
    private readonly IGenericRepository<HoroscopeGroup> _repositoryHoroscopeGroupRepository;

    public HoroscopeGroupViewComponent(IGenericRepository<HoroscopeGroup> repositoryHoroscopeGroupRepository)
    {
        _repositoryHoroscopeGroupRepository = repositoryHoroscopeGroupRepository;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var horoscopeGroups = await _repositoryHoroscopeGroupRepository.GetAllAsync();

        return View(horoscopeGroups);
    }

}
