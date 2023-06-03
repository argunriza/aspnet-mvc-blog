using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers.Admin
{
    public class AdminUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
