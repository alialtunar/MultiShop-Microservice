using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUi.ViewComponents.UILaoyutViewComponents
{
    public class _TopbarUILayoutComponentPartial:ViewComponent
    { 
       public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
