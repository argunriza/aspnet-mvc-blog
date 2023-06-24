using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MvcEticaret.Models;


namespace MvcEticaret.ViewComponents
{

    public class ProductItemViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke(string title, int starCount, string oldPrice, string price, string imageUrl, bool isSale)
        {
            ProductItemModel model = new ProductItemModel()
            {
                Title = title,
                StarCount = starCount,
                OldPrice = oldPrice,
                Price = price,
                ImageUrl = imageUrl,
                IsSale = isSale,
            };

            return View(model);
        }

    }

}
