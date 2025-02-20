using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using AstrolojiApp.Helper;
using AstrolojiApp.Business.Abstract;
using AstrolojiApp.Shared.Dtos;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AstrolojiApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AstrologCommentController : Controller
    {
        private readonly IAstrologCommentService _astrologCommnetService;

        public AstrologCommentController(IAstrologCommentService astrologCommnet)
        {
            _astrologCommnetService = astrologCommnet;
        }



        // GET: AstrologCommentController
        public async Task<ActionResult> Index()
        {
            //var connectionString = "Server=localhost,1441;Database=AstrologyDb;User=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=true";
            //var connection = new SqlConnection(connectionString);

            //var queryAstrologComment = "select * from AstrologComment";
            //var astrologComments = await connection.QueryAsync<AstrologComment>(queryAstrologComment);

            var astrologComments = await _astrologCommnetService.GetAstrologCommentAsync();

            return View(astrologComments);
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var astrologComment = await _astrologCommnetService.GetByIdAsync(id);
            var astrologUpdateDto = new AstrologCommentUpdateDto
            {
                Id = astrologComment.Id,
                Name = astrologComment.Name,
                Image = astrologComment.Image,
                Text = astrologComment.Text
            };
            return View(astrologUpdateDto);
        }


        [HttpPost]
        public async Task<IActionResult> Update(AstrologCommentUpdateDto astrologCommentUpdateDto)
        {


            var astrologComments = await _astrologCommnetService.GetByIdAsync(astrologCommentUpdateDto.Id);

            if (astrologCommentUpdateDto.Image is null)
                astrologCommentUpdateDto.Image = astrologComments.Image;

            var form = HttpContext.Request.Form.Files[0];

            var imgPathAsString = await ImgHelper.ImgUpload(form);

            astrologCommentUpdateDto.Image = imgPathAsString;
            var astrocomments = await _astrologCommnetService.UpdateAsync(astrologCommentUpdateDto);


            return RedirectToAction("Index", "AstrologComment");
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AstrologCommentCreateDto astrologCommentCreateDto)
        {
            if (ModelState.IsValid)
            {
                var astrocomments = await _astrologCommnetService.CreateAsync(astrologCommentCreateDto);

                return RedirectToAction("Index", "AstrologComment");
            }
            return View(astrologCommentCreateDto);

        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await _astrologCommnetService.DeleteAsync(id);

            return RedirectToAction("Index", "AstrologComment");

        }

    }

}
