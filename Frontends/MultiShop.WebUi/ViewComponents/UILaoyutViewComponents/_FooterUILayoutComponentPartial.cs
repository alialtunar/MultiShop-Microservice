using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUi.ViewComponents.UILaoyutViewComponents
{
    public class _FooterUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
