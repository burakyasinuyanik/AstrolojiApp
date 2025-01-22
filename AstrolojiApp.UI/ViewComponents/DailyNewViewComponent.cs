using System;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.ViewComponents;

public class DailyNewViewComponent : ViewComponent
{
    private readonly IGenericRepository<DailyNew> _repositoryDailyNewRepository;

    public DailyNewViewComponent(IGenericRepository<DailyNew> repositoryDailyNewRepository)
    {
        _repositoryDailyNewRepository = repositoryDailyNewRepository;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var dailyNews = await _repositoryDailyNewRepository.GetAllAsync();

        return View(dailyNews);
    }

}
