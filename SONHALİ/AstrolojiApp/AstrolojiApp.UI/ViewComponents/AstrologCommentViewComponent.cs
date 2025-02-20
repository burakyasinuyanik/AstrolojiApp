using System;

using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.ViewComponents;

public class AstrologCommentViewComponent : ViewComponent
{

    private readonly IGenericRepository<AstrologComment>  _astrologCommentRepository;

    public AstrologCommentViewComponent(IGenericRepository<AstrologComment> astrologCommentRepository)
    {
        _astrologCommentRepository = astrologCommentRepository;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var astrologComments = await _astrologCommentRepository.GetAllAsync();

        return View(astrologComments);
    }


}
