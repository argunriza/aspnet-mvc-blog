using AspNetMvcBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Components
{
    public class SliderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            SliderModel model2 = this.GetSliderData();

            return View(model2);
        }

        private SliderModel GetSliderData()
        {
            return new SliderModel();
        }
    }
}
