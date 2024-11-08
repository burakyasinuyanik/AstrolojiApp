using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AstrolojiApp.Models;
using System.Data.SqlClient;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Dapper;
using AstrolojiApp.Areas.Admin.Data;

namespace AstrolojiApp.Controllers;

public class HomeController : Controller
{

    private readonly IRepository<AppSetting> _appsetting;
    private readonly IRepository<AstrologComment> _astrologComment;



    public HomeController(IRepository<AppSetting> appsetting, IRepository<AstrologComment> astrologComment)
    {
        _appsetting = appsetting;
        _astrologComment = astrologComment;
    }

    public async  Task<IActionResult> Index()
    {
          var applist= await _appsetting.GetAllAsync();
          var comment= await _astrologComment.GetAllAsync();
     //   var astrogetbyOne = await _astrologComment.GetById(5);
        HomePageModel homePageModel = new HomePageModel();

        homePageModel.AppSetting=applist.First();
        homePageModel.AstrologComments=comment;
            

        return View(homePageModel);
    }


}
