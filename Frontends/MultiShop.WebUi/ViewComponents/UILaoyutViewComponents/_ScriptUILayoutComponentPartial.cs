using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUi.ViewComponents.UILaoyutViewComponents
{
    public class _ScriptUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
