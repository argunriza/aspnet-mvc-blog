using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Models;
using System.Diagnostics;
using static System.Net.WebRequestMethods;

namespace MvcEticaret.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<ProductItemModel> productList = new List<ProductItemModel>();                                          // Hocam hepsine tek tek resim bulmakla uğraşmadım templatedekini koydum.
            productList.Add(new ProductItemModel() { Title = "Fancy Product", IsSale = false, Price = "$40.00 - $80.00", ImageUrl = "https://dummyimage.com/450x300/dee2e6/6c757d.jpg", });
            productList.Add(new ProductItemModel() { Title = "Special Item", IsSale = true, Price = "$18.00", ImageUrl = "https://dummyimage.com/450x300/dee2e6/6c757d.jpg", OldPrice = "$20.00", StarCount = 5 });
            productList.Add(new ProductItemModel() { Title = "Sale Item", IsSale = true, Price = "$25.00", ImageUrl = "https://dummyimage.com/450x300/dee2e6/6c757d.jpg", OldPrice = "$50.00", });
            productList.Add(new ProductItemModel() { Title = "Popular Item", IsSale = false, Price = "$40.00", ImageUrl = "https://dummyimage.com/450x300/dee2e6/6c757d.jpg", StarCount = 5,});
            productList.Add(new ProductItemModel() { Title = "Sale Item", IsSale = true, Price = "$25.00", ImageUrl = "https://dummyimage.com/450x300/dee2e6/6c757d.jpg", OldPrice = "$50.00",  });
            productList.Add(new ProductItemModel() { Title = "Fancy Product", IsSale = false, Price = "$120.00 - $280.00", ImageUrl = "https://dummyimage.com/450x300/dee2e6/6c757d.jpg", });
            productList.Add(new ProductItemModel() { Title = "Special Item", IsSale = true, Price = "$18.00", ImageUrl = "https://dummyimage.com/450x300/dee2e6/6c757d.jpg", OldPrice = "$20.00", StarCount = 5 });
            productList.Add(new ProductItemModel() { Title = "Popular Item", IsSale = false, Price = "$40.00", ImageUrl = "https://dummyimage.com/450x300/dee2e6/6c757d.jpg", StarCount = 5,  });

            return View(productList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}