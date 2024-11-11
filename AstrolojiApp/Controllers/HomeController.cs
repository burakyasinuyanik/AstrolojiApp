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
    private readonly IRepository<DailyNew> _dailyNew;
    private readonly IRepository<Horoscope> _horoscope;
    private readonly IRepository<HoroscopeGroup> _horoscopeGroup;
    private readonly IRepository<Service> _service;


    public HomeController(IRepository<AppSetting> appsetting, IRepository<AstrologComment> astrologComment, IRepository<DailyNew> dailyNew, IRepository<Horoscope> horoscope, IRepository<HoroscopeGroup> horoscopeGroup, IRepository<Service> service)
    {
        _appsetting = appsetting;
        _astrologComment = astrologComment;
        _dailyNew = dailyNew;
        _horoscope = horoscope;
        _horoscopeGroup = horoscopeGroup;
        _service = service;
    }

    public async  Task<IActionResult> Index()
    {
          var applist= await _appsetting.GetAllAsync();
          var comments= await _astrologComment.GetAllAsync();
          var dailyNews = await _dailyNew.GetAllAsync();
          var horoscopes = await _horoscope.GetAllAsync();
          var horoscopeGroups=await _horoscopeGroup.GetAllAsync();
          var services = await _service.GetAllAsync();

        HomePageModel homePageModel = new HomePageModel();

        homePageModel.AppSetting=applist.First();
        homePageModel.AstrologComments=comments;
        homePageModel.DailyNews = dailyNews;
        homePageModel.Horoscopes=horoscopes;
        homePageModel.Services=services;
        homePageModel.HoroscopeGroups=horoscopeGroups;

        return View(homePageModel);
    }


}
