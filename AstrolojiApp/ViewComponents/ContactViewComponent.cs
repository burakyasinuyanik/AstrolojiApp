using System;
using AstrolojiApp.Areas.Admin.Data;
using AstrolojiApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.ViewComponents;

public class ContactViewComponent :ViewComponent
{

    private readonly IRepository<Contact> _repositoryContactRepository;

    public ContactViewComponent(IRepository<Contact> repositoryContactRepository)
    {
        _repositoryContactRepository = repositoryContactRepository;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var contacts = await _repositoryContactRepository.GetAllAsync();

        return View(contacts);
    }

}
