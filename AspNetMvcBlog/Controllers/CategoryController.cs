using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace AspNetMvcBlog.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index(int id, int page)
        {
            return View();
        }
    }
}
