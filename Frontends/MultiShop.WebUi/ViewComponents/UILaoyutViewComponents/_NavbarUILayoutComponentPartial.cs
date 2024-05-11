using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUi.ViewComponents.UILaoyutViewComponents
{
    public class _NavbarUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
