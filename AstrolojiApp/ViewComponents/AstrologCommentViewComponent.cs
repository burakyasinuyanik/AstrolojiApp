using System;
using AstrolojiApp.Areas.Admin.Data;
using AstrolojiApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.ViewComponents;

public class AstrologCommentViewComponent : ViewComponent
{

    private readonly IRepository<AstrologComment> _repositoryAppsSettingRepository;

    public AstrologCommentViewComponent(IRepository<AstrologComment> repositoryAppsSettingRepository)
    {
        _repositoryAppsSettingRepository = repositoryAppsSettingRepository;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var astrologComments = await _repositoryAppsSettingRepository.GetAllAsync();

        return View(astrologComments);
    }


}
