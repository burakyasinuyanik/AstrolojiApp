using System;
using AstrolojiApp.Areas.Admin.Data;
using AstrolojiApp.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.ViewComponents;

public class HoroscopeGroupViewComponent : ViewComponent
{
    private readonly IRepository<HoroscopeGroup> _repositoryHoroscopeGroupRepository;

    public HoroscopeGroupViewComponent(IRepository<HoroscopeGroup> repositoryHoroscopeGroupRepository)
    {
        _repositoryHoroscopeGroupRepository = repositoryHoroscopeGroupRepository;
    }


    public async Task<IViewComponentResult> InvokeAsync()
    {
        var horoscopeGroups = await _repositoryHoroscopeGroupRepository.GetAllAsync();

        return View(horoscopeGroups);
    }

}
