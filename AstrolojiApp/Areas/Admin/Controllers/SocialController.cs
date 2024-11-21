using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Dapper;
using AstrolojiApp.Models;
using AstrolojiApp.Areas.Admin.Data;

namespace AstrolojiApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SocialController : Controller
    {

        private readonly IRepository<SocialMedia> _social;

        public SocialController(IRepository<SocialMedia> social)
        {
            _social = social;
        }
        // GET: SocialController
        public async Task<ActionResult> Index()
        {

            var social = await _social.GetAllAsync();
            return View(social);
        }

    }
}
