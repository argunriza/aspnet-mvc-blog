using AspNetMvcBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Components
{
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            FooterModel model3 = this.GetFooterData();

            return View(model3);
        }

        private FooterModel GetFooterData()
        {
            return new FooterModel();
        }
    }
}
