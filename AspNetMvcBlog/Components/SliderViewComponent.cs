using AspNetMvcBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Components
{
    public class SliderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var model2 = GetSliderData();
            return View(model2);
        }

        private SliderModel GetSliderData()
        {
            return new SliderModel();
        }
    }
}
