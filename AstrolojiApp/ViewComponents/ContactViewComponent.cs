using System;
using AstrolojiApp.Areas.Admin.Data;
using AstrolojiApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.ViewComponents;

public class ContactViewComponent :ViewComponent
{

    private readonly IRepository<Contact> _repositoryAppsSettingRepository;

    public ContactViewComponent(IRepository<Contact> repositoryAppsSettingRepository)
    {
        _repositoryAppsSettingRepository = repositoryAppsSettingRepository;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var contacts = await _repositoryAppsSettingRepository.GetAllAsync();

        return View(contacts);
    }

}
