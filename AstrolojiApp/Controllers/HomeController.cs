using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AstrolojiApp.Entity.Concrete;
using System.Data.SqlClient;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using AstrolojiApp.Areas.Admin.Data;

namespace AstrolojiApp.Controllers;

public class HomeController : Controller
{

    private readonly IRepository<AppSetting> _appsetting;
    


    public HomeController(IRepository<AppSetting> appsetting)
    {
        _appsetting = appsetting;

    }

    public async Task<IActionResult> Index()
    {




        var applist = await _appsetting.GetAllAsync();
       


        HomePageModel homePageModel = new HomePageModel();

        homePageModel.AppSetting = applist.First();
        

        return View(homePageModel);

        //yorum
    }




}
