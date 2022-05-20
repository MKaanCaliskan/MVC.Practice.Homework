using BilgeAdam.Data;
using Microsoft.AspNetCore.Mvc;

namespace BilgeAdam.MVC.Practice.Components
{

    public class ProductViewComponent : ViewComponent
    {
        private readonly NorthwindDbContext dbContext;

        public ProductViewComponent(NorthwindDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IViewComponentResult Invoke()
        {
            var result = dbContext.Products.OrderByDescending(p => p.ProductID).Take(10).ToList();
            return View(result);
        }
    }
}
