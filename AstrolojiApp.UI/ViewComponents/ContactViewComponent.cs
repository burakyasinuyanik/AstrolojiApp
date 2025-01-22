using System;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.ViewComponents;

public class ContactViewComponent :ViewComponent
{

    private readonly IGenericRepository<Contact> _repositoryContactRepository;

    public ContactViewComponent(IGenericRepository<Contact> repositoryContactRepository)
    {
        _repositoryContactRepository = repositoryContactRepository;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var contacts = await _repositoryContactRepository.GetAllAsync();

        return View(contacts);
    }

}
