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
    private readonly IRepository<SocialMedia> _socialMedia;
    private readonly IRepository<Contact> _contact;



    public HomeController(IRepository<AppSetting> appsetting, IRepository<AstrologComment> astrologComment, IRepository<DailyNew> dailyNew, IRepository<Horoscope> horoscope, IRepository<HoroscopeGroup> horoscopeGroup, IRepository<Service> service, IRepository<SocialMedia> socialMedia, IRepository<Contact> contact)
    {
        _appsetting = appsetting;
        
    }

    public async Task<IActionResult> Index()
    {




        var applist = await _appsetting.GetAllAsync();
        // var comments = await _astrologComment.GetAllAsync();
        // var dailyNews = await _dailyNew.GetAllAsync();
        // var horoscopes = await _horoscope.GetAllAsync();
        // var horoscopeGroups = await _horoscopeGroup.GetAllAsync();
        // var services = await _service.GetAllAsync();
        // var socialMedia = await _socialMedia.GetAllAsync();
        // var contact = await _contact.GetAllAsync();


        HomePageModel homePageModel = new HomePageModel();

        homePageModel.AppSetting = applist.First();
        // homePageModel.AstrologComments = comments;
        // homePageModel.DailyNews = dailyNews;
        // homePageModel.Horoscopes = horoscopes;
        // homePageModel.Services = services;
        // homePageModel.HoroscopeGroups = horoscopeGroups;
        // homePageModel.SocialMedia = socialMedia;
        // homePageModel.Contact = contact;

        return View(homePageModel);

        //yorum
    }

    


}
