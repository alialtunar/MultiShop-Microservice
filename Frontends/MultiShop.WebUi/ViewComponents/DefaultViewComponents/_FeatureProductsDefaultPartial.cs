using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUi.ViewComponents.DefaultViewComponents
{
    public class _FeatureProductsDefaultPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
