using System.Data.SqlClient;
using AstrolojiApp.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;

namespace AstrolojiApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HoroscopeGroupController : Controller
    {
        // GET: HoroscopeGroupController
        public async Task<ActionResult> IndexAsync()
        {
            var connectionString = "Server=localhost,1441;Database=AstrologyDb;User=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=true";
            var connection = new SqlConnection(connectionString);

            var queryHoroscopeGroup = "select * from HoroscopeGroups";
            var horoscopeGroups = await connection.QueryAsync<Horoscope>(queryHoroscopeGroup);
            
            return View(horoscopeGroups);
        
        }

    }
}
