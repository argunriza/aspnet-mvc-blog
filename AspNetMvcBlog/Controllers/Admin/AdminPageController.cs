using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers.Admin
{
    public class AdminPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
