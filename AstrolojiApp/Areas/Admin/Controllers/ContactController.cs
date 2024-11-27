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

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var contact = await _contact.GetAsync(id);

            return View(contact);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Contact entity)
        {
            var contact = await _contact.UpdateAsync(entity);

            return RedirectToAction("Index","Contact");
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Add(Contact entity)
        {
            var contact = await _contact.AddAsync(entity);

            return RedirectToAction("Index", "Contact");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _contact.DeleteAsync(id);

            return RedirectToAction("Index", "Contact");
        }

    }
}
