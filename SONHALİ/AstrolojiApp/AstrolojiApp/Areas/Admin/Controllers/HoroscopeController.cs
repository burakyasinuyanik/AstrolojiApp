using System.Data.SqlClient;
using AstrolojiApp.Areas.Admin.Data;
using AstrolojiApp.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HoroscopeController : Controller
    {
        private readonly IRepository<Horoscope> _horoscopeRepository;

        public HoroscopeController(IRepository<Horoscope> horoscopeRepository)
        {
            _horoscopeRepository = horoscopeRepository;
        }

        // GET: HoroscopeController
        public async Task<ActionResult> Index()
        {
            //var connectionString = "Server=localhost,1441;Database=AstrologyDb;User=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=true";
            //var connection = new SqlConnection(connectionString);

            //var queryHoroscope = "select * from Horoscopes";
            //var horoscopes = await connection.QueryAsync<Horoscope>(queryHoroscope);
            var horoscopes=await _horoscopeRepository.GetAllAsync();
            return View(horoscopes);
        }

    }
}
