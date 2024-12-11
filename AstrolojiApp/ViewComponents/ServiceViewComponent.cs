using System;
using AstrolojiApp.Areas.Admin.Data;
using AstrolojiApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.ViewComponents;

public class ServiceViewComponent : ViewComponent
{
    private readonly IRepository<Service> _repositoryAppsSettingRepository;

    public ServiceViewComponent(IRepository<Service> repositoryAppsSettingRepository)
    {
        _repositoryAppsSettingRepository = repositoryAppsSettingRepository;
    }


    public async Task<IViewComponentResult> InvokeAsync()
    {
        var services = await _repositoryAppsSettingRepository.GetAllAsync();

        return View(services);
    }

}
