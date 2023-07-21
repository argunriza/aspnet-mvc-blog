using AspNetMvcBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Components
{
    public class NavbarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            NavbarModel model = this.GetNavbarData();

            return View(model);
        }

        private NavbarModel GetNavbarData()
        {
            return new NavbarModel { };
        }
    }
}
