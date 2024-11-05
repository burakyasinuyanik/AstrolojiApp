using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AstrolojiApp.Models;
using System.Data.SqlClient;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Dapper;

namespace AstrolojiApp.Controllers;

public class HomeController : Controller
{

    public async  Task<IActionResult> Index()
    {


        //var connectionString = "Server=localhost,1441;Database=AstrologyDb;User=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=true";
        //var connection = new SqlConnection(connectionString);

        //var queryAppSetting = "Select * from AppSetting";
        //var appSetting = (await connection.QueryAsync<AppSetting>(queryAppSetting)).First();

        //var queryAstrologComment = "Select * from AstrologComment";
        //var astrologComment = (await connection.QueryAsync<AstrologComment>(queryAstrologComment));

        //var queryDailyNews = "Select * from DailyNews";
        //var dailyNews = (await connection.QueryAsync<DailyNews>
        //(queryDailyNews));

        //var queryHoroscopeGroups = "Select * from HoroscopeGroups";
        //var horoscopeGroups = (await connection.QueryAsync<HoroscopeGroups>(queryHoroscopeGroups));

        //var queryHoroscopes = "Select * from Horoscopes";
        //var horoscopes = (await connection.QueryAsync<Horoscopes>(queryHoroscopes));

        //var queryServices = "Select * from Services";
        //var services = (await connection.QueryAsync<Services>
        //(queryServices));

        HomePageModel model = new(){

            //AppSetting = appSetting,
            //AstrologComments=astrologComment,
            //DailyNews= dailyNews,
            //HoroscopeGroups = horoscopeGroups,
            //Horoscopes = horoscopes,
            //Services = services,
        };
            

        return View(model);
    }


}
