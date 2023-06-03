using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers.Admin
{
    public class AdminCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
