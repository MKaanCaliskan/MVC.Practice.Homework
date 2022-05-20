using BilgeAdam.Data;
using Microsoft.AspNetCore.Mvc;

namespace BilgeAdam.MVC.Practice.Components
{
    public class CategoryListViewComponent :ViewComponent
    {
        private readonly NorthwindDbContext dbContext;

        public CategoryListViewComponent(NorthwindDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IViewComponentResult Invoke()
        {
            var result = dbContext.Categories.OrderByDescending(p => p.CategoryID).ToList();
            return View(result);
        }
    }
}
