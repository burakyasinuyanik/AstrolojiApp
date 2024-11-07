using System.Data.SqlClient;
using AstrolojiApp.Areas.Admin.Data;
using AstrolojiApp.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DailyNewController : Controller
    {
        private readonly IRepository<DailyNew> _dailyNewRepository;

        public DailyNewController(IRepository<DailyNew> dailyNewRepository)
        {
            _dailyNewRepository = dailyNewRepository;
        }

        // GET: DailyNewController
        public async Task<ActionResult> Index()
        {
            //var connectionString = "Server=localhost,1441;Database=AstrologyDb;User=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=true";
            //var connection = new SqlConnection(connectionString);

            //var queryDailyNew = "select * from DailyNews";
            //var dailyNews = await connection.QueryAsync<DailyNew>(queryDailyNew);
            var dailyNews=await _dailyNewRepository.GetAllAsync();
            return View(dailyNews);
        }

    }
}
