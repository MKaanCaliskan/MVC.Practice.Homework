using BilgeAdam.Data;
using Microsoft.AspNetCore.Mvc;

namespace BilgeAdam.MVC.Practice.Components
{
    public class CustomerViewComponent : ViewComponent
    {
        private readonly NorthwindDbContext dbContext;

        public CustomerViewComponent(NorthwindDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IViewComponentResult Invoke()
        {
            var result = dbContext.Customers.ToList();
            return View(result);
        }
    }
}
