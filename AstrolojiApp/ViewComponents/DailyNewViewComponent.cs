using System;
using AstrolojiApp.Areas.Admin.Data;
using AstrolojiApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.ViewComponents;

public class DailyNewViewComponent : ViewComponent
{
    private readonly IRepository<DailyNew> _repositoryDailyNewRepository;

    public DailyNewViewComponent(IRepository<DailyNew> repositoryDailyNewRepository)
    {
        _repositoryDailyNewRepository = repositoryDailyNewRepository;
    }


    public async Task<IViewComponentResult> InvokeAsync()
    {
        var dailyNews = await _repositoryDailyNewRepository.GetAllAsync();

        return View(dailyNews);
    }

}
