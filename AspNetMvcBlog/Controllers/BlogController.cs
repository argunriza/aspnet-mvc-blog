using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Search(string query, int page)
        {
            return View();
        }

        public IActionResult Right(int id)
        {
            return View();
        }

        public IActionResult Left()
        {
            return View();
        }

        public IActionResult Full()
        {
            return View();
        }
    }
}
