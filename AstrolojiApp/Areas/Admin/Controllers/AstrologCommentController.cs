using System.Data.SqlClient;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using AstrolojiApp.Models;
using AstrolojiApp.Areas.Admin.Data;

namespace AstrolojiApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AstrologCommentController : Controller
    {
        private readonly IRepository<AstrologComment> _astrologComment;

        public AstrologCommentController(IRepository<AstrologComment> astrologComment)
        {
            _astrologComment = astrologComment;
        }

        // GET: AstrologCommentController
        public async Task<ActionResult> Index()
        {
            //var connectionString = "Server=localhost,1441;Database=AstrologyDb;User=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=true";
            //var connection = new SqlConnection(connectionString);

            //var queryAstrologComment = "select * from AstrologComment";
            //var astrologComments = await connection.QueryAsync<AstrologComment>(queryAstrologComment);

            var astrologComments= await _astrologComment.GetAllAsync();

            return View(astrologComments);
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var astrologComments = await _astrologComment.GetAsync(id);
            return View(astrologComments);
        }


        [HttpPost]
        public async Task<IActionResult> Update(AstrologComment entity)
        {
            var astrocomments = await _astrologComment.UpdateAsync(entity);

            return RedirectToAction("Index","AstrologComment");
        }

        [HttpGet]
        public async Task<IActionResult> Add()
         {

            return View();
         }

         [HttpPost]
            public async Task<IActionResult> Add(AstrologComment entity)
         {
            var astrocomments = await _astrologComment.AddAsync(entity);

            return RedirectToAction("Index", "AstrologComment");

         }

         [HttpGet]
         public async Task<IActionResult> Delete(int id)
         {
            var result = await _astrologComment.DeleteAsync(id);

            return RedirectToAction("Index", "AstrologComment");
         }
        
    }

}
