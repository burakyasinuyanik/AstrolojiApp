using System;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.ViewComponents;

public class ServiceViewComponent : ViewComponent
{
    private readonly IGenericRepository<Service> _repositoryServiceRepository;

    public ServiceViewComponent(IGenericRepository<Service> repositoryServiceRepository)
    {
        _repositoryServiceRepository = repositoryServiceRepository;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var services = await _repositoryServiceRepository.GetAllAsync();

        return View(services);
    }

}
