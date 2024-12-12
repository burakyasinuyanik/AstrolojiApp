using System;
using AstrolojiApp.Areas.Admin.Data;
using AstrolojiApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.ViewComponents;

public class AstrologCommentViewComponent : ViewComponent
{

    private readonly IRepository<AstrologComment> _repositoryAstrologCommentRepository;

    public AstrologCommentViewComponent(IRepository<AstrologComment> repositoryAstrologCommentRepository)
    {
        _repositoryAstrologCommentRepository = repositoryAstrologCommentRepository;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var astrologComments = await _repositoryAstrologCommentRepository.GetAllAsync();

        return View(astrologComments);
    }


}
