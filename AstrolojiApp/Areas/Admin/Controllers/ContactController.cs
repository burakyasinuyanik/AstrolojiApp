using AstrolojiApp.Areas.Admin.Data;
using AstrolojiApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Dapper;

namespace AstrolojiApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        private readonly IRepository<Contact> _contact;

        public ContactController(IRepository<Contact> contact)
        {
            _contact = contact;
        }

        // GET: ContactController
        public async Task<ActionResult> Index()
        {
            var contact = await _contact.GetAllAsync();
            return View(contact);
        }

    }
}
