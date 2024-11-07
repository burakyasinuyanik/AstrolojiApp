using System.Data.SqlClient;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using AstrolojiApp.Models;

namespace AstrolojiApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AstrologCommentController : Controller
    {
        // GET: AstrologCommentController
        public async Task<ActionResult> Index()
        {
            var connectionString = "Server=localhost,1441;Database=AstrologyDb;User=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=true";
            var connection = new SqlConnection(connectionString);

            var queryAstrologComment = "select * from AstrologComment";
            var astrologComments = await connection.QueryAsync<AstrologComment>(queryAstrologComment);

            return View(astrologComments);
        }

    }


}
