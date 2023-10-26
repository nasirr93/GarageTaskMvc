using GarageTaskMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace GarageTaskMvc.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Show()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Samsung",
                    Count = 2,
                    Price= 650
                },
                new Product
                {
                    Id = 2,
                    Name = "Iphone",
                    Count = 1,
                    Price= 950
                },
                new Product
                {
                    Id = 3,
                    Name = "Xiaomi",
                    Count = 3,
                    Price= 550
                }
            };
            return View(products);
        }
    }
}
