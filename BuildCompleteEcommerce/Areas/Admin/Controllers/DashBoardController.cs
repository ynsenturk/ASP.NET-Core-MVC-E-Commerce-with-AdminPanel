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
    [Route("admin/dashboard")]
    public class DashBoardController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        public DashBoardController(DatabaseContext _db)
        {
            db = _db;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.countInvoices = db.Invoices.Where(i => i.Status == 1).Count();
            ViewBag.countProducts = db.Products.Count();
            ViewBag.countCustomer = db.RoleAccounts.Count(ra => ra.RoleId == 2);
            ViewBag.countCategories = db.Categories.Count(c => c.ParentId == null);
            return View();
        }
    }
}
