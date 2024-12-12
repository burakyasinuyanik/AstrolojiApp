using System;
using AstrolojiApp.Areas.Admin.Data;
using AstrolojiApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.ViewComponents;

public class ServiceViewComponent : ViewComponent
{
    private readonly IRepository<Service> _repositoryServiceRepository;

    public ServiceViewComponent(IRepository<Service> repositoryServiceRepository)
    {
        _repositoryServiceRepository = repositoryServiceRepository;
    }


    public async Task<IViewComponentResult> InvokeAsync()
    {
        var services = await _repositoryServiceRepository.GetAllAsync();

        return View(services);
    }

}
