using System.Data.SqlClient;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using AstrolojiApp.Models;

namespace AstrolojiApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServicesController : Controller
    {
        // GET: ServicesController
        public async Task<ActionResult> IndexAsync()
        {
            var connectionString = "Server=localhost,1441;Database=AstrologyDb;User=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=true";
            var connection = new SqlConnection(connectionString);

            var queryService = "select * from Services";
            var services = await connection.QueryAsync<Service>(queryService);
            
            return View(services);
        }

    }
}
