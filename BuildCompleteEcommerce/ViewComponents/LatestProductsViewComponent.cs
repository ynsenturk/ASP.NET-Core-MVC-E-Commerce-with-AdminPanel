using BuildCompleteEcommerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildCompleteEcommerce.ViewComponents
{
    [ViewComponent(Name = "LatestProducts")]
    public class LatestProductsViewComponent : ViewComponent
    {
        private DatabaseContext db;
        public LatestProductsViewComponent(DatabaseContext _db)
        {
            db = _db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Product> products = db.Products.OrderByDescending(p => p.Id).Where(p => p.Status).Take(2).ToList();
            return View("Index", products);
        }
    }
}
