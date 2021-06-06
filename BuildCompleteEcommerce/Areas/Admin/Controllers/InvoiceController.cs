using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuildCompleteEcommerce.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BuildCompleteEcommerce.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin", AuthenticationSchemes = "Admin_Schema")]
    [Area("admin")]
    [Route("admin/invoice")]
    public class InvoiceController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        public InvoiceController(DatabaseContext _db)
        {
            db = _db;
        }

        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            ViewBag.invoices = db.Invoices.OrderByDescending(i => i.Id).ToList();
            return View();
        }

        [HttpGet]
        [Route("details/{id}")]
        public IActionResult Details(int id)
        {
            ViewBag.invoice = db.Invoices.Find(id);
            return View("Details");
        }

        [HttpPost]
        [Route("process")]
        public IActionResult Process(int id)
        {
            var invoice = db.Invoices.Find(id);
            invoice.Status = 2;
            db.SaveChanges();
            return RedirectToAction("Index", "Invoice", new { area = "admin" });
        }
    }
}
