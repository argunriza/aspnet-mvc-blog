using AspNetMvcBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Components
{
    public class NavbarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var model = GetNavbarData();
            return View(model);
            
        }

        private NavbarModel GetNavbarData()
        {
            // Navbar için verileri hazırlayan iş mantığı burada olmalı.
            // Örneğin, kullanıcı oturum açmış mı, belirli menü öğelerini belirlemek için kullanılabilir.
            // Bu, ihtiyacınıza göre değişebilir.
            return new NavbarModel
            {
                // Navbar verileriniz burada olmalı.
            };
        }


    }

  
}
