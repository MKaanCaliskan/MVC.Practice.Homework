using BilgeAdam.Common.Dtos;
using BilgeAdam.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace BilgeAdam.MVC.Practice.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;
        private readonly ICustomerService customerService;

        public AdminController(IProductService productService, ICategoryService categoryService, ICustomerService customerService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
            this.customerService = customerService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Product()
        {
            return View();
        }

        public IActionResult Category()
        {
            return View();
        }
        public IActionResult Customer()
        {
            return View();
        }

        public IActionResult DeleteProduct(int id)
        {
            productService.Delete(id);
            return RedirectToAction("Product");
        }
        public IActionResult DeleteCustomer(string id)
        {
            customerService.Delete(id);
            return RedirectToAction("Customer");
        }
        public IActionResult DeleteCategory(int id)
        {   categoryService.Delete(id);
            return RedirectToAction("Category");
        }

        [HttpPost]
        public IActionResult Create(ProductAddDto input)
        {

            if (ModelState.IsValid)
            {
                productService.Add(input);
                return RedirectToAction("Product");
            }
            return View(input);

        }


        public IActionResult CreateCategory(CategoryAddDto input)
        {

            if (ModelState.IsValid)
            {
                categoryService.Add(input);
                return RedirectToAction("Category");
            }
            return View(input);

        }


        public IActionResult CreateCustomer(CustomersAddDto input)
        {

            if (ModelState.IsValid)
            {
                customerService.Add(input);
                return RedirectToAction("Customer");
            }
            return View(input);

        }
    }
}
