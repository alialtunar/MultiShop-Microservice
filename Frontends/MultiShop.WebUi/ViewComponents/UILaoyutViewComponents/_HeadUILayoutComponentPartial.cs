using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUi.ViewComponents.UILaoyutViewComponents
{
    public class _HeadUILayoutComponentPartial:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
