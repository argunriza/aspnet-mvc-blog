using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers.Admin
{
    public class AdminSettingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
