using System.Data.SqlClient;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using AstrolojiApp.Models;
using AstrolojiApp.Areas.Admin.Data;

namespace AstrolojiApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServicesController : Controller
    {
        // GET: ServicesController
        private readonly IRepository<Service> _services;

        public ServicesController(IRepository<Service> services)
        {
            _services = services;
        }

        public async Task<ActionResult> Index()
        {
            //var connectionString = "Server=localhost,1441;Database=AstrologyDb;User=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=true";
            //var connection = new SqlConnection(connectionString);

            //var queryService = "select * from Services";
            //var services = await connection.QueryAsync<Service>(queryService);
            var services=await _services.GetAllAsync();
            
            return View(services);
        }

    }
}