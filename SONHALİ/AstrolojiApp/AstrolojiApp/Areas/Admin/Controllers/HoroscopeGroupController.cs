using System.Data.SqlClient;
using AstrolojiApp.Areas.Admin.Data;
using AstrolojiApp.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HoroscopeGroupController : Controller
    {
        // GET: HoroscopeGroupController

        private readonly IRepository<HoroscopeGroup> _horoscopeGroup;

        public HoroscopeGroupController(IRepository<HoroscopeGroup> repository)
        {
            _horoscopeGroup = repository;
        }

        public async Task<ActionResult> Index()
        {
            //var connectionString = "Server=localhost,1441;Database=AstrologyDb;User=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=true";
            //var connection = new SqlConnection(connectionString);

            //var queryHoroscopeGroup = "select * from HoroscopeGroups";
            //var horoscopeGroups = await connection.QueryAsync<Horoscope>(queryHoroscopeGroup);
            var horoscopeGroups=await _horoscopeGroup.GetAllAsync();
            return View(horoscopeGroups);
        
        }

    }
}
