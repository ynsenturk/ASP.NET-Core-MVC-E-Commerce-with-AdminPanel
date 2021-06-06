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
    [Route("admin/customer")]
    public class CustomerController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        public CustomerController(DatabaseContext _db)
        {
            db = _db;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.Customers = db.Accounts.Where(a => a.RoleAccounts.FirstOrDefault().RoleId == 2).ToList();
            return View();
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            var customer = db.Accounts.Find(id);
            return View("edit", customer);
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(int id, Account account)
        {
            var customer = db.Accounts.Find(id);
            if (!string.IsNullOrEmpty(account.Password))
            {
                customer.Password = BCrypt.Net.BCrypt.HashPassword(account.Password);
            }
            customer.FullName = account.FullName;
            customer.Email = account.Email;
            customer.Status = account.Status;
            db.SaveChanges();
            return RedirectToAction("Index", "Customer", new { area = "admin" });
        }
    }
}
