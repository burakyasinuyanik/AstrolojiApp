using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AstrolojiApp.Entity.Concrete;
using System.Data.SqlClient;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Business.Abstract;


namespace AstrolojiApp.Controllers;

public class HomeController : Controller
{

    private readonly IGenericRepository<AppSetting> _appsetting;

    public HomeController(IGenericRepository<AppSetting> appsetting)
    {
        _appsetting = appsetting;
    }

    public async Task<IActionResult> Index()
    {

        var applist = await _appsetting.GetAllAsync();

        HomePageModel homePageModel = new HomePageModel();

        homePageModel.AppSetting = applist.First();
        

        return View(homePageModel);

        
    }




}
