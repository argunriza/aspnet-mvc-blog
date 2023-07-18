using AspNetMvcBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Components
{
    public class FooterViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var model3 = GetFooterData();
            return View(model3);
        }

        private FooterModel GetFooterData()
        {
            return new FooterModel();
        }
    }
}
