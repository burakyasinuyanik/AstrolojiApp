using System.Data.SqlClient;
using AstrolojiApp.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HoroscopeController : Controller
    {
        // GET: HoroscopeController
        public async Task<ActionResult> IndexAsync()
        {
            var connectionString = "Server=localhost,1441;Database=AstrologyDb;User=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=true";
            var connection = new SqlConnection(connectionString);

            var queryHoroscope = "select * from Horoscopes";
            var horoscopes = await connection.QueryAsync<Horoscope>(queryHoroscope);

            return View(horoscopes);
        }

    }
}
